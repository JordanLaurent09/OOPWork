using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager
{
    abstract class TaskBase:ITask
    {
        public abstract int TaskId { get; set; }
        public abstract string Title { get; set; }
        public abstract string Description { get; set; }
        public abstract Status Status { get; set; }

        public abstract Priority Priority { get; set; }

        public abstract DateTime Deadline { get; set; }

        public abstract User AssignedTo { get; set; }


        public abstract void Assign(User user);
        public abstract void ChangeStatus(Status status);
    }
}
