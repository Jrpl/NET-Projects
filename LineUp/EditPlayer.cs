
namespace LineUp
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class EditPlayer : Form
    {
        public EditPlayer()
        {
            InitializeComponent();
        }

        private void BindComboBox()
        {
            var bindingSource = new BindingSource(Main.GetAvailablePositions(), null);
            this.EditPosition.DataSource = bindingSource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Parse boxes
            int.TryParse(this.EditLineupNum.Text, out int TempLineupNum);
            Main.PlayerToEdit.Name = this.EditName.Text;
            Enum.TryParse<POS>(EditPosition.SelectedValue.ToString(), out POS TempPosition);
            Main.PlayerToEdit.Position = TempPosition;
            int.TryParse(this.EditAtBats.Text, out int TempAtBats);
            Main.PlayerToEdit.AtBats = TempAtBats;
            int.TryParse(this.EditHits.Text, out int TempHits);
            Main.PlayerToEdit.Hits = TempHits;
            Main.PlayerToEdit.Average = Main.PlayerToEdit.CalculateAverage;

            // Validation
            // Check if lineup num exists
            foreach (Player player in Main.Lineup)
            {
                if (player.LineupNum == TempLineupNum)
                { // If the lineup number exists, swap lineup numbers
                    int OldPlayerIndex = Main.Lineup.IndexOf(player);
                    Player OldPlayer = Main.Lineup[OldPlayerIndex];

                    OldPlayer.LineupNum = Main.PlayerToEdit.LineupNum;
                    Main.PlayerToEdit.LineupNum = TempLineupNum;
                }
                else
                {
                    Main.PlayerToEdit.LineupNum = TempLineupNum;
                }
            }
        }

        private void EditPlayer_Load(object sender, EventArgs e)
        {
            this.BindComboBox();
            this.EditLineupNum.Text = Main.PlayerToEdit.LineupNum.ToString();
            this.EditName.Text = Main.PlayerToEdit.Name;
            this.EditAtBats.Text = Main.PlayerToEdit.AtBats.ToString();
            this.EditHits.Text = Main.PlayerToEdit.Hits.ToString();
        }
    }
}