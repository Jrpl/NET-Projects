
namespace Inventory
{
    using System;
    using System.Windows.Forms;

    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        public Item newItem;

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(this.ItemNoTextBox.Text, out int tempNum))
            {
                MessageBox.Show("The Item Number needs to be an integer");
            }
            if (!decimal.TryParse(this.PriceTextBox.Text, out decimal tempPrice))
            {
                MessageBox.Show("The Item Price needs to be a decimal");
            }

            if (this.PlantRadioButton.Checked)
            {
                this.newItem = new Plant
                {
                    Number = tempNum,
                    Description = this.DescriptionTextBox.Text,
                    Size = this.SizeTextBox.Text,
                    Price = tempPrice
                };
            }
            else if (this.SupplyRadioButton.Checked)
            {
                this.newItem = new Supply
                {
                    Number = tempNum,
                    Description = this.DescriptionTextBox.Text,
                    Manufacturer = this.ManufacturerComboBox.SelectedItem.ToString(),
                    Price = tempPrice
                };
            }
            else
            {
                MessageBox.Show("Please select a Plant or Supply");
            }
        }

        private void PlantRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.PlantRadioButton.Checked)
            {
                this.SizeLabel.Visible = true;
                this.SizeTextBox.Visible = true;
                this.ManufacturerLabel.Visible = false;
                this.ManufacturerComboBox.Visible = false;
            }
            else
            {
                this.SizeLabel.Visible = false;
                this.SizeTextBox.Visible = false;
                this.ManufacturerLabel.Visible = true;
                this.ManufacturerComboBox.Visible = true;
            }
        }
    }
}
