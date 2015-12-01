using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slate.Web
{
    public static class GroupNames
    {
        public static string Project(int id)
        {
            return String.Format("Project_{0}_Users", id);
        }
    }
}