using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperSuitShop.Core.ApplicationService;
using SuperSuitShop.Core.Entities;

namespace SuperSuitShop.RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperSuitController : ControllerBase
    {
        readonly ISuperSuitShopService _superSuitService;

        public SuperSuitController(ISuperSuitShopService superSuitService)
        {
            _superSuitService = superSuitService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<SuperSuit>> Get([FromQuery] Filter filter)
        {
            

            return Ok(_superSuitService.GetFilteredSuits(filter)); 
                
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<SuperSuit> Get(int id)
        {

            if (id < 1)
            {
                return BadRequest("Id must be greater than 0");
            }
            return _superSuitService.ReadById(id);

        }

        // POST api/values
        [HttpPost]
        public ActionResult<SuperSuit> Post([FromBody] SuperSuit superSuit)
        {
            return _superSuitService.CreateSuperSuit(superSuit);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<SuperSuit> Put(int id, [FromBody] SuperSuit superSuit)
        {
            superSuit.Id = id;
            if (id < 1)
            {
                return BadRequest("Id must be lager than zero!");
            }

            var success = _superSuitService.UpdateSuperSuit(superSuit);
            if (success != null)
            {
                return Ok(success);
            }
            else
            {
                return NotFound($"No Suit found with id {id}");
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<SuperSuit> Delete(int id)
        {
            var superSuit = _superSuitService.DeleteSuperSuit(id);
            if (superSuit == null)
            {
                return StatusCode(404, "Did not find SuperSuit with ID " + id);
            }

            return Ok($"SuperSuit with Id: {id} is Deleted");
        }
    }
}
