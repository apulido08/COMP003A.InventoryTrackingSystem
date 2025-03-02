// Author: [Alvaro Pulido]

namespace COMP003A.InventoryTrackingSystem
{
    public class InventoryManager
    {
        private List<InventoryItem> items = new List<InventoryItem>();
        private int nextId = 1;

      public void AddItem(string name, int quantity)
        {
            items.Add(new InventoryItem { Id = nextId++, Name = name });
    }
}
