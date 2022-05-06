// Justin Pfeifler
// GUI Homework 6 - Line Up

namespace LineUp
{
    using System;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public partial class Main : Form
    {
        public static List<Player>Lineup = new List<Player>();
        public static Player PlayerToEdit = new Player();

        public Main()
        {
            InitializeComponent();

            this.SaveMenuItem.Click += SaveMenu_Click;
            this.LoadMenuItem.Click += LoadMenu_Click;
            this.AddMenuItem.Click += AddMenu_Click;
            this.EditMenuItem.Click += EditMenu_Click;
            this.RemoveMenuItem.Click += RemoveMenu_Click;
        }

        private void BindComboBox()
        {
            this.LineupComboBox.Items.Clear();
            foreach (Player player in Main.Lineup)
            {
                this.LineupComboBox.Items.Add(player.DisplayPlayer);
            }
        }

        private void AddMenu_Click(object sender, EventArgs e)
        {
            var addForm = new AddPlayer();
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Main.Lineup.Add(addForm.NewPlayer);
                BindComboBox();
            }
        }

        private void EditMenu_Click(object sender, EventArgs e)
        {
            if (this.LineupComboBox.CheckedItems.Count > 1 || this.LineupComboBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select 1 player to edit");
            }
            Player TempPlayer = (Player)this.LineupComboBox.CheckedItems[0];
            int PlayerToEditIndex = Main.Lineup.IndexOf(TempPlayer);
            Main.PlayerToEdit = Main.Lineup[PlayerToEditIndex];

            var editForm = new EditPlayer();
            var result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                BindComboBox();
            }
        }

        private void RemoveMenu_Click(object sender, EventArgs e)
        {
            Player PlayerToRemove = new Player();

            if (this.LineupComboBox.CheckedItems.Count > 1 || this.LineupComboBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select 1 player to remove");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this player?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    PlayerToRemove = (Player)this.LineupComboBox.CheckedItems[0];
                    Main.Lineup.Remove(PlayerToRemove);
                    BindComboBox();
                }
                // Else, do nothing
            }
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            string DialogFilter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = DialogFilter;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(dialog.FileName))
                        foreach (Player player in Main.Lineup)
                        {
                            var element = player as Player;
                            writer.WriteLine(element.FileFormat);
                        }
                }
            }
        }

        private void LoadMenu_Click(object sender, EventArgs e)
        {
            string DialogFilter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = DialogFilter;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var reader = new StreamReader(dialog.FileName))
                    {
                        var line = string.Empty;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.Length > 0)
                            {
                                Main.Lineup.Add(Player.Parse(line));
                            }
                        }
                    }
                }
            }

            BindComboBox();
        }

        public static List<POS> GetAvailablePositions()
        {
            List<POS> Positions = Enum.GetValues(typeof(POS)).Cast<POS>().ToList();

            foreach (Player player in Main.Lineup)
            {
                Positions.Remove(player.Position);
            }

            return Positions;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BindComboBox();
        }
    }
}
