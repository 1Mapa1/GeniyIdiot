using System;
using System.Timers;
using GeniyIdiotClassLibrary;

namespace GeniyIdiotConsoleApp
{
    public class Program
    {
        private static int ticks = 1;
        private static Timer timer;
        private static int userAnswer;
        static void Main(string[] args)
        {
            var random = new Random();

            Console.WriteLine("На ответ будет всего 10 секунд");

            Console.Write("Введите свое имя: ");
            string nameUser = GetUserName();

            while (true)
            {
                var questions = QuestionsStorage.GetQuestions();
                int countQuestions = questions.Count;

                int countRightAnswers = 0;

                for (int i = 0; questions.Count > 0; i++)
                {
                    timer = new Timer(1000);
                    timer.Elapsed += timerElapsed;
                    timer.Start();
                    Console.WriteLine("Вопрос № " + (i + 1));

                    int randomIndex = random.Next(0, questions.Count);

                    Console.WriteLine(questions[randomIndex].Text);
                    
                    userAnswer = GetUserAnswer();
                    
                    if(ticks == 10)
                    {
                        Console.WriteLine("Ответ не защитан, так как не успели ответить за 10 секунд.");
                        userAnswer = -1;
                    }

                    if (userAnswer == questions[randomIndex].Answer)
                    {
                        countRightAnswers++;
                    }

                    questions.RemoveAt(randomIndex);
                    timer.Stop();
                    ticks = 1;
                }

                Console.WriteLine("Количество правильных ответов: " + countRightAnswers);
                Console.WriteLine($"{nameUser}, Ваш деагноз: " + DiagnoseColection.GetFinalDiagnoses(countQuestions, countRightAnswers));

                var user = new User(nameUser, countRightAnswers, DiagnoseColection.GetFinalDiagnoses(countQuestions, countRightAnswers));

                UsersResultStorage.Append(user);

                Console.WriteLine("Хотите просмотреть результаты тестов? (Да/Нет)");

                if (GetUserShoice())
                {
                    ShowUserResults();
                }

                Console.WriteLine("Хотите добавить вопрос? (Да/Нет)");

                if (GetUserShoice())
                {
                    ShowQuestion();
                    AddQuestion();
                }

                Console.WriteLine("Хотите удалить вопрос? (Да/Нет)");

                if (GetUserShoice())
                {
                    ShowQuestion();
                    RemoveQuestion();
                }

                Console.WriteLine("Хотите пройти тест ёще раз? (Да/Нет)");

                if (GetUserShoice())
                {
                    Console.WriteLine("Повторное прохождение теста.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Завершение теста.");
                    break;
                }
            }
        }

        private static void timerElapsed(object sender, ElapsedEventArgs e)
        {
            if(ticks == 10)
            {
                Console.WriteLine("10.");
                timer.Stop();
                return;
            }
            Console.Write(ticks + ". ");
            ticks++;
        }

        private static void ShowUserResults()
        {
            Console.WriteLine("|| {0,-15} || {1,-20} || {2,-15} ||", "Имя:", "Количество баллов:", "Диагноз:");

            var userResults = UsersResultStorage.Get();

            for (int i = 0; i < userResults.Count; i++)
            {
                Console.WriteLine("|| {0,-15} || {1,20} || {2,16} ||", userResults[i].NameUser, userResults[i].CountRightAnswer, userResults[i].Diagnos);
            }
        }

        private static void ShowQuestion()
        {
            Console.WriteLine("№ {0,-76} || {1,-20}  ", " Вопрос:", "Ответ:");
            var questionsStorage = QuestionsStorage.GetQuestions();

            for (int i = 0; i < questionsStorage.Count; i++)
            {
                Console.WriteLine((i + 1) + "." + " {0,-75} || {1,-20} ", questionsStorage[i].Text, questionsStorage[i].Answer);
            }
            Console.WriteLine();
        }

        static void RemoveQuestion()
        {
            var questions = QuestionsStorage.GetQuestions();
            Console.WriteLine("Введите номер удаляемого вопроса");

            var removeQuestionNumber = GetUserAnswer();
            while (removeQuestionNumber > questions.Count || removeQuestionNumber == 0)
            {
                if (removeQuestionNumber > questions.Count)
                {
                    Console.WriteLine("Введите число не прывышающее " + questions.Count);
                    removeQuestionNumber = GetUserAnswer();
                }
                if (removeQuestionNumber == 0)
                {
                    Console.WriteLine("Введите число больше 0");
                    removeQuestionNumber = GetUserAnswer();
                }
            }


            QuestionsStorage.Remove(removeQuestionNumber - 1);

        }

        private static void AddQuestion()
        {
            Console.Write("Введите вопрос: ");
            string text = GetQuestion();
            Console.Write("Введите ответ на вопрос: ");
            int answer = GetUserAnswer();

            var question = new Question(text, answer);

            QuestionsStorage.Append(question);
        }

        private static string GetQuestion()
        {
            while (true)
            {
                string question = "";
                try
                {
                    question = Console.ReadLine();
                }
                catch (Exception) { Console.WriteLine("Введите корректный вопрос."); }

                int questionMark = 0;

                int countLattice = 0;

                for (int i = 0; i < question.Length; i++)
                {
                    if (question[i] == '#')
                    {
                        countLattice++;
                    }
                    if (question[i] == '?')
                    {
                        questionMark++;
                    }
                }

                if (questionMark != 1)
                {
                    Console.WriteLine("Введите вопрос с одним вопросительным знаком.");
                    continue;
                }
                if (countLattice != 0)
                {
                    Console.WriteLine("Введите без #.");
                }
                else
                {
                    return question;
                }
            }
        }

        static string GetUserName()
        {
            while (true)
            {
                string userName = Console.ReadLine();

                if (userName == "")
                {
                    Console.WriteLine("Вы забыли ввести имя!");
                    continue;
                }

                int controlWhile = 0;

                for (int i = 0; i < userName.Length; i++)
                {
                    if (userName[i] == '#')
                    {
                        Console.WriteLine("Введите без #.");
                        controlWhile++;
                        break;
                    }
                }

                if (controlWhile == 0)
                {
                    return userName;
                }

            }
        }

        static int GetUserAnswer()
        {
            while (ticks != 10)
            {
                int userAnswer;
                try { userAnswer = Convert.ToInt32(Console.ReadLine()); }
                catch (FormatException) { Console.WriteLine("Пожалуйста, введите число!"); continue; }
                catch (OverflowException) { Console.WriteLine("Ввидите число не превышающее 10000000000."); continue; }
                if (userAnswer < 0)
                {
                    Console.WriteLine("Введите не отрицательное число");
                    continue;
                }
                return userAnswer;

            }
            return -1;
        }

        static bool GetUserShoice()
        {
            string corectAnswerUser;

            while (true)
            {
                string answerUser = Console.ReadLine().ToLower();

                if (answerUser == "да" || answerUser == "нет")
                {
                    corectAnswerUser = answerUser;
                    break;
                }
                else
                {
                    Console.WriteLine("Введите коректный ответ.");
                }
            }

            if (corectAnswerUser == "нет")
            {
                return false;
            }
            return true;
        }
    }
}
