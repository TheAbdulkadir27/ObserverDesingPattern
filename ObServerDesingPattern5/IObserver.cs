using System.ComponentModel;

namespace ObServerDesingPattern5
{
    //Gözlemci AraBirimi
    public interface IObserver
    {
       void Update(object sender, PropertyChangedEventArgs e);
    }
}
