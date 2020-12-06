using System.Collections.Generic;

namespace command
{
    public class TaskQueue
    {
        public IList<ICommand> Queue = new List<ICommand>();

        public void Add(ICommand command)
        {
            Queue.Add(command);
        }

        public void Process()
        {
            foreach (var command in Queue)
            {
                command.Execute();
            }

        }
    }
}