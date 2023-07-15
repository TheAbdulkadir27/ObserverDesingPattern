using System;
using System.ComponentModel;

namespace ObServerDesingPattern5
{
    public class ObServer : IObserver
    {
        private readonly string name;
        private readonly DataModel dataModel;
        public ObServer(string name, DataModel dataModel)
        {
            this.name = name;
            this.dataModel = dataModel;
        }
         public void Update(object sender, PropertyChangedEventArgs e) =>Console.WriteLine($"{name} is notified: Data changed - {dataModel.Data}");
        }
    }
