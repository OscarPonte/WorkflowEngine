using System;

namespace WorkflowEngine
{
    public class UploadVideoToCloud : ITasks
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded to a cloud storage!");
        }
    }
}