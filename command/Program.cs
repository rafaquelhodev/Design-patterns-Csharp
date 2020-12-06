using System;

namespace command
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskQueue = new TaskQueue();

            var task1 = new Task("task1");
            var task2 = new Task("task2");

            taskQueue.Add(new InitializeTask(task1));
            taskQueue.Add(new InitializeTask(task2));
            taskQueue.Add(new StopTask(task1));

            taskQueue.Process();

        }
    }
}
