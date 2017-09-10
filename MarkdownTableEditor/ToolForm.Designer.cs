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
			this.btnAddColumn = new System.Windows.Forms.Button();
			this.btnDelColumn = new System.Windows.Forms.Button();
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
			this.split.Panel1.Controls.Add(this.btnDelColumn);
			this.split.Panel1.Controls.Add(this.btnAddColumn);
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
			this.btnLoadData.BackColor = System.Drawing.Color.Honeydew;
			this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadData.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnLoadData.ForeColor = System.Drawing.Color.SeaGreen;
			this.btnLoadData.Location = new System.Drawing.Point(3, 3);
			this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.btnLoadData.Name = "btnLoadData";
			this.btnLoadData.Size = new System.Drawing.Size(319, 30);
			this.btnLoadData.TabIndex = 0;
			this.btnLoadData.Text = "↓";
			this.btnLoadData.UseVisualStyleBackColor = false;
			this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
			// 
			// btnChangeMarkdown
			// 
			this.btnChangeMarkdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnChangeMarkdown.BackColor = System.Drawing.Color.LavenderBlush;
			this.btnChangeMarkdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangeMarkdown.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnChangeMarkdown.ForeColor = System.Drawing.Color.Crimson;
			this.btnChangeMarkdown.Location = new System.Drawing.Point(3, 3);
			this.btnChangeMarkdown.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.btnChangeMarkdown.Name = "btnChangeMarkdown";
			this.btnChangeMarkdown.Size = new System.Drawing.Size(361, 30);
			this.btnChangeMarkdown.TabIndex = 1;
			this.btnChangeMarkdown.Text = "|MARKDOWN|";
			this.btnChangeMarkdown.UseVisualStyleBackColor = false;
			this.btnChangeMarkdown.Click += new System.EventHandler(this.btnChangeMarkdown_Click);
			// 
			// dgvInputTable
			// 
			this.dgvInputTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvInputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInputTable.Location = new System.Drawing.Point(3, 36);
			this.dgvInputTable.Name = "dgvInputTable";
			this.dgvInputTable.RowTemplate.Height = 21;
			this.dgvInputTable.Size = new System.Drawing.Size(385, 422);
			this.dgvInputTable.TabIndex = 1;
			// 
			// txtMarkdownTest
			// 
			this.txtMarkdownTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMarkdownTest.BackColor = System.Drawing.Color.Black;
			this.txtMarkdownTest.ForeColor = System.Drawing.Color.White;
			this.txtMarkdownTest.Location = new System.Drawing.Point(3, 36);
			this.txtMarkdownTest.Multiline = true;
			this.txtMarkdownTest.Name = "txtMarkdownTest";
			this.txtMarkdownTest.ReadOnly = true;
			this.txtMarkdownTest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMarkdownTest.Size = new System.Drawing.Size(361, 389);
			this.txtMarkdownTest.TabIndex = 2;
			this.txtMarkdownTest.WordWrap = false;
			// 
			// btnCopyText
			// 
			this.btnCopyText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyText.BackColor = System.Drawing.Color.Lavender;
			this.btnCopyText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopyText.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnCopyText.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnCopyText.Location = new System.Drawing.Point(3, 428);
			this.btnCopyText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.btnCopyText.Name = "btnCopyText";
			this.btnCopyText.Size = new System.Drawing.Size(361, 30);
			this.btnCopyText.TabIndex = 3;
			this.btnCopyText.Text = "copy";
			this.btnCopyText.UseVisualStyleBackColor = false;
			this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
			// 
			// btnAddColumn
			// 
			this.btnAddColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddColumn.BackColor = System.Drawing.Color.Pink;
			this.btnAddColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddColumn.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnAddColumn.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.btnAddColumn.Location = new System.Drawing.Point(325, 3);
			this.btnAddColumn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
			this.btnAddColumn.Name = "btnAddColumn";
			this.btnAddColumn.Size = new System.Drawing.Size(30, 30);
			this.btnAddColumn.TabIndex = 2;
			this.btnAddColumn.Text = "＋";
			this.btnAddColumn.UseVisualStyleBackColor = false;
			this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
			// 
			// btnDelColumn
			// 
			this.btnDelColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelColumn.BackColor = System.Drawing.Color.Pink;
			this.btnDelColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelColumn.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnDelColumn.ForeColor = System.Drawing.Color.MediumVioletRed;
			this.btnDelColumn.Location = new System.Drawing.Point(358, 3);
			this.btnDelColumn.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
			this.btnDelColumn.Name = "btnDelColumn";
			this.btnDelColumn.Size = new System.Drawing.Size(30, 30);
			this.btnDelColumn.TabIndex = 3;
			this.btnDelColumn.Text = "－";
			this.btnDelColumn.UseVisualStyleBackColor = false;
			this.btnDelColumn.Click += new System.EventHandler(this.btnDelColumn_Click);
			// 
			// ToolForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 481);
			this.Controls.Add(this.split);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
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
		private System.Windows.Forms.Button btnDelColumn;
		private System.Windows.Forms.Button btnAddColumn;
	}
}

