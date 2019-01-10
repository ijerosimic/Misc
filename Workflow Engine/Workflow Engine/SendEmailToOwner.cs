using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    public class SendEmailToOwner : IActivities
    {
        public void Execute(Command command)
        {
            Console.WriteLine("Sending email to video owner.");
        }
    }
}
