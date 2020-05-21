using System;

namespace WorkflowEngine
{
    public class SendEmail : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }
}