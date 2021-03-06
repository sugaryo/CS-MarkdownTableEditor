﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MarkdownTableEditor.Extensions;

namespace MarkdownTableEditor
{
	public partial class ToolForm : Form
	{
		private DataTable datasource;
		
		#region ctor / Load
		public ToolForm()
		{
			InitializeComponent();

			this.datasource = new DataTable();
			this.datasource.Columns.Add( "", typeof(string) );
			this.datasource.Columns.Add( "", typeof(string) );
			this.datasource.Columns.Add( "", typeof(string) );
		}

		private void ToolForm_Load( object sender, EventArgs e )
		{
			TextBox[] txts = {
				this.txtMarkdownTest
			};
			txts.ctrl_a();

			this.dgvInputTable.DataSource = this.datasource;


			this.MouseWheel += ToolForm_MouseWheel;
			this.SetFontSize( 12f );
		}
		private void ToolForm_MouseWheel( object sender, MouseEventArgs e )
		{
			bool ctrl = ( Control.ModifierKeys & Keys.Control ) == Keys.Control;

			if ( ctrl )
			{
				bool up = e.Delta > 0;

				float size = this.Font.Size;

				
				this.SetFontSize( up
						? Math.Min( size + 2f, 32f )
						: Math.Max( size - 2f, 8f ) 
				);
			}
		}
		private void SetFontSize( float size )
		{
			// 新しいフォントの生成。
			Font f = this.Font.resize( size );

			// 新しいフォントの設定。
			this.Font = f;
			var copy = this.children()
				.Where( x => x is Button
						  || x is TextBox
						  || x is DataGridView );
			foreach ( var c in copy )
			{
				c.Font = this.Font;
			}


			// フォント設定に伴うDataGridViewのサイズ変更。
			this.dgvInputTable.RowTemplate.Height = f.Height + 2;
			foreach ( DataGridViewRow row in this.dgvInputTable.Rows )
			{
				row.Height = this.dgvInputTable.RowTemplate.Height;
			}

			// フォント設定に伴うSplitContainerのサイズ補正。
			// スクリーンサイズ以上にぶっ飛んじゃうとレイアウトが崩れるので。
			Size cs = this.ClientSize;
			this.split.Size = new Size( 
					cs.Width  - 20, 
					cs.Height - 20 );
		}
		#endregion

		#region LoadData
		private void btnLoadData_Click( object sender, EventArgs e )
		{
			try
			{
				this.LoadData();
			}
			catch ( Exception ex )
			{
				MessageBox.Show( ex.Message );
			}
		}
		private void LoadData()
		{
			LoadDataDialog.MarkdownTable data;
			if ( this.TryGetData( out data ) )
			{
				// ダイアログから読み込んだデータでDataTableを再生成。
				DataTable dt = new DataTable();

				for ( int i = 0; i < data.Header.Length; i++ )
				{
					dt.Columns.Add( "", typeof(string) );
				}

				AddRow( dt, data.Header );

				foreach ( string[] row in data.Rows )
				{
					var rowdata = row.Take( data.Header.Length );

					AddRow( dt, rowdata );
				}


				// ViewにバインドするDatSourceを差し替え。
				this.dgvInputTable.DataSource = this.datasource = dt;

				// マークダウン変換テキストをクリア。
				this.txtMarkdownTest.Text = "";
			}
		}
		private bool TryGetData( out LoadDataDialog.MarkdownTable data )
		{
			using ( LoadDataDialog dialog = new LoadDataDialog() )
			{
				bool ok = dialog.ShowDialog() == DialogResult.OK;

				data = ok ? dialog.Data : null;
				return ok;
			}
		}
		
		private static void AddRow( DataTable dt, IEnumerable<string> data)
		{
			DataRow row = dt.NewRow();

			int i = 0;
			foreach ( string s in data )
			{
				row[i++] = s;
			}

			dt.Rows.Add( row );
		}
		#endregion

		#region ChangeMarkdown
		private void btnChangeMarkdown_Click( object sender, EventArgs e )
		{
			try
			{
				this.txtMarkdownTest.Text = this.ChangeMarkdown();
			}
			catch ( Exception ex )
			{				
				this.txtMarkdownTest.Text = ex.StackTrace;
				MessageBox.Show( ex.Message );
			}
		}
		private string ChangeMarkdown()
		{
			StringBuilder sb = new StringBuilder();

			bool first = true;
			
			foreach ( DataRow row in this.datasource.asRows() )
			{
				var cols = row.asColumns().Select( x => x as string );
				
				sb.AppendLine( cols.arounds( "|" ) );
				

				// 初回のみ以下実行。
				if ( first )
				{
					first = false;
					
					var tokens = "----".repeat( this.datasource.Columns.Count );

					sb.AppendLine( tokens.arounds( "|" ) );
				}
			}

			string markdown = sb.ToString();
			return markdown;
		}
		#endregion

		#region CopyText
		private void btnCopyText_Click( object sender, EventArgs e )
		{
			try
			{
				this.CopyText();
			}
			catch ( Exception ex )
			{				
				this.txtMarkdownTest.Text = ex.StackTrace;
				MessageBox.Show( ex.Message );
			}
		}
		private void CopyText()
		{
			string text = this.txtMarkdownTest.Text;
			
			Clipboard.Clear();
			Clipboard.SetText( text );
		}
		#endregion

		#region Add/Del column
		private void btnAddColumn_Click( object sender, EventArgs e )
		{
			try
			{
				this.AddColumn();
			}
			catch ( Exception ex )
			{				
				this.txtMarkdownTest.Text = ex.StackTrace;
				MessageBox.Show( ex.Message );
			}
		}

		private void btnDelColumn_Click( object sender, EventArgs e )
		{
			try
			{
				this.DelColumn();
			}
			catch ( Exception ex )
			{				
				this.txtMarkdownTest.Text = ex.StackTrace;
				MessageBox.Show( ex.Message );
			}
		}

		private void AddColumn()
		{
			this.datasource.Columns.Add( "", typeof(string) );
		}
		private void DelColumn()
		{
			int n = this.datasource.Columns.Count;

			if ( 0 == n ) return;
			
			this.datasource.Columns.RemoveAt( n - 1 );
		}
		#endregion
	}
}
