using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    public class VideoUpload : IActivities
    {
        public void Execute(Command command)
        {
            Console.WriteLine("Video has been uploaded to the service.");
        }
    }
}
