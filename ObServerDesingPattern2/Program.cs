using System;
using System.Runtime.InteropServices;

namespace ObServerDesingPattern2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ClassRoom = new ClassRoom();
            var Student1 = new Student("Abdulkadir");
            var Student2 = new Student("Ömer");
            var Student3 = new Student("Kerim");
            ClassRoom.AddStudent(Student1);
            ClassRoom.AddStudent(Student2);
            ClassRoom.AddStudent(Student3);

            ClassRoom.TeacherEnters();

           
            ClassRoom.RemoveStudent(Student3);

            //3 Öğrenci Yani kerim'e Öğretmenin Sınıftan Çıktığı hakkında Bilgi Gitmeyecek! 2 Kişi Haber Alabilicek
            ClassRoom.TeacherLeaves();

            Console.ReadLine();
        }
    }
}
