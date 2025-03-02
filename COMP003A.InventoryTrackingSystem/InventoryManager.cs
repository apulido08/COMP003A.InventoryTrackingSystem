﻿// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: 

namespace COMP003A.InventoryTrackingSystem
{
    public class InventoryManager
    {
        private List<InventoryItem> items = new List<InventoryItem>();
        private int nextId = 1;

        public void AddItem(string name, int quantity)
        {
            items.Add(new InventoryItem { Id = nextId++, Name = name });
            Console.WriteLine("Item added successfully!.");
        }

        public void ViewItems()
        {
            Console.WriteLine("Inventory");
            foreach (InventoryItem item in items)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Quantity: {item.Quantity}");

            }

            

        }
        public void RemoveItem(int id)
        {
            InventoryItem item = items.Find(item => item.Id == id);
            if (items != null)
            {
                items.Remove(item);
                Console.WriteLine("Item removed successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        public void UpdateItem(int id, string name, int quantity)
        {
            InventoryItem item = items.Find(item => item.Id==id);
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
