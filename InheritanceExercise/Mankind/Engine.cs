using System;
using System.Collections.Generic;
using System.Text;

namespace Mankind
{
    public class Engine
    {

        public void Run()
        {
            try
            {
                string[] studentInfo = Console.ReadLine().Split();
                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                string[] work = Console.ReadLine().Split();
                Worker worker = new Worker(work[0], work[1], double.Parse(work[2]), int.Parse(work[3]));
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
