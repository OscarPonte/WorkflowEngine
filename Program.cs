namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new CallWebService());
            workflow.Add(new ChangeStatusInDatabase());
            workflow.Add(new SendEmail());
            workflow.Add(new UploadVideoToCloud());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);

        }
    }
}
