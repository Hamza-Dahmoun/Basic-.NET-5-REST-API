using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_5_REST_API.Entities;
using Net_5_REST_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net_5_REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemRepository repository;

        public ItemController()
        {
            repository = new ItemRepository();
        }

        //Item
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            return repository.GetItems();
        }

        //Item/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return item;
            }
        }
    }
}
