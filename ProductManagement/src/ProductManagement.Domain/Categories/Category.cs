using System;
using Volo.Abp.Domain.Entities;

namespace ProductManagement.Categories
{
    public class Category :  AggregateRoot<Guid>
    {
        public string? Name { get; set; }
    }
}