// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Simple Inventory Tracking system in C#

namespace COMP003A.InventoryTrackingSystem
{
    /// <summary>
    /// Manages Inventory of items
    /// </summary>
    public class InventoryManager
    {
        /// <summary>
        /// The list of inventory items
        /// </summary>
        public List<InventoryItem> items = new List<InventoryItem>();
        /// <summary>
        /// next id available for item
        /// </summary>
        private int nextId = 1;

        /// <summary>
        /// Adds items to inventory
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="quantity">Quantity of item</param>
        public void AddItem(string name, int quantity)
        {
            items.Add(new InventoryItem { Id = nextId++, Name = name, Quantity = quantity });
        }

        /// <summary>
        /// displays the inventory list
        /// </summary>
        public void ViewItems()
        {
            Console.WriteLine("Inventory");
            foreach (InventoryItem item in items)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Quantity: {item.Quantity}");

            }



        }
        /// <summary>
        /// Removes inventory by ID it is given
        /// </summary>
        /// <param name="id">Id of item that is removed from inventory</param>
        public void RemoveItem(int id)
        {
            InventoryItem item = null;
            foreach (InventoryItem currentItem in items)
            {
                if (currentItem.Id == id)
                {
                    item = currentItem;
                    break;
                }
            }
            }

        /// <summary>
        /// updates name and quantity or items in inventory
        /// </summary>
        /// <param name="id">The id of the item</param>
        /// <param name="name">new name given to item</param>
        /// <param name="quantity">new quantity</param>
        public void UpdateItem(int id, string name, int quantity)
        {
            InventoryItem item = items.Find(item => item.Id == id);
            if (item != null)
            {
                item.Name = name;
                item.Quantity = quantity;
                Console.WriteLine("Item updated successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }
        
    }
}
