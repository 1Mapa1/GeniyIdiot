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
    public partial class QuestionsStorageForm : Form
    {
        private int numberQuestion = 0;
        public QuestionsStorageForm()
        {
            InitializeComponent();
        }

        private void QuestionsStorageForm1_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn
            {
                HeaderText = "№",
                Width = 50,
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column2 = new DataGridViewColumn
            {
                HeaderText = "Вопрос",
                Width = 600,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column3 = new DataGridViewColumn
            {
                HeaderText = "Ответ",
                Width = 100,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            questionStorageDataGridView.Columns.Add(column1);
            questionStorageDataGridView.Columns.Add(column2);
            questionStorageDataGridView.Columns.Add(column3);

            var questions = QuestionsStorage.GetQuestions();

            foreach (var question in questions)
            {
                numberQuestion++;
                questionStorageDataGridView.Rows.Add(Convert.ToString(numberQuestion), question.Text, Convert.ToString(question.Answer));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
