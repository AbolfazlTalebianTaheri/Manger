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
            DialogResult result = AlertHelper.Question("آیا از حذف مطمئن هستید ؟");
            if(result ==DialogResult.OK)
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
    }
}
