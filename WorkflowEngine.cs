using System;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var task in workflow.GeTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
        }
    }
}