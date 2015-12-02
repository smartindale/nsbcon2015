using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slate.Pricing.Endpoint.Domain
{
    public class ProjectBudgetRepository
    {
        private static Dictionary<int, ProjectBudget> _database = new Dictionary<int, ProjectBudget>(); 
        public ProjectBudget Get(int id)
        {
            if(!_database.ContainsKey(id))
                _database[id] = new ProjectBudget();
            return _database[id];
        }
    }
}
