using System;

namespace WorkflowEngine
{
    public class ChangeStatusInDatabase : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("Status in the DataBase Updated to 'Processing'");
        }
    }
}