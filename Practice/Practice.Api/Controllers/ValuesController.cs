using Microsoft.AspNetCore.Mvc;
using Practice.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public List<Person> Get()
        {
            using (DbContextOnConfiguringUseMySQL _coreDbContext = new DbContextOnConfiguringUseMySQL())
            {
                return _coreDbContext.Set<Person>().ToList();
            }
        }
       
　　 }
}
