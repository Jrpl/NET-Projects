
namespace LineUp
{
    partial class AddPlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddCancelButton = new System.Windows.Forms.Button();
            this.AddLineupNum = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.TextBox();
            this.AddAtBats = new System.Windows.Forms.TextBox();
            this.AddHits = new System.Windows.Forms.TextBox();
            this.AddPosition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lineup Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "At Bats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hits";
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(27, 170);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddCancelButton
            // 
            this.AddCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddCancelButton.Location = new System.Drawing.Point(129, 170);
            this.AddCancelButton.Name = "AddCancelButton";
            this.AddCancelButton.Size = new System.Drawing.Size(75, 23);
            this.AddCancelButton.TabIndex = 7;
            this.AddCancelButton.Text = "Cancel";
            this.AddCancelButton.UseVisualStyleBackColor = true;
            // 
            // AddLineupNum
            // 
            this.AddLineupNum.Location = new System.Drawing.Point(116, 9);
            this.AddLineupNum.Name = "AddLineupNum";
            this.AddLineupNum.PlaceholderText = "1";
            this.AddLineupNum.Size = new System.Drawing.Size(100, 23);
            this.AddLineupNum.TabIndex = 8;
            this.AddLineupNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(116, 38);
            this.AddName.Name = "AddName";
            this.AddName.PlaceholderText = "Bob";
            this.AddName.Size = new System.Drawing.Size(100, 23);
            this.AddName.TabIndex = 9;
            this.AddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddAtBats
            // 
            this.AddAtBats.Location = new System.Drawing.Point(116, 98);
            this.AddAtBats.Name = "AddAtBats";
            this.AddAtBats.PlaceholderText = "10";
            this.AddAtBats.Size = new System.Drawing.Size(100, 23);
            this.AddAtBats.TabIndex = 11;
            this.AddAtBats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddHits
            // 
            this.AddHits.Location = new System.Drawing.Point(116, 128);
            this.AddHits.Name = "AddHits";
            this.AddHits.PlaceholderText = "4";
            this.AddHits.Size = new System.Drawing.Size(100, 23);
            this.AddHits.TabIndex = 12;
            this.AddHits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddPosition
            // 
            this.AddPosition.FormattingEnabled = true;
            this.AddPosition.Location = new System.Drawing.Point(116, 68);
            this.AddPosition.Name = "AddPosition";
            this.AddPosition.Size = new System.Drawing.Size(100, 23);
            this.AddPosition.TabIndex = 13;
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 206);
            this.Controls.Add(this.AddPosition);
            this.Controls.Add(this.AddHits);
            this.Controls.Add(this.AddAtBats);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.AddLineupNum);
            this.Controls.Add(this.AddCancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPlayer";
            this.Text = "Add Player";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button But;
        private System.Windows.Forms.Button AddCancelButton;
        private System.Windows.Forms.TextBox AddLineupNum;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.TextBox AddAtBats;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.ComboBox AddPosition;
        private System.Windows.Forms.TextBox AddHits;
        private System.Windows.Forms.Button AddButton;
    }
}