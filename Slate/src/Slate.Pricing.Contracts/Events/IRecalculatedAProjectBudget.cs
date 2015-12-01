using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slate.Pricing.Contracts.Events
{
    public interface IRecalculatedAProjectBudget
    {
        int ProjectId { get; set; }

        decimal HighCost { get; set; }

        decimal LowCost { get; set; }
    }
}
