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
	public partial class Correct_Window : Form
	{
		public Correct_Window()
		{
			InitializeComponent();

			// ListViewコントロールのプロパティを設定
			list_Correct.FullRowSelect = true;
			list_Correct.GridLines = true;
			list_Correct.Sorting = SortOrder.Ascending;
			list_Correct.View = View.Details;

			var QuestionNum = new ColumnHeader();
			var CorrectText = new ColumnHeader();
			var MyAnswerText = new ColumnHeader();
			var AnswerText = new ColumnHeader();

			QuestionNum.Text = "問題番号";
			QuestionNum.Width = 60;
			CorrectText.Text = "正誤";
			CorrectText.Width = 60;
			MyAnswerText.Text = "回答";
			MyAnswerText.Width = 200;
			AnswerText.Text = "正解";
			AnswerText.Width = 200;

			ColumnHeader[] colHeaderRegValue = { QuestionNum, CorrectText, MyAnswerText, AnswerText };
			list_Correct.Columns.AddRange(colHeaderRegValue);
		}

		public void LoadCorrectData(List<Data_Correct> correctData)
		{
			list_Correct.Sorting = SortOrder.None;

			foreach (var item in correctData)
			{
				list_Correct.Items.Add(new ListViewItem(new string[] { item.QuestionNum.ToString(), item.CorrectText, item.MyAnswerText, item.AnswerText }));
			}
		}
	}
}
