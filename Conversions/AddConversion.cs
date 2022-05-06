
namespace Conversions
{
    using System;
    using System.Windows.Forms;

    public partial class AddConversion : Form
    {
        public Conversion NewConversion;
        public static int AddClicks = 0;

        public AddConversion()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Double.TryParse(AddConversion.MultiplierInput.Text, out double TempMultiplier);

            // Validation
            // Check if conversion exists
            foreach (Conversion conversion in Conversions.AllConversions)
            {
                if (conversion.From == AddConversion.FromInput.Text)
                {
                    MessageBox.Show("A conversion with that From name already exists");
                    AddConversion.FromInput.Clear();
                }
                else if (conversion.To == AddConversion.ToInput.Text)
                {
                    MessageBox.Show("A conversion with that To name already exists");
                    AddConversion.ToInput.Clear();
                }
                else if (conversion.Multiplier == TempMultiplier)
                {
                    MessageBox.Show("A conversion with that Multiplier already exists");
                    AddConversion.MultiplierInput.Clear();
                }
                else
                {
                    Conversions.AllConversions.AddNew();
                    AddClicks++;
                }
            }
        }
    }
}
