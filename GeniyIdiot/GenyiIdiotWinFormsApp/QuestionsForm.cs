using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeniyIdiotClassLibrary;

namespace GenyiIdiotWinFormsApp
{
    public partial class QuestionsForm : Form
    {
        private List<Question> questions;
        private Question correntQuestion;
        private int countQuestions;
        private int questionNumber;
        private User user = new User("Неизвестно");
        public static string Diagnos;
        public static int CountRightAnswers;
        private int ticks = 10;
        
        public QuestionsForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = QuestionsStorage.GetQuestions();
            countQuestions = questions.Count;
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var random = new Random();

            var indexQuestion = random.Next(0, questions.Count);

            correntQuestion = questions[indexQuestion];

            questionTextLabel.Text = correntQuestion.Text;

            questionNumber++;
            questionNumberLabel.Text = "Вопрос № " + questionNumber;
            
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var answerUser = userAnswerTextBox.Text;

            if (ticks == 0 || ChackUserAnswer(answerUser))
            {
                userAnswerTextBox.Clear();
                var rightAnswer = correntQuestion.Answer;

                try
                {
                    Convert.ToInt32(answerUser);
                }
                catch
                {
                    answerUser = Convert.ToString(-1);
                }

                if (Convert.ToInt32(answerUser) == rightAnswer)
                {
                    user.AcceptRightAnswer();
                }

                questions.Remove(correntQuestion);

                ticks = 11;

                if(EndGame())
                {
                    return;
                }

                ShowNextQuestion();
            }
        }

        public static bool ChackUserAnswer(string answerUser)
        {
            int userAnswer;
            try 
            { 
                userAnswer = Convert.ToInt32(answerUser); 
            }
            catch (FormatException) 
            { 
                MessageBox.Show("Пожалуйста, введите число!"); 
                return false; 
            }
            catch (OverflowException) 
            { 
                MessageBox.Show("Ввидите число не превышающее 10000000000."); 
                return false; 
            }
            if (userAnswer < 0)
            {
                MessageBox.Show("Введите не отрицательное число");
                return false;
            }

            return true;
        }

        private void QuestionsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                nextButton.PerformClick();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ticks--;
            timerLabel.Text = ticks.ToString();

            if(ticks == 0)
            {
                nextButton.PerformClick();
            }
        }

        private bool EndGame()
        {
            var endGame = questions.Count == 0;

            if (endGame)
            {
                CountRightAnswers = user.CountRightAnswer;
                Diagnos = DiagnoseColection.GetFinalDiagnoses(countQuestions, user.CountRightAnswer);
                this.Close();
                var menuForm = new MenuForm();
                menuForm.Show();
                return true;
            }
            return false;
        }
    }
}
