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
    public partial class UserResultForm : Form
    {
        public UserResultForm()
        {
            InitializeComponent();
        }

        private void UserResult_Load(object sender, EventArgs e)
        {
            var column1 = new DataGridViewColumn
            {
                HeaderText = "Имя",
                ReadOnly = true,
                Frozen = true,
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column2 = new DataGridViewColumn
            {
                HeaderText = "Количество баллов",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            var column3 = new DataGridViewColumn
            {
                HeaderText = "Диагноз",
                CellTemplate = new DataGridViewTextBoxCell()
            };

            userResultDataGridView.Columns.Add(column1);
            userResultDataGridView.Columns.Add(column2);
            userResultDataGridView.Columns.Add(column3);

            var userResults = UsersResultStorage.Get();
            
            foreach (var userResult in userResults)
            {
                userResultDataGridView.Rows.Add(userResult.NameUser, Convert.ToString(userResult.CountRightAnswer), userResult.Diagnos);
            }
        }

        private void backMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
