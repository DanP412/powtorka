using System;

namespace powtorka
{
    public class DescribedTask : PriorityTask
    {
        public string Descrption { get; set; }

        public DescribedTask() : base()
        {
        }

        public DescribedTask(string name, int priority, string description) : base(name, priority)
        {
            Console.WriteLine($"WYKONUJE SIĘ KONSTRUKTOR pochodny {nameof(DescribedTask)}");
            Descrption = description;
        }

        public DescribedTask(DescribedTask describedTask) : base()
        {
            Name = describedTask.Name;
            Priority = describedTask.Priority;
            Descrption = $"kopia - {describedTask.Descrption}";
        }

        public override string ToString()
        {
            return $"{{Name: {Name}; Priority: {Priority}; Description: {Descrption}}}";
        }
    }
}
