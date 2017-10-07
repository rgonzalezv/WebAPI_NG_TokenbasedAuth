using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_NG_TokenbasedAuth.Models;

namespace WebAPI_NG_TokenbasedAuth.Controllers
{
    [Authorize]
    [RoutePrefix("api/Employee")]
    public class EmployeeApiController : ApiController
    {
        public List<EmployeeModel.Employee> Get()
        {
            return new EmployeeModel.EmployeeDatabase();
        }
    }
}