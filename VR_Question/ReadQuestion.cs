using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VR_Question
{
	public partial class ReadQuestion : Form
	{

		List<string[]> QuestionData = new List<string[]>(); // CSVの中身を入れるリスト;
		List<string[]> AnswerData = new List<string[]>(); // CSVの中身を入れるリスト;

		List<Data_Question> question_List = new List<Data_Question>();
		List<Data_Answer> answer_List = new List<Data_Answer>();
		List<Data_Correct> correct_List = new List<Data_Correct>();
		private const int Number_Of_Control = 10;

		private int QuestionNumber = 1;
		private int QuestionCnt = 0;

		private string QuestionAge = "";

		public ReadQuestion(string questionAge)
		{
			InitializeComponent();
			ReadData(questionAge);
			CreateQuestionList();
			CreateAnswerList();
			Read_Question(QuestionNumber);
			ReadAnswer(QuestionNumber);
		}

		public void ReadData(string questionAge)
		{
			QuestionAge = questionAge;
			StreamReader question_reader = new StreamReader(@"QuestionData\" + questionAge + "_VRセオリーコース試験問題データ.csv", System.Text.Encoding.GetEncoding("shift_jis"));

			while (question_reader.Peek() != -1)
			{
				string line = question_reader.ReadLine();
				QuestionData.Add(line.Split(','));
			}

			StreamReader answer_reader = new StreamReader(@"QuestionData\" + questionAge + "_VRセオリーコース試験解答データ.csv", System.Text.Encoding.GetEncoding("shift_jis"));

			while (answer_reader.Peek() != -1)
			{
				string line = answer_reader.ReadLine();
				AnswerData.Add(line.Split(','));
			}
		}

		public void CreateQuestionList()
		{
			foreach (var item in QuestionData)
			{
				Data_Question l_data_Question = new Data_Question
				{
					QuestionNum = int.Parse(item[0]),
					Section = int.Parse(item[1]),
					QuestionType = item[2],
					QuestionAnsNum = int.Parse(item[3]),
					ImageContains = int.Parse(item[4]),
					QuestionText = item[5],
				};
				question_List.Add(l_data_Question);
			}
			QuestionCnt = question_List.Count();
		}

		public void CreateAnswerList()
		{
			foreach (var item in AnswerData)
			{
				Data_Answer l_data_Answer = new Data_Answer
				{
					QuestionNum = int.Parse(item[0]),
					Section = int.Parse(item[1]),
					AnswerType = item[2],
					AnswerNum = int.Parse(item[3]),
					AnswerNo = int.Parse(item[4]),
					AnswerSymbol = item[5],
					AnswerText = item[6],
					CorrectAnswer = int.Parse(item[7]),
				};
				answer_List.Add(l_data_Answer);
			}
		}

		public void Read_Question(int i)
		{
			var l_pickQuestion = question_List.Where(x => x.QuestionNum == i);
			string l_questionText = "";
			var l_imagevalue = 0;
			var l_section = 0;
			var l_questionType = "";
			foreach (var t in l_pickQuestion)
			{
				l_section = t.Section;
				l_questionType = t.QuestionType;
				l_questionText = t.QuestionText;
				l_imagevalue = t.ImageContains;
			}
			l_questionText = l_questionText.Replace("\\n", "\n");
			label_QuestionText.Text = l_questionText;

			if (l_imagevalue == 0)
			{
				pictureBox_QuestionImage.Visible = false;
			}
			else
			{
				pictureBox_QuestionImage.Visible = true;
				pictureBox_QuestionImage.BackgroundImageLayout = ImageLayout.Zoom;
				pictureBox_QuestionImage.BackgroundImage = System.Drawing.Image.FromFile(@"image\" + QuestionAge +"\\"+ l_section + "-" + l_questionType + ".png");
			}

		}

		public void ReadAnswer(int num)
		{
			var l_pickAnswer = answer_List.Where(x => x.QuestionNum == num);
			var cnt = l_pickAnswer.Select(x => x.AnswerNum).Distinct().Count();
			RefreshComboBox(cnt);
			UIOFF();
			UION(cnt);

			for (int i = 1; i <= cnt; i++)
			{
				var l_pick = l_pickAnswer.Where(x => x.AnswerNo == i);

				var sb = new StringBuilder();
				sb.Append("label_Answer");
				sb.Append(i);
				var labelName = sb.ToString();
				Control[] labelList = this.Controls.Find(labelName, true);

				for (int j = 0; j < labelList.Length; j++)
				{
					if (labelList[j] is Label)
					{
						foreach (var q in l_pick)
						{
							((Label)labelList[j]).Text = $"（{q.AnswerNum.ToString()}）";
						}
					}
				}

				var sbc = new StringBuilder();
				sbc.Append("comboBox_Answer");
				sbc.Append(i);
				var comboBoxName = sbc.ToString();
				Control[] comboBoxList = this.Controls.Find(comboBoxName, true);

				for (int j = 0; j < comboBoxList.Length; j++)
				{
					if (comboBoxList[j] is ComboBox)
					{
						foreach (var q in l_pick)
						{
							((ComboBox)comboBoxList[j]).Items.Add(q.AnswerText);
						}
					}
				}
			}
		}

		public void UION(int cnt)
		{
			for (int i = 1; i <= cnt; i++)
			{
				var sb = new StringBuilder();
				sb.Append("label_Answer");
				sb.Append(i);
				var labelName = sb.ToString();
				Control[] labelList = this.Controls.Find(labelName, true);

				for (int j = 0; j < labelList.Length; j++)
				{
					if (labelList[j] is Label)
					{
						((Label)labelList[j]).Visible = true;
					}
				}
			}

			for (int i = 1; i <= cnt; i++)
			{
				var sb = new StringBuilder();
				sb.Append("comboBox_Answer");
				sb.Append(i);
				var comboBoxName = sb.ToString();
				Control[] comboBoxList = this.Controls.Find(comboBoxName, true);

				for (int j = 0; j < comboBoxList.Length; j++)
				{
					if (comboBoxList[j] is ComboBox)
					{
						((ComboBox)comboBoxList[j]).Visible = true;
					}
				}
			}
		}

		public void UIOFF()
		{
			for (int i = 1; i <= Number_Of_Control; i++)
			{
				var sb = new StringBuilder();
				sb.Append("label_Answer");
				sb.Append(i);
				var labelName = sb.ToString();

				Control[] labelList = this.Controls.Find(labelName, true);
				for (int j = 0; j < labelList.Length; j++)
				{
					if (labelList[j] is Label)
					{
						((Label)labelList[j]).Visible = false;
					}
				}
			}

			for (int i = 1; i <= Number_Of_Control; i++)
			{
				var sb = new StringBuilder();
				sb.Append("comboBox_Answer");
				sb.Append(i);
				var comboBoxName = sb.ToString();

				Control[] comboBoxList = this.Controls.Find(comboBoxName, true);
				for (int j = 0; j < comboBoxList.Length; j++)
				{
					if (comboBoxList[j] is ComboBox)
					{
						((ComboBox)comboBoxList[j]).Visible = false;
					}
				}
			}
		}

		public void RefreshComboBox(int cnt)
		{
			for (int i = 1; i <= cnt; i++)
			{
				var sb = new StringBuilder();
				sb.Append("comboBox_Answer");
				sb.Append(i);
				var comboBoxName = sb.ToString();
				Control[] comboBoxList = this.Controls.Find(comboBoxName, true);

				for (int j = 0; j < comboBoxList.Length; j++)
				{
					if (comboBoxList[j] is ComboBox)
					{
						((ComboBox)comboBoxList[j]).Items.Clear();
					}
				}
			}
		}


		public void CheckAnswer(int num)
		{
			var l_pickAnswer = answer_List.Where(x => x.QuestionNum == num);
			var cnt = l_pickAnswer.Select(x => x.AnswerNum).Distinct().Count();

			int l_selectAns = 0;
			int l_correctAnswer = 0;

			for (int i = 1; i <= cnt; i++)
			{
				var sb = new StringBuilder();
				sb.Append("comboBox_Answer");
				sb.Append(i);
				var comboBoxName = sb.ToString();
				Control[] comboBoxList = this.Controls.Find(comboBoxName, true);

				for (int j = 0; j < comboBoxList.Length; j++)
				{
					if (comboBoxList[j] is ComboBox)
					{
						string comboText = ((ComboBox)comboBoxList[j]).SelectedItem.ToString();
						var l_select = l_pickAnswer.Where(x => x.AnswerNo == i && x.AnswerText.Contains(comboText));
						var l_answer = l_pickAnswer.Where(x => x.AnswerNo == i && x.CorrectAnswer == 1);
						string l_answerText = "";
						foreach (var t in l_select)
						{
							l_selectAns = t.CorrectAnswer;
						}

						foreach (var a in l_answer)
						{
							l_correctAnswer = a.CorrectAnswer;
							l_answerText = a.AnswerText;
						}


						if (l_selectAns == l_correctAnswer)
						{
							Console.WriteLine("正解");
							foreach (var t in l_select)
							{
								Data_Correct l_data_Correct = new Data_Correct
								{
									QuestionNum = t.AnswerNum,
									CorrectText = "正解",
									MyAnswerText = t.AnswerText,
									AnswerText = l_answerText,
								};
								correct_List.Add(l_data_Correct);
							}
						}
						else
						{
							Console.WriteLine("不正解");
							foreach (var t in l_select)
							{
								Data_Correct l_data_Correct = new Data_Correct
								{
									QuestionNum = t.AnswerNum,
									CorrectText = "不正解",
									MyAnswerText = t.AnswerText,
									AnswerText = l_answerText,
								};
								correct_List.Add(l_data_Correct);
							}
						}
					}
				}
			}
			QuestionNumber++;

		}

		private void button_Answer_Click(object sender, EventArgs e)
		{
			if (DropValueCheck(QuestionNumber))
			{
				if (QuestionNumber < QuestionCnt)
				{
					CheckAnswer(QuestionNumber);
					Read_Question(QuestionNumber);
					ReadAnswer(QuestionNumber);
				}
				else
				{
					CheckAnswer(QuestionNumber);
					CorrectWindowShow();
				}
			}
		}

		public bool DropValueCheck(int num)
		{
			var l_pickAnswer = answer_List.Where(x => x.QuestionNum == num);
			var cnt = l_pickAnswer.Select(x => x.AnswerNum).Distinct().Count();
			bool isNull = true;
			for (int i = 1; i <= cnt; i++)
			{
				var sb = new StringBuilder();
				sb.Append("comboBox_Answer");
				sb.Append(i);
				var comboBoxName = sb.ToString();
				Control[] comboBoxList = this.Controls.Find(comboBoxName, true);

				for (int j = 0; j < comboBoxList.Length; j++)
				{
					if (comboBoxList[j] is ComboBox)
					{
						if (((ComboBox)comboBoxList[j]).SelectedItem == null)
						{
							isNull = false;
							break;
						}
					}
				}
			}

			return isNull;

		}



		private void button_correct_Click(object sender, EventArgs e)
		{
			var cl = new Correct_Window();
			cl.LoadCorrectData(correct_List);
			cl.Show();
		}

		public void CorrectWindowShow()
		{
			var cl = new Correct_Window();
			cl.LoadCorrectData(correct_List);
			cl.Show();
		}

	}



}
