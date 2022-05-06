
namespace LineUp
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class AddPlayer : Form
    {
        public Player NewPlayer = new Player();

        public AddPlayer()
        {
            InitializeComponent();
        }

        private void BindComboBox()
        {
            var bindingSource = new BindingSource(Main.GetAvailablePositions(), null);
            this.AddPosition.DataSource = bindingSource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Parse boxes
            int.TryParse(this.AddLineupNum.Text, out int TempLineupNum);
            this.NewPlayer.Name = this.AddName.Text;
            Enum.TryParse<POS>(AddPosition.SelectedValue.ToString(), out POS TempPosition);
            this.NewPlayer.Position = TempPosition;
            int.TryParse(this.AddAtBats.Text, out int TempAtBats);
            this.NewPlayer.AtBats = TempAtBats;
            int.TryParse(this.AddHits.Text, out int TempHits);
            this.NewPlayer.Hits = TempHits;
            this.NewPlayer.Average = this.NewPlayer.CalculateAverage;

            // Validation
            // Check if lineup num exists
            foreach (Player player in Main.Lineup)
            {
                if (player.LineupNum == TempLineupNum)
                {
                    MessageBox.Show("A player with that lineup number already exists");
                }
                else
                {
                    this.NewPlayer.LineupNum = TempLineupNum;
                }
            }
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {
            this.BindComboBox();
        }
    }
}