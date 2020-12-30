using Net_5_REST_API.Entities;
using System;
using System.Collections.Generic;

namespace Net_5_REST_API.Repositories
{
    public interface IItemRepository
    {
        Item GetItem(Guid Id);
        IEnumerable<Item> GetItems();
    }
}