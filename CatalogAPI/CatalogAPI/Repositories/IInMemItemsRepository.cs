using CatalogAPI.Entities;
using System;
using System.Collections.Generic;

namespace CatalogAPI.Repositories
{
    public interface IInMemItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);

    }
}