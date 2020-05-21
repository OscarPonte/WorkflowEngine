using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<ITasks> _tasks = new List<ITasks>();
        public void Add(ITasks tasks)
        {
            _tasks.Add(tasks);
        }

        public void Remove(ITasks tasks)
        {
            _tasks.Remove(tasks);
        }

        public IEnumerable<ITasks> GeTasks()
        {
            return _tasks;
        }
    }
}