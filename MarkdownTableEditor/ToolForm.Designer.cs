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
			this.btnChangeMarkdown = new System.Windows.Forms.Button();
			this.dgvInputTable = new System.Windows.Forms.DataGridView();
			this.txtMarkdownTest = new System.Windows.Forms.TextBox();
			this.btnCopyText = new System.Windows.Forms.Button();
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
			this.split.Panel2.Controls.Add(this.btnCopyText);
			this.split.Panel2.Controls.Add(this.txtMarkdownTest);
			this.split.Panel2.Controls.Add(this.btnChangeMarkdown);
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
			this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
			// 
			// btnChangeMarkdown
			// 
			this.btnChangeMarkdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnChangeMarkdown.Location = new System.Drawing.Point(3, 3);
			this.btnChangeMarkdown.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.btnChangeMarkdown.Name = "btnChangeMarkdown";
			this.btnChangeMarkdown.Size = new System.Drawing.Size(361, 20);
			this.btnChangeMarkdown.TabIndex = 1;
			this.btnChangeMarkdown.Text = "markdown";
			this.btnChangeMarkdown.UseVisualStyleBackColor = true;
			this.btnChangeMarkdown.Click += new System.EventHandler(this.btnChangeMarkdown_Click);
			// 
			// dgvInputTable
			// 
			this.dgvInputTable.AllowUserToOrderColumns = true;
			this.dgvInputTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvInputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInputTable.Location = new System.Drawing.Point(3, 46);
			this.dgvInputTable.Name = "dgvInputTable";
			this.dgvInputTable.RowTemplate.Height = 21;
			this.dgvInputTable.Size = new System.Drawing.Size(385, 412);
			this.dgvInputTable.TabIndex = 1;
			// 
			// txtMarkdownTest
			// 
			this.txtMarkdownTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMarkdownTest.Location = new System.Drawing.Point(3, 26);
			this.txtMarkdownTest.Multiline = true;
			this.txtMarkdownTest.Name = "txtMarkdownTest";
			this.txtMarkdownTest.ReadOnly = true;
			this.txtMarkdownTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMarkdownTest.Size = new System.Drawing.Size(361, 409);
			this.txtMarkdownTest.TabIndex = 2;
			this.txtMarkdownTest.WordWrap = false;
			// 
			// btnCopyText
			// 
			this.btnCopyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyText.Location = new System.Drawing.Point(3, 438);
			this.btnCopyText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.btnCopyText.Name = "btnCopyText";
			this.btnCopyText.Size = new System.Drawing.Size(361, 20);
			this.btnCopyText.TabIndex = 3;
			this.btnCopyText.Text = "markdown";
			this.btnCopyText.UseVisualStyleBackColor = true;
			this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
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
		private System.Windows.Forms.Button btnChangeMarkdown;
		private System.Windows.Forms.Button btnCopyText;
	}
}

