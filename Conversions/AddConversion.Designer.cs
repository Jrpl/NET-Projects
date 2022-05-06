
namespace Conversions
{
    partial class AddConversion
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
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.MultiplierLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FromInput = new System.Windows.Forms.TextBox();
            this.ToInput = new System.Windows.Forms.TextBox();
            this.MultiplierInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(23, 26);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(38, 15);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "From:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(23, 61);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(22, 15);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "To:";
            // 
            // MultiplierLabel
            // 
            this.MultiplierLabel.AutoSize = true;
            this.MultiplierLabel.Location = new System.Drawing.Point(23, 97);
            this.MultiplierLabel.Name = "MultiplierLabel";
            this.MultiplierLabel.Size = new System.Drawing.Size(61, 15);
            this.MultiplierLabel.TabIndex = 2;
            this.MultiplierLabel.Text = "Multiplier:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(23, 144);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(136, 144);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // FromInput
            // 
            this.FromInput.Location = new System.Drawing.Point(111, 23);
            this.FromInput.Name = "FromInput";
            this.FromInput.Size = new System.Drawing.Size(100, 23);
            this.FromInput.TabIndex = 5;
            // 
            // ToInput
            // 
            this.ToInput.Location = new System.Drawing.Point(111, 58);
            this.ToInput.Name = "ToInput";
            this.ToInput.Size = new System.Drawing.Size(100, 23);
            this.ToInput.TabIndex = 6;
            // 
            // MultiplierInput
            // 
            this.MultiplierInput.Location = new System.Drawing.Point(111, 94);
            this.MultiplierInput.Name = "MultiplierInput";
            this.MultiplierInput.Size = new System.Drawing.Size(100, 23);
            this.MultiplierInput.TabIndex = 7;
            // 
            // AddConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 186);
            this.Controls.Add(this.MultiplierInput);
            this.Controls.Add(this.ToInput);
            this.Controls.Add(this.FromInput);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.MultiplierLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Name = "AddConversion";
            this.Text = "AddConversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label MultiplierLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox FromInput;
        public System.Windows.Forms.TextBox ToInput;
        public System.Windows.Forms.TextBox MultiplierInput;
    }
}