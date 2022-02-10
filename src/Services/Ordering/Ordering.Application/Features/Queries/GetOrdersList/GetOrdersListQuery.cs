﻿using MediatR;
using Ordering.Application.Features.Queries.GetOrdersList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Queries
{
    public class GetOrdersListQuery: IRequest<List<OrdersVm>>
    {
        public string Username { get; set; }

        public GetOrdersListQuery(string username)
        {
            Username = username;
        }
    }
}
