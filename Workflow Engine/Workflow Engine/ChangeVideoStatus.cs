using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    public class ChangeVideoStatus : IActivities
    {
        public void Execute(Command command)
        {
            Console.WriteLine("Changed the video status in the DB to 'Processing'.");
        }
    }
}
