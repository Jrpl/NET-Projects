
namespace Inventory
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        InventoryList inventory = new InventoryList();

        private void BindList()
        {
            this.InventoryListBox.Items.Clear();
            foreach (Item item in this.inventory)
            {
                this.InventoryListBox.Items.Add(item.DisplayItem());
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var addForm = new NewItemForm();
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.inventory.AddItem(addForm.newItem);
                BindList();
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            if (this.InventoryListBox.SelectedItems.Count > 0)
            {
                Item selectedItem = this.InventoryListBox.SelectedValue as Item;
                this.inventory.RemoveItem(selectedItem);
                BindList();
            }
            else
            {
                MessageBox.Show("Please select an item to delete");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            /*
             * I wanted to be able to append to an existing file so I found
             * this helpful post on stack overflow that showed how to differ
             * between creating the file and appending.
             * https://stackoverflow.com/questions/10322421/save-file-without-using-save-file-dialog
             */
            string filePath = "C:\\Users\\Justin\\Desktop\\Inventory.txt";

            // Check if the file exists, if it doesn't create a new one
            if (!File.Exists(filePath))
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    foreach (Item item in inventory)
                    {
                        writer.WriteLine(item.FileFormat);
                    }
                }
            }
            // If it does, append to it
            else
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    foreach (Item item in inventory)
                    {
                        writer.WriteLine(item.FileFormat);
                    }
                }
            }

            this.Close();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            this.inventory.Sort();
            BindList();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\Justin\\Desktop\\Inventory.txt";

            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    var line = string.Empty;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Length > 0)
                        {
                            inventory.AddItem(Item.Parse(line));
                        }
                    }
                }

                BindList();
            }
        }
    }
}
