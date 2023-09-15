using System;
namespace MyShop.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? Description { set; get; }
        public string? ImageUrl { get; set; }
        // navigation property
        public virtual List<OrderItem>? OrderItems { get; set; }
        
        
        /*Note: List<Order>? Orders is a navigation property in the Customer class. A navigation
           property in an entity class represents a relationship between entities and allows you to
           navigate from one entity to related entities.
           In this case, the Orders property is a navigation property that represents the relationship
           between a Customer and their associated Order entities. By having the Orders property in
           the Customer class, you can easily access all the orders that belong to a specific customer.
           Similarly, these navigation properties exist in Order (Customer, OrderItem),
           OrderItem(Item, Order), Item(OrderItem).*/
    }
}