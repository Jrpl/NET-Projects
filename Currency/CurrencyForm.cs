
namespace Currency
{
    using System;
    using System.Windows.Forms;
    using System.Xml;
    using System.Text.Json;
    using System.IO;

    public partial class CurrencyForm : Form
    {
        public CurrencyForm()
        {
            InitializeComponent();

            this.ImportMenuItem.Click += ImportMenu_Click;
            this.SaveMenuItem.Click += SaveMenu_Click;
        }

        CurrencyList list = new CurrencyList();
        CurrencyList saveList = new CurrencyList();

        private void BindComboBox()
        {
            this.CurrencyFromComboBox.Items.Clear();
            this.CurrencyToComboBox.Items.Clear();
            foreach (Currency currency in this.list)
            {
                this.CurrencyFromComboBox.Items.Add(currency.Name);
                this.CurrencyToComboBox.Items.Add(currency.Name);
            }
        }

        private void ImportMenu_Click(object sender, EventArgs e)
        {
            string DialogFilter = "XML Files (*.xml)|*.xml";

            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = DialogFilter;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var reader = XmlReader.Create(dialog.FileName))
                    {
                        while (reader.ReadToFollowing("Cube"))
                        {
                            reader.MoveToFirstAttribute();
                            var type = reader.Value;
                            string name = reader.GetAttribute("currency");
                            decimal.TryParse(reader.GetAttribute("rate"), out decimal rate);

                            var currency = new Currency { Name = name, Rate = rate };
                            if (currency.Name == null || currency.Rate == default(decimal))
                            {
                                // do nothing
                            }
                            else
                            {
                                this.list.AddItem(currency);
                            }
                        }
                    }
                }
            }
            this.list.Sort();
            BindComboBox();
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            string DialogFilter = "Json files (*.json)|*.json";

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = DialogFilter;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = File.CreateText(dialog.FileName))
                    {
                        var options = new JsonSerializerOptions { WriteIndented = true };
                        string json = JsonSerializer.Serialize(this.saveList, options);
                        writer.Write(json);
                    }
                }
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            this.saveList.Clear();

            string tempFrom = this.CurrencyFromComboBox.Text;
            string tempTo = this.CurrencyToComboBox.Text;
            decimal.TryParse(this.AmountTextBox.Text, out decimal amnt);

            if (tempFrom == tempTo)
            {
                MessageBox.Show("Please select two seperate currencies in order to convert");
                this.CurrencyFromComboBox.ResetText();
                this.CurrencyFromComboBox.SelectedIndex = -1;
                this.CurrencyToComboBox.ResetText();
                this.CurrencyToComboBox.SelectedIndex = -1;
                this.AmountTextBox.Clear();
            }
            else
            {
                Currency from = new Currency();
                Currency to = new Currency();

                foreach (Currency currency in this.list)
                {
                    if (currency.Name == tempFrom)
                    {
                        from = currency;
                    }
                    if (currency.Name == tempTo)
                    {
                        to = currency;
                    }
                }

                this.ResultValueLabel.Text = (amnt * to.Rate).ToString();

                foreach (Currency currency in this.list)
                {
                    Amount tempCurrency;

                    if (currency.Name == tempFrom)
                    {
                        tempCurrency = new Amount { Name = currency.Name, Rate = currency.Rate, Value = amnt };
                    }
                    else
                    {
                        tempCurrency = new Amount { Name = currency.Name, Rate = currency.Rate, Value = amnt };
                    }

                    this.saveList.AddItem(tempCurrency);
                }
            }
        }
    }
}
