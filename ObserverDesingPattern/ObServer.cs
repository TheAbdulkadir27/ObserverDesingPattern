using System;


namespace ObserverDesingPattern
{
    public class ObServer : IOBServer
    {
        private readonly string name;
        public ObServer(string Name) => this.name = Name;
        public void Update(string message) => Console.WriteLine($"{name} isimli Kullanıcı Bildirim Aldı {message}");
    }
}
