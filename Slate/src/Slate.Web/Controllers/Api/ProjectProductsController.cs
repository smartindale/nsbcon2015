using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Infrastructure;
using Slate.Projects.Contracts.Commands;
using Slate.Web.App_Start;
using Slate.Web.Hubs;

namespace Slate.Web.Controllers.Api
{
    public class ProjectProductsController : ApiController
    {
        public ProjectProductsController()
        {
            
        }

        public IHttpActionResult Get()
        {
            return Ok();
        }

        public IHttpActionResult Put()
        {
            return Ok();
        }

        public IHttpActionResult Post([FromBody]AddProductToProject message)
        {
            NServiceBusConfig.Bus.Send(message);
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
