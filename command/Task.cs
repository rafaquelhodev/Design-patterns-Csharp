using System;

namespace command
{
    public class Task
    {
        public string Name { get; set; }
        public Status Status { get; set; }
        public DateTime FinalizationDate { get; set; }

        public Task(string name)
        {
            Name = name;
            Status = Status.New;
        }

        public void Initialize()
        {
            Status = Status.Started;
        }

        public void Stop()
        {
            Status = Status.Stopped;
            FinalizationDate = DateTime.Now;
        }

    }
}