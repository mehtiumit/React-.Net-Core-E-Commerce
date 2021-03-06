﻿using ESShopReact.NetCore.Dtos.OrderDto;
using ESShopReact.NetCore.Dtos.Product;
using ESShopReact.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESShopReact.NetCore.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        //Task<ServiceResponse<List<OrderDetailDto>>> AddOrder(OrderDetailDto newOrder);
        //Task<ServiceResponse<OrderDetailDto>> GetOrderDetail(int orderId);
        //Task<ServiceResponse<List<OrderDetailDto>>> GetAllOrder();


        Task<ServiceResponse<GetOrderDto>> AddOrder(List<AddProductOrderDto> newOrders);
        Task<ServiceResponse<GetOrderDto>> GetOrderDetail(int orderId);
        Task<ServiceResponse<List<GetOrderDto>>> GetAllOrder();
    }
}
