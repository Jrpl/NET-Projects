
namespace Inventory
{
    using System;
    using System.Text;

    public record Item : IComparable<Item>
    {
        public int Number { get; init; }
        public string Description { get; init; }
        public string Dynamic { get; set; }
        public decimal Price { get; init; }
        public virtual string FileFormat => $"{this.Number}|{this.Description}|{this.Price}";

        public int CompareTo(Item item) =>
            this.Description.CompareTo(item.Description);

        public virtual string DisplayItem()
        {
            var builder = new StringBuilder();
            builder.Append($"{this.Number} ");
            builder.Append($"{this.Dynamic} ");
            builder.Append($"{this.Description} ");
            builder.Append($"(${this.Price})");

            return builder.ToString();
        }

        public static Item Parse(string formatString)
        {
            var tokens = formatString.Split("|");

            return new Item()
            {
                Number = int.Parse(tokens[0]),
                Description = tokens[1],
                Dynamic = tokens[2],
                Price = decimal.Parse(tokens[3])
            };
        }
    }

    public record Supply : Item
    {
        public string Manufacturer { get; init; }
        public override string FileFormat => $"{this.Number}|{this.Description}|{this.Manufacturer}|{this.Price}";
        public override string DisplayItem()
        {
            var builder = new StringBuilder();
            builder.Append($"{this.Number} ");
            builder.Append($"{this.Manufacturer} ");
            builder.Append($"{this.Description} ");
            builder.Append($"(${this.Price})");

            return builder.ToString();
        }
    }

    public record Plant : Item
    {
        public string Size { get; init; }
        public override string FileFormat => $"{this.Number}|{this.Description}|{this.Size}|{this.Price}";
        public override string DisplayItem()
        {
            var builder = new StringBuilder();
            builder.Append($"{this.Number} ");
            builder.Append($"{this.Size} ");
            builder.Append($"{this.Description} ");
            builder.Append($"(${this.Price})");

            return builder.ToString();
        }
    }
}
