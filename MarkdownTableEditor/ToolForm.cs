using System;
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
		

		private readonly DataTable datasource;


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
			this.dgvInputTable.DataSource = this.datasource;
		}
		#endregion

		#region LoadData
		private void btnLoadData_Click( object sender, EventArgs e )
		{

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
	}
}
