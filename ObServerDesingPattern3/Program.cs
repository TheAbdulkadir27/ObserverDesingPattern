using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObServerDesingPattern3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exchangerate = new ExChangeRate();
            
            var user1 = new User("Kerim");
            var user2 = new User("Selim");
            User user3 = new User("Abdulkadir");

            // Kullanıcıları döviz kuruna ekleyelim
            exchangerate.Attach(user1);
            exchangerate.Attach(user2);
            exchangerate.Attach(user3);

            // Döviz kuru yükseldiğinde (bildirim gönderilicek)
            exchangerate.SetExChangeRate(9.2);

            //Döviz kuru yükseldiğinde (bildirim gönderilicek)
            exchangerate.SetExChangeRate(15.0);

            // Döviz kuru Düştüğünde (bildirim gönderilemeyecek)
            exchangerate.SetExChangeRate(7.2);

            Console.ReadKey();
        }
    }
}
