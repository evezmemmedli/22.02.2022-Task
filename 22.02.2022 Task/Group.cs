using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02._2022_Task
{
    public class Group
    {
        private static int _limit = 10;
        private int index = 0;
        public string No { get; set; }
        private Student[] Students;

        public Group()
        {
            Students = new Student[_limit];
        }

        public void AddStudent(Student student)
        {
            if (index >= _limit)
            {
                return;
            }
            Students[index] = student;
            index = ++index;
        }

        public Student[] GetStudents()
        {
            return Students;
        }

        public int GetStudentsCount()
        {
            return index;
        }
    }

}
