using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    public class WorkflowEngine
    {
        private readonly List<IActivities> _activities = new List<IActivities>();

        public WorkflowEngine()
        {
            _activities = new List<IActivities>();
        }

        public void Run()
        {
            foreach (var activity in _activities)
                activity.Execute(new Command());
        }

        public void ActivateActivity(IActivities activities)
        {
            _activities.Add(activities);
        }


    }
}
