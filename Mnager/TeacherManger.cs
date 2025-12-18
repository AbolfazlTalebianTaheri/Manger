using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnager
{
    public class TeacherManger
    {
        private static List<Teacher> teachers;
        public TeacherManger()
        {
            if (teachers == null)
                teachers = new List<Teacher>();
        }
        public IReadOnlyList<Teacher> GetAll()
        {
            return teachers;
        }
        public void Remove(int Index)
        {
            teachers.RemoveAt(Index);
        }
        public void Add(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void Edit(string phonNumber, string nationalCode, Teacher teacher)
        {
            OpertianResualtTeacher opertianResualt = Duplicate(phonNumber, nationalCode);
            if (opertianResualt.Index != -1)
                teachers[opertianResualt.Index] = teacher;
        }
        public OpertianResualtTeacher Duplicate(string phonNumber, string nationalCode)
        {
            for (int i = 0; i < teachers.Count; i++)
                if (teachers[i].PhonNumber == phonNumber)
                    if (teachers[i].NationalCode == nationalCode)
                        return new OpertianResualtTeacher
                        {
                            IsSuccess = true,
                            Index = i
                        };
            return new OpertianResualtTeacher
            {
                IsSuccess = false,
                Index = -1
            };
        }
        public int Count()
        {
            return teachers.Count;
        }
    }
}
