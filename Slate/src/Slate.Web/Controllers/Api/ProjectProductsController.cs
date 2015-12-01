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

        public IHttpActionResult Post()
        {
            NServiceBusConfig.Bus.Send<AddProductToProject>(m =>
            {
                m.ProductId = 1;
                m.ProjectId = 1;
                m.X = 123;
                m.Y = 155;
            });
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
