
namespace LineUp
{
    using System;
    using System.Text;

    public enum POS
    {
        C,
        FB,
        SB,
        TB,
        SS,
        LF,
        CF,
        RF,
        P
    }

    public class Player : IEquatable<Player>
    {
        public int LineupNum { get; set; }
        public string Name { get; set; }
        public POS Position { get; set; }
        public int AtBats { get; set; }
        public int Hits { get; set; }
        public double Average { get; set; }
        public string FileFormat => $"{this.LineupNum}|{this.Name}|{this.Position}|{this.AtBats}|{this.Hits}|{this.Average}";

        public string DisplayPlayer
        {
            get
            {
                var Builder = new StringBuilder();
                Builder.Append($"{LineupNum}  ");
                Builder.Append($"{Name}  ");
                Builder.Append($"{Position}  ");
                Builder.Append($"{AtBats}  ");
                Builder.Append($"{Hits}  ");
                Builder.Append($"{Average}  ");

                return Builder.ToString();
            }
        }

        public double CalculateAverage
        {
            get
            {
                return (double)this.Hits/(double)this.AtBats;
            }
        }

        public static Player Parse(string formatString)
        {
            var tokens = formatString.Split("|");
            Enum.TryParse(tokens[2], out POS TempPosition);

            return new Player() 
            { 
                LineupNum = int.Parse(tokens[0]), 
                Name = tokens[1], 
                Position = TempPosition, 
                AtBats = int.Parse(tokens[3]), 
                Hits = int.Parse(tokens[4]), 
                Average = double.Parse(tokens[5]) 
            };
        }

        // Retrieved these overides from the official documentation
        // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Player objAsPlayer = obj as Player;
            if (objAsPlayer == null) return false;
            else return Equals(objAsPlayer);
        }

        public override int GetHashCode()
        {
            return this.LineupNum;
        }

        public bool Equals(Player other)
        {
            if (other == null) return false;
            return (this.LineupNum.Equals(other.LineupNum));
        }
    }
}