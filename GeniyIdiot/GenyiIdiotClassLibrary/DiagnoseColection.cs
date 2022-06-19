namespace GeniyIdiotClassLibrary
{
    public class DiagnoseColection
    {
        private static string[] GetDiagnoses()
        {
            string[] diagnoses = new string[6];
            diagnoses[0] = "Идиот";
            diagnoses[1] = "кретин";
            diagnoses[2] = "Дурак";
            diagnoses[3] = "Нормальный";
            diagnoses[4] = "Умный";
            diagnoses[5] = "Гений";
            return diagnoses;
        }

        ///<summary>
        ///На основание количества вопросов расчитывает диагноз.
        ///На сколько число больше кратности 6, на столько оприделенный диагноз имеет больше баллов в своем дипозоне.
        ///Пример: Если 8 вопросв, то Идиот от 0 до 1, Кретин от 2 до 3, Дурак 4 и тд.
        ///</summary>
        public static string GetFinalDiagnoses(int countQuestions, int countRightAnswers)
        {
            var diagnoses = GetDiagnoses();

            int remainder = countQuestions % diagnoses.Length;

            var countScoreDiagnoses = new int[diagnoses.Length];
            countScoreDiagnoses[0] = countQuestions / diagnoses.Length;

            for (int i = 1; i < diagnoses.Length; i++)
            {
                if (remainder != 0)
                {
                    countScoreDiagnoses[i] = countQuestions / diagnoses.Length + 1 + countScoreDiagnoses[i - 1];
                    remainder--;
                }
                else
                {
                    countScoreDiagnoses[i] = countQuestions / diagnoses.Length + countScoreDiagnoses[i - 1];
                }
            }

            for (int i = 0; i < diagnoses.Length; i++)
            {
                if (countRightAnswers <= countScoreDiagnoses[i])
                { return diagnoses[i]; }
            }

            return "Возникла ошибка.";
        }
    }
}
