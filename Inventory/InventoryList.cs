
namespace Inventory
{
    using System.Collections;
    using System.Collections.Generic;

    class InventoryList : IEnumerable<Item>
    {
        private List<Item> inventory = new();

        public static InventoryList operator +(InventoryList Inventory, Item item)
        {
            Inventory.inventory.Add(item);
            return Inventory;
        }

        public static InventoryList operator -(InventoryList Inventory, Item item)
        {
            Inventory.inventory.Remove(item);
            return Inventory;
        }

        public void AddItem(Item item)
        {
            this.inventory.Add(item);
        }

        public void RemoveItem(Item item)
        {
            this.inventory.Remove(item);
        }

        public void Sort()
        {
            this.inventory.Sort();
        }

        public IEnumerator<Item> GetEnumerator()
        {
            foreach (var item in this.inventory)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
