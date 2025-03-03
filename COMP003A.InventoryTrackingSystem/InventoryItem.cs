// Author: [Alvaro Pulido]
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Simple Inventory Tracking System in C#

namespace COMP003A.InventoryTrackingSystem
{
    /// <summary>
    /// represents inventory items based off name, id, and quantity
    /// </summary>
    public class InventoryItem
    {
        /// <summary>
        /// Calls for the Id of the item
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Calls for the name of the item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Calls for the quantity of the item
        /// </summary>
        public int Quantity { get; set; }
    }

     
}
