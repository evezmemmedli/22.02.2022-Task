using System;

namespace _22._02._2022_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Student student = new Student();
            student.Name = "Avaz";
            student.Surname = "Memmedli";
            group.AddStudent(student);


            Student student2 = new Student();
            student2.Name = "Ruslan";
            student2.Surname = "Suleymanov";
            group.AddStudent(student2);


            var students = group.GetStudents();


            for (int i = 0; i < group.GetStudentsCount(); i++)
            {
                Console.WriteLine(students[i].Name + students[i].Surname);
            }
        }
    }
}
