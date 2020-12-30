﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Net_5_REST_API.DTO;
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
        private readonly IItemRepository repository;

        public ItemController(IItemRepository repository)
        {
            this.repository = repository;
        }

        //Item
        [HttpGet]
        public IEnumerable<ItemDTO> GetItems()
        {
            return repository.GetItems().Select(item => item.AsDTO());
        }

        //Item/{id}
        [HttpGet("{id}")]
        public ActionResult<ItemDTO> GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return item.AsDTO();
            }
        }
    }
}
