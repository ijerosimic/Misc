using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();

            workflowEngine.ActivateActivity(new VideoUpload());
            workflowEngine.ActivateActivity(new CallWebService());
            workflowEngine.ActivateActivity(new SendEmailToOwner());
            workflowEngine.ActivateActivity(new ChangeVideoStatus());

            workflowEngine.Run();

        }
    }
}
