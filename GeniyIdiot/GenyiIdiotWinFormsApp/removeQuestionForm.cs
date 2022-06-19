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
    public partial class RemoveQuestionForm : Form
    {
        public RemoveQuestionForm()
        {
            InitializeComponent();
        }

        private void questionStorageButton_Click(object sender, EventArgs e)
        {
            var questionsStorageForm = new QuestionsStorageForm();
            questionsStorageForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            var indexQuestion = removeQuestionTextBox.Text;
            var questions = QuestionsStorage.GetQuestions();

            if(QuestionsForm.ChackUserAnswer(indexQuestion) && Convert.ToInt32(indexQuestion) <= questions.Count)
            {
                QuestionsStorage.Remove(Convert.ToInt32(indexQuestion) - 1);

                MessageBox.Show("Вопрос успешно удален.");

                removeQuestionTextBox.Text = "";
            }
            if(Convert.ToInt32(indexQuestion) > questions.Count)
            {
                MessageBox.Show("Введите число не больше " + questions.Count);
            }
        }

        private void RemoveQuestionForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                removeQuestionButton.PerformClick();
            }
        }
    }
}
