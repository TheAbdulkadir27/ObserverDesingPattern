using System.ComponentModel;

namespace ObServerDesingPattern5
{
    public class DataModel : INotifyPropertyChanged
    {
        private string data;
        public string Data
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged(nameof(Data));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
