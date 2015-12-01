using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slate.Projects.Contracts.Events
{
    public interface IPublishedAProject
    {
        int ProjectId { get; set; }
        string VersionNumber { get; set; }
    }
}
