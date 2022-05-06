
namespace Conversions
{
    using System;

    public class Conversion : IEquatable<Conversion>
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Multiplier { get; set; }
        public string FileFormat => $"{this.From}|{this.To}|{this.Multiplier}";

        public static Conversion Parse(string formatString)
        {
            var tokens = formatString.Split("|");

            return new Conversion()
            {
                From = tokens[0],
                To = tokens[1],
                Multiplier = double.Parse(tokens[2])
            };
        }

        public static Conversion GetConversion()
        {
            return new Conversion
            {
                From = AddConversion.FromInput.Text,
                To = AddConversion.ToInput.Text,
                Multiplier = Double.Parse(AddConversion.MultiplierInput.Text)
            };
        }

        public double CalculateResult(double value)
        {
            return value * this.Multiplier;
        }

        // Retrieved these overides from the official documentation
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Conversion objAsConversion = obj as Conversion;
            if (objAsConversion == null) return false;
            else return Equals(objAsConversion);
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Multiplier);
        }

        public bool Equals(Conversion other)
        {
            if (other == null) return false;
            return (this.Multiplier.Equals(other.Multiplier));
        }
    }
}