using Net_5_REST_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net_5_REST_API.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreationDate = DateTime.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreationDate = DateTime.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, CreationDate = DateTime.UtcNow },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid Id)
        {
            return items.Where(i => i.Id == Id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }
    }
}
