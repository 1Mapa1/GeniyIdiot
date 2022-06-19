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
    public partial class MainForm : Form
    {
        public static string UserName = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            
            var nameUser = userNameTextBox.Text;

            if (CheckUserName(nameUser))
            {
                UserName = nameUser;

                this.Hide();
                var questionsForm = new QuestionsForm();
                questionsForm.Show();
            }
        }

        private bool CheckUserName(string nameUser)
        {
            if (nameUser == "")
            {
                MessageBox.Show("Вы забыли ввести имя.");
                return false;
            }

            return true;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter) 
            {
                startGameButton.PerformClick();
            }
        }
    }
}
