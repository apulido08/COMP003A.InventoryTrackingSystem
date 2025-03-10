﻿// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Simple Inventory Tracking System in C#

namespace COMP003A.InventoryTrackingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();
            while (true)
            {
                Console.WriteLine("Inventory Menu: ");
                Console.WriteLine("1. Add Item.");
                Console.WriteLine("2. View Item");
                Console.WriteLine("3. Remove Item");
                Console.WriteLine("4. Update Item");
                Console.WriteLine("5. Exit");
                Console.Write("Select an Option: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter item name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter item quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    manager.AddItem(name, quantity);
                }
                else if (choice == "2")
                {
                    manager.ViewItems();
                }
                else if (choice == "3")
                {
                    Console.Write("Enter item id to remove: ");
                    int idToRemove = int.Parse(Console.ReadLine());
                    manager.RemoveItem(idToRemove);
                }
                else if (choice == "4")
                {
                    Console.Write("Enter item id to update: ");
                    int idToUpdate = int.Parse(Console.ReadLine());
                    Console.Write("Enter new item name: ");
                    string newName = Console.ReadLine();
                    int newQuantity = int.Parse(Console.ReadLine());
                    manager.AddItem(newName, newQuantity);
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again");
                }
            }

        }
    }
}
