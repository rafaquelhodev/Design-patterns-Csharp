using System;

namespace command
{
    public class StopTask : ICommand
    {
        public Task Task { get; set; }

        public StopTask(Task task)
        {
            Task = task;
        }

        public void Execute()
        {
            Console.WriteLine($"Stopping task {Task.Name}");
            Task.Stop();
        }
    }
}