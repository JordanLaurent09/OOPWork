using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    interface ITask
    {
        void Assign(User user);
        void ChangeStatus(Status status);
    }
}
