using System.Collections.Generic;
using CMS.BL.Exceptions;

namespace CMS.BL
{
    public class InventoryRepository
    {
        public List<OrderItem> OrderItems { get; set; }

        public void LocateItem()
        {
        }

        public void CreateOrder(OrderItem itemToOrder)
        {
            if (!OrderItems.Contains(itemToOrder))
            {
                throw new ItemUnavailableException();
            }
        }
    }
}