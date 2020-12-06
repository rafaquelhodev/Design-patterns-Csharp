using System;

namespace command
{
    public class InitializeTask : ICommand
    {
        public Task Task { get; set; }

        public InitializeTask(Task task)
        {
            Task = task;
        }

        public void Execute()
        {
            Console.WriteLine($"Initializing task {Task.Name}");
            Task.Initialize();
        }
    }
}