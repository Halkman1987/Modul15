using System;
using System.Collections;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace DeBugWorkOnlyNoutbook
{

    class Program
    {
        static string[] GetAllStudents(Classroom[] classes)
        {
            var UnSt = (from st in classes
                        from s in st.Students
                        select s).ToArray();

            return UnSt;
        }
        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);
            Console.WriteLine(string.Join(" ", allStudents));
        }
    }
}
