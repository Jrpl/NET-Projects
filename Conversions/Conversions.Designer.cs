
namespace Conversions
{
    partial class Conversions
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ValueInputLabel = new System.Windows.Forms.Label();
            this.ValueInputBox = new System.Windows.Forms.TextBox();
            this.ConversionsLabel = new System.Windows.Forms.Label();
            this.ConversionsBox = new System.Windows.Forms.ListBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ConversionsResultBox = new System.Windows.Forms.RichTextBox();
            this.ManageConversionsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValueInputLabel
            // 
            this.ValueInputLabel.AutoSize = true;
            this.ValueInputLabel.Location = new System.Drawing.Point(35, 33);
            this.ValueInputLabel.Name = "ValueInputLabel";
            this.ValueInputLabel.Size = new System.Drawing.Size(95, 15);
            this.ValueInputLabel.TabIndex = 0;
            this.ValueInputLabel.Text = "Value to convert:";
            // 
            // ValueInputBox
            // 
            this.ValueInputBox.Location = new System.Drawing.Point(35, 52);
            this.ValueInputBox.Name = "ValueInputBox";
            this.ValueInputBox.Size = new System.Drawing.Size(100, 23);
            this.ValueInputBox.TabIndex = 1;
            // 
            // ConversionsLabel
            // 
            this.ConversionsLabel.AutoSize = true;
            this.ConversionsLabel.Location = new System.Drawing.Point(35, 91);
            this.ConversionsLabel.Name = "ConversionsLabel";
            this.ConversionsLabel.Size = new System.Drawing.Size(72, 15);
            this.ConversionsLabel.TabIndex = 2;
            this.ConversionsLabel.Text = "Conversions";
            // 
            // ConversionsBox
            // 
            this.ConversionsBox.FormattingEnabled = true;
            this.ConversionsBox.ItemHeight = 15;
            this.ConversionsBox.Location = new System.Drawing.Point(35, 110);
            this.ConversionsBox.Name = "ConversionsBox";
            this.ConversionsBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ConversionsBox.Size = new System.Drawing.Size(156, 184);
            this.ConversionsBox.TabIndex = 3;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(35, 316);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(116, 316);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ConversionsResultBox
            // 
            this.ConversionsResultBox.Location = new System.Drawing.Point(219, 33);
            this.ConversionsResultBox.Name = "ConversionsResultBox";
            this.ConversionsResultBox.Size = new System.Drawing.Size(273, 261);
            this.ConversionsResultBox.TabIndex = 6;
            this.ConversionsResultBox.Text = "";
            // 
            // ManageConversionsButton
            // 
            this.ManageConversionsButton.Location = new System.Drawing.Point(219, 315);
            this.ManageConversionsButton.Name = "ManageConversionsButton";
            this.ManageConversionsButton.Size = new System.Drawing.Size(153, 23);
            this.ManageConversionsButton.TabIndex = 7;
            this.ManageConversionsButton.Text = "Manage Conversions";
            this.ManageConversionsButton.UseVisualStyleBackColor = true;
            this.ManageConversionsButton.Click += new System.EventHandler(this.ManageConversionsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(417, 315);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Conversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 358);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ManageConversionsButton);
            this.Controls.Add(this.ConversionsResultBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConversionsBox);
            this.Controls.Add(this.ConversionsLabel);
            this.Controls.Add(this.ValueInputBox);
            this.Controls.Add(this.ValueInputLabel);
            this.Name = "Conversions";
            this.Text = "Conversions";
            this.Load += new System.EventHandler(this.Conversions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValueInputLabel;
        private System.Windows.Forms.TextBox ValueInputBox;
        private System.Windows.Forms.Label ConversionsLabel;
        private System.Windows.Forms.ListBox ConversionsBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RichTextBox Ce;
        private System.Windows.Forms.Button ManageConversionsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RichTextBox ConversionsResultBox;
    }
}

