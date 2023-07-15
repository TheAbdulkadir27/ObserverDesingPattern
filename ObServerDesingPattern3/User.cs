using System;

namespace ObServerDesingPattern3
{
    public class User : IObServer
    {
        private string Name;
        public User(string name) => Name = name;
        public void Update(double ExChange) => Console.WriteLine($"{Name} is notified: exchange rate is down. Current Rate: {ExChange}");
    }
}
