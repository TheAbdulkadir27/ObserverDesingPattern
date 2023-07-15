using System.Collections.Generic;

namespace ObserverDesingPattern
{
    public class Subject
    {
        private ICollection<IOBServer> Observers = new HashSet<IOBServer>();
        private string message = string.Empty;
        public void Add(IOBServer observer) =>Observers.Add(observer);
        public void Remove(IOBServer observer) =>Observers.Remove(observer);
        public void Notify()
        { 
            foreach (var item in Observers)
                item.Update(message);
        }
        public void SetMessage(string Message)
        {
            this.message = Message;
            Notify();
        }
    }
}
