using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVjezbe2.Models
{
    public static class Repozitorij
    {
        static List<Student> students = new List<Student>();

        public static void DodajStudenta(Student student)
        {
            students.Add(student);
        }

        public static List<Student> GetStudente()
        {
            return students;
        }
    }
}
