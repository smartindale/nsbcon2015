using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Slate.Web.Controllers.Api
{
    public class ProjectBudgetController : ApiController
    {
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
            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            return BadRequest();
        }
    }
}
