using System;

namespace ObServerDesingPattern2
{
    public class Student : IObserver
    {
        private readonly string name;
        public Student(string Name) => this.name = Name;
        public void Update(string message) => Console.WriteLine($"{name} Student of notified: {message}");
    }
}
