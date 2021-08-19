
namespace VR_Question
{
	partial class Main
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.main_StartButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox_QuestionAge = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// main_StartButton
			// 
			this.main_StartButton.BackColor = System.Drawing.Color.White;
			this.main_StartButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.main_StartButton.Location = new System.Drawing.Point(325, 295);
			this.main_StartButton.Name = "main_StartButton";
			this.main_StartButton.Size = new System.Drawing.Size(135, 63);
			this.main_StartButton.TabIndex = 0;
			this.main_StartButton.Text = "スタート";
			this.main_StartButton.UseVisualStyleBackColor = false;
			this.main_StartButton.Click += new System.EventHandler(this.main_StartButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(87, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(649, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "VR技術者認定試験 セオリーコース 過去問";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// comboBox_QuestionAge
			// 
			this.comboBox_QuestionAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_QuestionAge.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.comboBox_QuestionAge.FormattingEnabled = true;
			this.comboBox_QuestionAge.ItemHeight = 19;
			this.comboBox_QuestionAge.Items.AddRange(new object[] {
            "2019_7"});
			this.comboBox_QuestionAge.Location = new System.Drawing.Point(258, 158);
			this.comboBox_QuestionAge.MaximumSize = new System.Drawing.Size(500, 0);
			this.comboBox_QuestionAge.Name = "comboBox_QuestionAge";
			this.comboBox_QuestionAge.Size = new System.Drawing.Size(255, 27);
			this.comboBox_QuestionAge.TabIndex = 2;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox_QuestionAge);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.main_StartButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Main";
			this.Text = "VR_Question";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button main_StartButton;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.ComboBox comboBox_QuestionAge;
	}
}

