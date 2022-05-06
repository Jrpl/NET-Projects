// Justin Pfeifler
// GUI Homework 7 - Conversions

namespace Conversions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public partial class Conversions : Form
    {
        public static BindingList<Conversion> AllConversions = new BindingList<Conversion>();
        public List<StringBuilder> ConversionResults = new List<StringBuilder>();

        public Conversions()
        {
            InitializeComponent();
        }

        private void Conversions_Load(object sender, EventArgs e)
        {
            this.ConversionsBox.DataSource = AllConversions;
            this.ConversionsBox.DisplayMember = "FileFormat";
            Conversions.AllConversions.AddingNew += this.AllConversions_AddingNew;
            Conversions.AllConversions.ListChanged += this.AllConversions_ListChanged;
        }

        private void AllConversions_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = Conversion.GetConversion();
        }

        private void AllConversions_ListChanged(object sender, ListChangedEventArgs e)
        {
            Conversions.AllConversions.ResetBindings();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            this.ConversionsResultBox.Clear();
            Double.TryParse(this.ValueInputBox.Text, out double value);

            foreach (Conversion element in ConversionsBox.SelectedItems)
            {
                double result = element.CalculateResult(value);
                var Builder = new StringBuilder();
                Builder.Append($"{value} ");
                Builder.Append($"{element.From} = ");
                Builder.Append($"{result} ");
                Builder.Append($"{element.To}");
                this.ConversionsResultBox.Text += Builder.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ValueInputBox.Clear();
            this.ConversionsBox.ClearSelected();
            this.ConversionsResultBox.Clear();
        }

        private void ManageConversionsButton_Click(object sender, EventArgs e)
        {
            new ManageConversions();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (AddConversion.AddClicks > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to save your added conversions?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string DialogFilter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                    using (var dialog = new SaveFileDialog())
                    {
                        dialog.Filter = DialogFilter;

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            using (var writer = new StreamWriter(dialog.FileName))
                            foreach (Conversion conversion in AllConversions)
                            {
                                var element = conversion as Conversion;
                                writer.WriteLine(element.FileFormat);
                            }
                        }
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
