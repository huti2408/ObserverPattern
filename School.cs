namespace ObserverPattern
{
    internal class School
    {
        IList<Student> students = new List<Student>();
        public void ReleaseDayOff()
        {
            Console.WriteLine("Student will have a day off bcuz Viet Nam Independent Day");
            Notify();
        }
        public void ReleaseExam()
        {
            Console.WriteLine("Prepair to do your exam");
            NotifyExam();
        }
        private void NotifyExam()
        {
            foreach (var b in students)
            {
                b.DoFinalExem();
            }
        }
        private void Notify()
        {
            foreach (var b in students)
            {
                b.GoToSchool(false);
            }
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
