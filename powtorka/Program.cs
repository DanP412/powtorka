using System;
using System.Collections.Generic;

namespace powtorka
{
    class Program
    {
        static void Main(string[] args)
        {
            //ITask x = new DescribedTask("a", 2, "b");
            //Console.WriteLine(x);

            TasksManager tasksManager = new TasksManager();

            tasksManager.AddTask(new PriorityTask("Task 3", 1));
            tasksManager.AddTask(new PriorityTask("Task 1", 1));
            tasksManager.AddTask(new PriorityTask("Task 2", 1));
            tasksManager.AddTask(new PriorityTask("Task 4", 1));
            tasksManager.AddTask(new PriorityTask("Task 5", 1));
            tasksManager.AddTask(new DescribedTask("Task 2", 2, "Description 2"));
            tasksManager.AddTask(new DescribedTask("Task 1", 2, "Description 1"));

            Console.WriteLine(tasksManager);

            Console.WriteLine("-----------------------------------");

            tasksManager.FinishTask(1);
            tasksManager.FinishTask(0);

            Console.WriteLine(tasksManager);

            Console.ReadKey();

            //List<ITask> tasks = new List<ITask>();

            //ITask task1 = new PriorityTask();
            //ITask task2 = new DescribedTask();

            //tasks.Add(task1);
            //tasks.Add(task2);
            //tasks.Add(new DescribedTask());

            //List<int> numbers = new List<int>();
            //int num = 10;
            //numbers.Add(num);
            //numbers.Add(22);
        }
    }
}
