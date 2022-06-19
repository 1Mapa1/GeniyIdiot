using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniyIdiotClassLibrary
{
    public class QuestionsStorage
    {
        static readonly string fileName = "questions.json";
        public static List<Question> GetQuestions()
        {
            var questions = new List<Question>();

            if (FileWork.Exists(fileName))
            {
                var value = FileWork.GetData(fileName);

                questions = JsonConvert.DeserializeObject<List<Question>>(value);

                return questions;
            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умножить на два?", 6));
                questions.Add(new Question("Бревно нужно распелить на 10 частей, сколько надо сделать распилов?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60));
                questions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));

                Save(questions);
            }

            return questions;
        }

        private static void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileWork.Replace(jsonData, fileName);
        }

        public static void Append(Question question)
        {
            var questins = GetQuestions();

            questins.Add(question);

            Save(questins);
        }


        public static void Remove(int removeIndex)
        {
            var questions = GetQuestions();
            questions.RemoveAt(removeIndex);

            FileWork.Clear(fileName);

            Save(questions);
        }
    }
}
