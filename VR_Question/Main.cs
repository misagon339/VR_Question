using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VR_Question
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void main_StartButton_Click(object sender, EventArgs e)
		{
			if(comboBox_QuestionAge.Text.Contains("20")) 
			{
				var l_ReadQuestion = new ReadQuestion(comboBox_QuestionAge.Text);
				l_ReadQuestion.Show();
			}
			else
			{
				MessageBox.Show("問題年度を選択してください","お知らせ",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
	}
}
