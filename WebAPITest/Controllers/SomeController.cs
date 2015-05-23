using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITest.Controllers
{
    public class SomeController : ApiController
    {
        public SomeController(IMySvcRepository r)
        {
        }
    }
}
