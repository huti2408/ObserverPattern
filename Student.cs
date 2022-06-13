namespace ObserverPattern
{
    internal class Student
    {
        public string name { get; set; }
        public Student(string name)
        {
            this.name = name;
        }
        public void GoToSchool(bool yes = true)
        {
            if (yes)
            {
                Console.WriteLine($"{name} will go to school");
            }
            else
            {
                Console.WriteLine($"{name} wont go to school");
            }
        }
        public void DoFinalExem()
        {
            Console.WriteLine($"{name} will do the final exam in next weekend");
        }
    }
}
