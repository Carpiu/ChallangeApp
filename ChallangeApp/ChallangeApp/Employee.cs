
namespace ChallangeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string surname, int age, int score)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Score = score;

        }


        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Score { get; private set; }



        public int Resoult
        {
            get
            {
                return this.score.Sum();
            }

        }
        

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }
}
