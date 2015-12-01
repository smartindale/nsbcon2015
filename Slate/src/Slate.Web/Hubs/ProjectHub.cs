using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace Slate.Web.Hubs
{
    public class ProjectHub : Hub
    {
        public Task SubscribeToProject(int projectId)
        {
            return Groups.Add(Context.ConnectionId, GroupNames.Project(projectId));
        }

        public override Task OnConnected()
        {
            //TODO: check the db and add to the correct projects
            return SubscribeToProject(1);
            return base.OnConnected();
        }
    }
}