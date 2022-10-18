using Consultorio.Core.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Costumer>> Get()
        {
            return Ok(new List<Costumer>()
            {
                new Costumer{ 
                    Id=1,
                    Name="Ilola Nicolau João",
                    BirthDate=new DateTime(1999,03,11)
                },
                new Costumer{
                    Id=2,
                    Name="Josué Diogo Pedro",
                    BirthDate=new DateTime(2000,11,23)
                }
            });
        }
    }
}
