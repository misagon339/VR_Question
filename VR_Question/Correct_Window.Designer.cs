
namespace VR_Question
{
	partial class Correct_Window
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correct_Window));
			this.label_Correct = new System.Windows.Forms.Label();
			this.list_Correct = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// label_Correct
			// 
			this.label_Correct.AutoSize = true;
			this.label_Correct.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label_Correct.ForeColor = System.Drawing.Color.Silver;
			this.label_Correct.Location = new System.Drawing.Point(218, 9);
			this.label_Correct.Name = "label_Correct";
			this.label_Correct.Size = new System.Drawing.Size(98, 21);
			this.label_Correct.TabIndex = 1;
			this.label_Correct.Text = "採点結果";
			// 
			// list_Correct
			// 
			this.list_Correct.HideSelection = false;
			this.list_Correct.Location = new System.Drawing.Point(12, 43);
			this.list_Correct.Name = "list_Correct";
			this.list_Correct.Size = new System.Drawing.Size(510, 395);
			this.list_Correct.Sorting = System.Windows.Forms.SortOrder.Descending;
			this.list_Correct.TabIndex = 2;
			this.list_Correct.UseCompatibleStateImageBehavior = false;
			// 
			// Correct_Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(534, 450);
			this.Controls.Add(this.list_Correct);
			this.Controls.Add(this.label_Correct);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(550, 489);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 489);
			this.Name = "Correct_Window";
			this.Text = "採点画面";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label_Correct;
		public System.Windows.Forms.ListView list_Correct;
	}
}