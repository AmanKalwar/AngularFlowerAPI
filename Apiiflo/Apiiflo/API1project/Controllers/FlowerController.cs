using API1project.Models;
using API1project.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API1project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [EnableCors("MyPolicy")]
   
    public class FlowerController : ControllerBase
    {
        private readonly FlowerService _service;

        public FlowerController(FlowerService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<Flower> Get()
        {
            if (_service.GetAll() != null)
            {

                return _service.GetAll();
            }

            return null;
        }
        [HttpPost]
        public async Task<ActionResult<Flower>> Post([FromBody] Flower order)
        {
            Flower orders = _service.Add(order);
            if (orders != null)
            {
                return orders;
            }
            return BadRequest("Couldnt Add");
        }

     

    }
}
