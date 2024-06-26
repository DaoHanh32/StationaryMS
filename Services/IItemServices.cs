﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using eProject.Models;
namespace eProject.Services
{
    public interface IItemServices
    {
        List<Item> GetItems();
        Item GetItem(string itemCode);
        Item CreateItem(Item newItem);
        bool UpdateItem(Item editItem);
    }
}
