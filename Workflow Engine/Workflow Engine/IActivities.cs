﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow_Engine
{
    public interface IActivities
    {
        void Execute(Command command);
    }
}

