using System;

namespace WorkflowEngine
{
    public class CallWebService : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("Calling the web service...");
        }
    }
}