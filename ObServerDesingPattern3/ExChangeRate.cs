using System.Collections.Generic;

namespace ObServerDesingPattern3
{
    public class ExChangeRate
    {
        private ICollection<IObServer> Users = new HashSet<IObServer>();
        private double rate;
        public void Attach(IObServer user) => Users.Add(user);
        public void Detach(IObServer user) => Users.Remove(user);
        public void Notify(double rate)
        {
            foreach (var item in Users)
            {
                item.Update(rate);
            }
        }
        public void SetExChangeRate(double rate)
        {
            if (rate > this.rate)
            {
                this.rate = rate;
                Notify(rate);
            }
        }
    }
}
