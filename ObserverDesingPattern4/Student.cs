using System.Collections.Generic;

namespace ObserverDesingPattern4
{
    public class Student
    {
        private List<IObServer> Teachers = new List<IObServer>();
        private int grade;
        public string Name { get; set; }
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
                Notify();
            }
        }
        public void AddTeacher(IObServer teacher) => Teachers.Add(teacher);
        public void RemoveTeacher(IObServer Teacher) => Teachers.Remove(Teacher);

        public void Notify()
        {
            foreach (var item in Teachers)
            {
                item.Update(this);
            }
        }
    }
}
