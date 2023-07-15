using System;

namespace ObserverDesingPattern4
{
    public class Teacher : IObServer
    {
        private string Name;
        public Teacher(string name) => Name = name;

        public void Update(Student Students)
        {
           Console.WriteLine($"{Name} is notified: Student {Students.Name}'s grade is updated: {Students.Grade}");
        }
    }
}
