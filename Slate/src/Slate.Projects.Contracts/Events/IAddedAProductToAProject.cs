using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slate.Projects.Contracts.Events
{
    public interface IAddedAProductToAProject
    {
        int ProjectId { get; set; }

        int ProductId { get; set; }

        decimal X { get; set; }

        decimal Y { get; set; }


    }
}
