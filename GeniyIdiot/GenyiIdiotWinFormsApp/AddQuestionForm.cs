using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenyiIdiotWinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void questionStorageButton_Click(object sender, EventArgs e)
        {
            var questionStorageForm = new QuestionsStorageForm();
            questionStorageForm.ShowDialog();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            string textQuestion = textQuestionTextBox.Text;
            string answerQuestion = answerQuestionTextBox.Text;

            if (CheckUserQuestion(textQuestion) && QuestionsForm.ChackUserAnswer(answerQuestion))
            {
                var question = new Question(textQuestion, Convert.ToInt32(answerQuestion));
                QuestionsStorage.Append(question);

                MessageBox.Show("Вопрос добавлен.");

                textQuestionTextBox.Clear();
                answerQuestionTextBox.Clear();
            }
        }

        private static bool CheckUserQuestion(string textQuestion)
        {
            int questionMark = 0;

            for (int i = 0; i < textQuestion.Length; i++)
            {
                if (textQuestion[i] == '?')
                {
                    questionMark++;
                }
            }

            if (questionMark != 1)
            {
                MessageBox.Show("Введите вопрос с одним вопросительным знаком.");
                return false;
            }

            return true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddQuestionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                addQuestionButton.PerformClick();
            }
        }
    }
}
