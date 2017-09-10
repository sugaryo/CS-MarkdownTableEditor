namespace MarkdownTableEditor
{
	partial class ToolForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.split = new System.Windows.Forms.SplitContainer();
			this.btnLoadData = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dgvInputTable = new System.Windows.Forms.DataGridView();
			this.txtMarkdownTest = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
			this.split.Panel1.SuspendLayout();
			this.split.Panel2.SuspendLayout();
			this.split.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvInputTable)).BeginInit();
			this.SuspendLayout();
			// 
			// split
			// 
			this.split.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.split.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.split.Location = new System.Drawing.Point(9, 9);
			this.split.Margin = new System.Windows.Forms.Padding(0);
			this.split.Name = "split";
			// 
			// split.Panel1
			// 
			this.split.Panel1.Controls.Add(this.dgvInputTable);
			this.split.Panel1.Controls.Add(this.btnLoadData);
			// 
			// split.Panel2
			// 
			this.split.Panel2.Controls.Add(this.txtMarkdownTest);
			this.split.Panel2.Controls.Add(this.button1);
			this.split.Size = new System.Drawing.Size(766, 463);
			this.split.SplitterDistance = 393;
			this.split.TabIndex = 0;
			// 
			// btnLoadData
			// 
			this.btnLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoadData.Location = new System.Drawing.Point(3, 3);
			this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.btnLoadData.Name = "btnLoadData";
			this.btnLoadData.Size = new System.Drawing.Size(385, 40);
			this.btnLoadData.TabIndex = 0;
			this.btnLoadData.Text = "↓";
			this.btnLoadData.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(361, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "↑";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dgvInputTable
			// 
			this.dgvInputTable.AllowUserToOrderColumns = true;
			this.dgvInputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInputTable.Location = new System.Drawing.Point(3, 46);
			this.dgvInputTable.Name = "dgvInputTable";
			this.dgvInputTable.RowTemplate.Height = 21;
			this.dgvInputTable.Size = new System.Drawing.Size(385, 412);
			this.dgvInputTable.TabIndex = 1;
			// 
			// txtMarkdownTest
			// 
			this.txtMarkdownTest.Location = new System.Drawing.Point(3, 46);
			this.txtMarkdownTest.Multiline = true;
			this.txtMarkdownTest.Name = "txtMarkdownTest";
			this.txtMarkdownTest.ReadOnly = true;
			this.txtMarkdownTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMarkdownTest.Size = new System.Drawing.Size(361, 412);
			this.txtMarkdownTest.TabIndex = 2;
			this.txtMarkdownTest.WordWrap = false;
			// 
			// ToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 481);
			this.Controls.Add(this.split);
			this.Name = "ToolForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "#MARKDOWN table editor";
			this.Load += new System.EventHandler(this.ToolForm_Load);
			this.split.Panel1.ResumeLayout(false);
			this.split.Panel2.ResumeLayout(false);
			this.split.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
			this.split.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvInputTable)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer split;
		private System.Windows.Forms.DataGridView dgvInputTable;
		private System.Windows.Forms.Button btnLoadData;
		private System.Windows.Forms.TextBox txtMarkdownTest;
		private System.Windows.Forms.Button button1;
	}
}

