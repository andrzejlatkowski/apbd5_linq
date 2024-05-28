using System;
using System.Collections.Generic;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = LinqTasks.Task1();
            foreach (var VARIABLE in res)
            {
                Console.WriteLine(VARIABLE);
            }
            // Console.WriteLine(LinqTasks.Task9());
            
            int[] numbers = new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            int oddNumber = LinqTasks.Task13(numbers);
            // Console.WriteLine(oddNumber);
        }
    }
}
