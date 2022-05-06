
namespace Currency
{
    using System.Collections;
    using System.Collections.Generic;

    class CurrencyList : IEnumerable<Currency>
    {
        private List<Currency> list = new();

        public static CurrencyList operator +(CurrencyList List, Currency item)
        {
            List.list.Add(item);
            return List;
        }

        public static CurrencyList operator -(CurrencyList List, Currency item)
        {
            List.list.Remove(item);
            return List;
        }

        public void AddItem(Currency item)
        {
            this.list.Add(item);
        }

        public void RemoveItem(Currency item)
        {
            this.list.Remove(item);
        }

        public void Sort()
        {
            this.list.Sort();
        }

        public void Clear()
        {
            foreach (Currency currency in this.list)
            {
                this.RemoveItem(currency);
            }
        }

        public IEnumerator<Currency> GetEnumerator()
        {
            foreach (var item in this.list)
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
