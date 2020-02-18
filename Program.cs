using System;
using System.Threading.Tasks;

namespace ContinuationTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task(()=>{
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });
            
            var task2 = task1.ContinueWith(Display);
 
            var task3 = task1.ContinueWith(t =>
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });
 
            var task4 = task2.ContinueWith(t =>
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });
 
            task1.Start();
             
            Console.ReadLine();
        }
        
        static void Display(Task t)
        {
            Console.WriteLine($"Id задачи: {Task.CurrentId}");
        }
    }
}