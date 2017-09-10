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
	public partial class LoadDataDialog : Form
	{
		public class MarkdownTable
		{
			public string[] Header { get; private set; }

			public List<string[]> Rows { get; private set; }

			public MarkdownTable(string[] header)
			{
				this.Header = header;
				this.Rows = new List<string[]>();
			}
		}
		public MarkdownTable Data { get; private set; }

		#region ctor / Load
		public LoadDataDialog()
		{
			InitializeComponent();
		}

		private void LoadDataDialog_Load( object sender, EventArgs e )
		{
			TextBox[] txts = {
				this.txtMarkdownTable
			};
			txts.ctrl_a();


			this.TopMost = this.chkTopMost.Checked = true;
			
			this.chkTopMost.CheckedChanged += ( _, a ) => {
					this.TopMost = this.chkTopMost.Checked;
			};
		}
		#endregion


		#region LoadData

		private void btnLoadData_Click( object sender, EventArgs e )
		{
			try
			{
				if ( this.LoadData() )
				{
					this.Close();
				}
			}
			catch ( Exception ex )
			{
				MessageBox.Show( ex.Message );
			}
		}
		private bool LoadData()
		{
			var lines = this.txtMarkdownTable.Text
					.lines()
					.Where( x => x.notEmpty() )
					.ToList();

			// 有効なデータ行が無い場合は false
			if ( 0 == lines.Count ) return false;

			// TODO：パーサロジックはもう少し頭良くするべきか・・・検討。
			string header = lines[0];

			var data = new MarkdownTable( header.split("|") );
			foreach ( var line in lines.Skip(2) )
			{
				data.Rows.Add( line.split("|") );
			}

			this.Data = data;
			this.DialogResult = DialogResult.OK;
			return true;
		}
		#endregion
	}
}
