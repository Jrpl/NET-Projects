
namespace Conversions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    public partial class ManageConversions : Form
    {
        public ManageConversions()
        {
            InitializeComponent();
        }

        private void ManageConversions_Load(object sender, EventArgs e)
        {
            this.ConversionsBox.DataSource = Conversions.AllConversions;
            this.ConversionsBox.DisplayMember = "FileFormat";
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (Conversion element in ConversionsBox.SelectedItems)
            {
                Conversions.AllConversions.Remove(element);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddConversion();
        }

        private void RestoreDefaultsButton_Click(object sender, EventArgs e)
        {
            string DialogFilter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            Conversions.AllConversions.Clear();

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
                                Conversions.AllConversions.Add(Conversion.Parse(line));
                            }
                        }
                    }
                }
            }
        }
    }
}
