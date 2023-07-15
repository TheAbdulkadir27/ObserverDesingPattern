using System;

namespace ObserverDesingPattern4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student() { Name = "Abdulkadir"};

            var teacher1 = new Teacher("Furkan Hoca");
            var teacher2 = new Teacher("Aygül Hoca");
            var teacher3 = new Teacher("Yusuf Hoca");
            var teacher4 = new Teacher("Ömer Hoca");

            // Öğrenciye gözlemcileri ekleme
            student.AddTeacher(teacher1);
            student.AddTeacher(teacher2);
            student.AddTeacher(teacher3);
            student.AddTeacher(teacher4);

            // Öğrenci notunu güncelleme (diğer gözlemciler otomatik olarak haberdar olacak)
            student.Grade = 80;

            // Bir gözlemciyi öğrenciden çıkarma
            student.RemoveTeacher(teacher4);

            student.Grade = 90;

            Console.ReadKey();
        }
    }
}
