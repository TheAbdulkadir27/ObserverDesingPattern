using System.Collections.Generic;

namespace ObServerDesingPattern2
{
    public class ClassRoom
    {
        private ICollection<IObserver> Students = new HashSet<IObserver>();
        private string teacherStatus;
        public void AddStudent(IObserver student) => Students.Add(student);
        public void RemoveStudent(IObserver student) => Students.Remove(student);
        public void Notify(string message)
        {
            foreach (var item in Students)
            {
                item.Update(message);
            }
        }
        public void TeacherEnters()
        {
            teacherStatus = "Teacher Entered the ClassRoom";
            Notify(teacherStatus);
        }
        public void TeacherLeaves()
        {
            teacherStatus = "Teacher Left the ClassRoom";
            Notify(teacherStatus);
        }
    }
}
