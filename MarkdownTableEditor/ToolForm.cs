using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

		}
		#endregion

		#region CopyText
		private void btnCopyText_Click( object sender, EventArgs e )
		{

		}
		#endregion
	}
}
