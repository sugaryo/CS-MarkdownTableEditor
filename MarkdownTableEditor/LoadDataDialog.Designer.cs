namespace MarkdownTableEditor
{
	partial class LoadDataDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtMarkdownTable = new System.Windows.Forms.TextBox();
			this.btnLoadData = new System.Windows.Forms.Button();
			this.chkTopMost = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// txtMarkdownTable
			// 
			this.txtMarkdownTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMarkdownTable.Location = new System.Drawing.Point(12, 32);
			this.txtMarkdownTable.Multiline = true;
			this.txtMarkdownTable.Name = "txtMarkdownTable";
			this.txtMarkdownTable.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMarkdownTable.Size = new System.Drawing.Size(390, 182);
			this.txtMarkdownTable.TabIndex = 0;
			this.txtMarkdownTable.WordWrap = false;
			// 
			// btnLoadData
			// 
			this.btnLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoadData.BackColor = System.Drawing.Color.Lavender;
			this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadData.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnLoadData.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnLoadData.Location = new System.Drawing.Point(12, 217);
			this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.btnLoadData.Name = "btnLoadData";
			this.btnLoadData.Size = new System.Drawing.Size(390, 32);
			this.btnLoadData.TabIndex = 1;
			this.btnLoadData.Text = "マークダウン読み込み";
			this.btnLoadData.UseVisualStyleBackColor = false;
			this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
			// 
			// chkTopMost
			// 
			this.chkTopMost.AutoSize = true;
			this.chkTopMost.Location = new System.Drawing.Point(12, 12);
			this.chkTopMost.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.chkTopMost.Name = "chkTopMost";
			this.chkTopMost.Size = new System.Drawing.Size(66, 16);
			this.chkTopMost.TabIndex = 2;
			this.chkTopMost.Text = "TopMost";
			this.chkTopMost.UseVisualStyleBackColor = true;
			// 
			// LoadDataDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 261);
			this.Controls.Add(this.chkTopMost);
			this.Controls.Add(this.btnLoadData);
			this.Controls.Add(this.txtMarkdownTable);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "LoadDataDialog";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "MARKDOWN table read";
			this.Load += new System.EventHandler(this.LoadDataDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMarkdownTable;
		private System.Windows.Forms.Button btnLoadData;
		private System.Windows.Forms.CheckBox chkTopMost;
	}
}