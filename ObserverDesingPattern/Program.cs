using System;
using System.Data.Common;

namespace ObserverDesingPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var Kullanıcı1 = new ObServer("Kullanıcı 1");
            var Kullanıcı2 = new ObServer("kullanıcı 2");
            var Kullanıcı3 = new ObServer("Kullanıcı 3");

            // Kullanıcıları konuya ekleyelim
            subject.Add(Kullanıcı1);
            subject.Add(Kullanıcı2);
            subject.Add(Kullanıcı3);

            // Konuya bir mesaj atayalım (Kullanıcılar otomatik olarak bilgilendirilecek)
            subject.SetMessage("Merhaba kullanıcılar");

            // Bir Kullanıcıyı konudan çıkaralım
            subject.Remove(Kullanıcı2);

            // Yeni bir mesaj atayalım (Kullanıcılardan biri bu mesajı almayacak)
            subject.SetMessage("kullanıcı 2 Çıkarıldı");

            Console.ReadKey();
        }
    }
}
