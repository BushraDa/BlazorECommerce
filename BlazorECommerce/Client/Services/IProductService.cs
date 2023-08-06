﻿using BlazorECommerce.Shared;

namespace BlazorECommerce.Client.Services
{
    public interface IProductService
    {
        public List<Product> Products { get; set; }
        public Task GetAll();
    }
}