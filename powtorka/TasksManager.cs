using System;
using System.Collections.Generic;
using System.Text;

namespace powtorka
{
    public class TasksManager
    {
        private List<ITask> waitingTasks = new List<ITask>();
        private List<ITask> finishedTasks = new List<ITask>();

        public void AddTask(ITask task)
        {
            waitingTasks.Add(task);
        }

        // Ciekawostka (tak dużo dużo lepiej)
        public void FinishTask(ITask task)
        {
            waitingTasks.Remove(task);
        }

        public void FinishTask(int index)
        {
            var taskToFinish = waitingTasks[index];

          //  finishedTasks.RemoveAt(index);
            waitingTasks.Remove(taskToFinish);
            finishedTasks.Add(taskToFinish);

            Console.WriteLine($"Task finished: {taskToFinish.Name}");
        }

        public override string ToString()
        {
            // Alternatywnie
            //string data = string.Empty;
            //data += "\nadfdsf";
            //data += "\nadfdsf";
            //data += "\nadfdsf";

            var data = new StringBuilder();

            data.AppendLine("WAITING:");

            int taskNumber = 1;

            foreach (var task in waitingTasks)
            {
                string taskString = $"- {taskNumber}: {task}"; 
                data.AppendLine(taskString);

                taskNumber++;
            }

            data.AppendLine("FINISHED:");

            taskNumber = 1;

            foreach (var task in finishedTasks)
            {
                string taskString = $"- {taskNumber}: {task}";
                data.AppendLine(taskString);

                taskNumber++;
            }

            string dataString = data.ToString();

            return dataString;
        }
    }
}
