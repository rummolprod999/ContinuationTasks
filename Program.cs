using System;
using System.Threading.Tasks;

namespace ContinuationTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(()=>{
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });
            
            Task task2 = task1.ContinueWith(Display);
 
            Task task3 = task1.ContinueWith(t =>
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });
 
            Task task4 = task2.ContinueWith(t =>
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