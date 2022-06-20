using System;

namespace powtorka
{
    public class PriorityTask : ITask
    {
        public string Name { get; set; }

        public int Priority { get; set; }

        public PriorityTask()
        {
        }

        public PriorityTask(string name, int priority)
        {
            Console.WriteLine($"WYKONUJE SIĘ KONSTRUKTOR bazowy {nameof(PriorityTask)}");
            Name = name;
            Priority = priority;
        }

        public PriorityTask(PriorityTask priorityTask)
        {
            Name = priorityTask.Name;
            Priority = priorityTask.Priority;
        }
        public override string ToString()
        {
            return $"{{Name: {Name}; Priority: {Priority}}}";

        }
    }
}