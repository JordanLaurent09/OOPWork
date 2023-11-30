using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    interface IReportable
    {
        void GenerateTaskReport(Task task);
        
        void GenerateProjectReport(Project project);
    }
}
