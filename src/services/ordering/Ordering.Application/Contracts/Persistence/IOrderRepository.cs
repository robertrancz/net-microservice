﻿using Ordering.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Persistence
{
    public interface IOrderRepository : IRepositoryAsync<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
