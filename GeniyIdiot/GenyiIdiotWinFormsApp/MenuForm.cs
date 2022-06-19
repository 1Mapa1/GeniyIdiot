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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            resultLabel.Text = $"Количество правильных ответов: {QuestionsForm.CountRightAnswers}. {MainForm.UserName}, Ваш диагноз: {QuestionsForm.Diagnos}";

            var user = new User(MainForm.UserName, QuestionsForm.CountRightAnswers, QuestionsForm.Diagnos);

            UsersResultStorage.Append(user);
        }

        private void userResultsButton_Click(object sender, EventArgs e)
        {
            var userResult = new UserResultForm();
            userResult.ShowDialog();
        }

        private void questionStoragebutton_Click(object sender, EventArgs e)
        {
            var questionStorageForm = new QuestionsStorageForm();
            questionStorageForm.ShowDialog();
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            var removeQuestionForm = new RemoveQuestionForm();
            removeQuestionForm.ShowDialog();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm();
            addQuestionForm.ShowDialog();
        }

        private void againPassButton_Click(object sender, EventArgs e)
        {
            QuestionsForm questionsForm = new QuestionsForm();
            questionsForm.Show();
            this.Hide();
        }

        private void exitTestButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
