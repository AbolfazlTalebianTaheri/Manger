using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnager
{
    public class StudentManager
    {
        private static List<Student> students;
        public StudentManager()
        {
            if (students == null)
                students = new List<Student>();
        }
        public IReadOnlyList<Student> GetAll()
        {
            return students;
        }
        public void Remove(int Index)
        {
            students.RemoveAt(Index);
        }
        public void Add(Student student)
        {
            students.Add(student);
        }
        public void Edit(Student student)
        {
            int index = students.IndexOf(student);
            students[index] = student;
        }
        public bool Duplicate(string firstName ,string lastName)
        {
            for (int i = 0; i < students.Count; i++)
                if (students[i].FirstName == firstName)
                    if (students[i].LastName == lastName)
                        return false;
            return true;
        }
        public int Count()
        {
            return students.Count;
        }
    }
}
