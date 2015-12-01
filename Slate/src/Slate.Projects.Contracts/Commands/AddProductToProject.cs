using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slate.Projects.Contracts.Commands
{
    public class AddProductToProject
    {
        public int ProductId { get; set; }

        public int ProjectId { get; set; }

        public decimal X { get; set; }

        public decimal Y { get; set; }
    }
}
