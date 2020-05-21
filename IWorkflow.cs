using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void Add(ITasks tasks);
        void Remove(ITasks tasks);
        IEnumerable<ITasks> GeTasks();
    }
}