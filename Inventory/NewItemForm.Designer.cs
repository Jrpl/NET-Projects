
namespace Inventory
{
    partial class NewItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlantRadioButton = new System.Windows.Forms.RadioButton();
            this.SupplyRadioButton = new System.Windows.Forms.RadioButton();
            this.ItemNoLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.ItemNoTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlantRadioButton
            // 
            this.PlantRadioButton.AutoSize = true;
            this.PlantRadioButton.Location = new System.Drawing.Point(110, 28);
            this.PlantRadioButton.Name = "PlantRadioButton";
            this.PlantRadioButton.Size = new System.Drawing.Size(52, 19);
            this.PlantRadioButton.TabIndex = 0;
            this.PlantRadioButton.Text = "Plant";
            this.PlantRadioButton.UseVisualStyleBackColor = true;
            this.PlantRadioButton.CheckedChanged += new System.EventHandler(this.PlantRadioButton_CheckedChanged);
            // 
            // SupplyRadioButton
            // 
            this.SupplyRadioButton.AutoSize = true;
            this.SupplyRadioButton.Checked = true;
            this.SupplyRadioButton.Location = new System.Drawing.Point(195, 28);
            this.SupplyRadioButton.Name = "SupplyRadioButton";
            this.SupplyRadioButton.Size = new System.Drawing.Size(61, 19);
            this.SupplyRadioButton.TabIndex = 1;
            this.SupplyRadioButton.TabStop = true;
            this.SupplyRadioButton.Text = "Supply";
            this.SupplyRadioButton.UseVisualStyleBackColor = true;
            // 
            // ItemNoLabel
            // 
            this.ItemNoLabel.AutoSize = true;
            this.ItemNoLabel.Location = new System.Drawing.Point(21, 65);
            this.ItemNoLabel.Name = "ItemNoLabel";
            this.ItemNoLabel.Size = new System.Drawing.Size(51, 15);
            this.ItemNoLabel.TabIndex = 2;
            this.ItemNoLabel.Text = "Item no:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(21, 103);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(21, 141);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(82, 15);
            this.ManufacturerLabel.TabIndex = 4;
            this.ManufacturerLabel.Text = "Manufacturer:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(21, 177);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(36, 15);
            this.PriceLabel.TabIndex = 5;
            this.PriceLabel.Text = "Price:";
            // 
            // ManufacturerComboBox
            // 
            this.ManufacturerComboBox.FormattingEnabled = true;
            this.ManufacturerComboBox.Items.AddRange(new object[] {
            "Ortho",
            "Scotts",
            "Trammo",
            "Terra",
            "Sigma",
            "Yara"});
            this.ManufacturerComboBox.Location = new System.Drawing.Point(110, 138);
            this.ManufacturerComboBox.Name = "ManufacturerComboBox";
            this.ManufacturerComboBox.Size = new System.Drawing.Size(131, 23);
            this.ManufacturerComboBox.TabIndex = 6;
            // 
            // ItemNoTextBox
            // 
            this.ItemNoTextBox.Location = new System.Drawing.Point(110, 62);
            this.ItemNoTextBox.Name = "ItemNoTextBox";
            this.ItemNoTextBox.Size = new System.Drawing.Size(110, 23);
            this.ItemNoTextBox.TabIndex = 7;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(110, 100);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(181, 23);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(110, 174);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(110, 23);
            this.PriceTextBox.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(110, 215);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(216, 215);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(110, 138);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(110, 23);
            this.SizeTextBox.TabIndex = 12;
            this.SizeTextBox.Visible = false;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(21, 141);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(30, 15);
            this.SizeLabel.TabIndex = 13;
            this.SizeLabel.Text = "Size:";
            this.SizeLabel.Visible = false;
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 257);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.ItemNoTextBox);
            this.Controls.Add(this.ManufacturerComboBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ItemNoLabel);
            this.Controls.Add(this.SupplyRadioButton);
            this.Controls.Add(this.PlantRadioButton);
            this.Name = "NewItemForm";
            this.Text = "New Inventory Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton PlantRadioButton;
        private System.Windows.Forms.RadioButton SupplyRadioButton;
        private System.Windows.Forms.Label ItemNoLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ComboBox ManufacturerComboBox;
        private System.Windows.Forms.TextBox ItemNoTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label SizeLabel;
    }
}