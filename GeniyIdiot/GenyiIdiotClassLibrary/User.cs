namespace GeniyIdiotClassLibrary
{
    public class User
    {
        public string NameUser;

        public int CountRightAnswer;

        public string Diagnos;

        public User(string nameUser)
        {
            NameUser = nameUser;
            Diagnos = "Неизвестно";
        }
        public User()
        { }

        public User(string nameUser, int countRightAnswer, string diagnos)
        {
            NameUser = nameUser;
            CountRightAnswer = countRightAnswer;
            Diagnos = diagnos;
        }

        public void AcceptRightAnswer()
        {
            CountRightAnswer++;
        }
    }
}
