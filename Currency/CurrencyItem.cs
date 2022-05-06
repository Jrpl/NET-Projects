
namespace Currency
{
    using System;

    public record Currency : IComparable<Currency>
    {
        public string Name { get; init; }
        public decimal Rate { get; init; }

        public int CompareTo(Currency currency) =>
            this.Rate.CompareTo(currency.Rate);
    }

    public record Amount : Currency
    {
        public decimal Value { get; init; }
    }
}
