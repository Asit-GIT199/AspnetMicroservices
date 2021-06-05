﻿using Ordering.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        // This is only Abstraction, the implementation is there in the Infrastructure layer
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
