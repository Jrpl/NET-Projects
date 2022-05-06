
namespace LineUp
{
    partial class EditPlayer
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
            this.EditPosition = new System.Windows.Forms.ComboBox();
            this.EditHits = new System.Windows.Forms.TextBox();
            this.EditAtBats = new System.Windows.Forms.TextBox();
            this.EditName = new System.Windows.Forms.TextBox();
            this.EditLineupNum = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditPosition
            // 
            this.EditPosition.FormattingEnabled = true;
            this.EditPosition.Location = new System.Drawing.Point(113, 67);
            this.EditPosition.Name = "EditPosition";
            this.EditPosition.Size = new System.Drawing.Size(100, 23);
            this.EditPosition.TabIndex = 25;
            // 
            // EditHits
            // 
            this.EditHits.Location = new System.Drawing.Point(113, 127);
            this.EditHits.Name = "EditHits";
            this.EditHits.Size = new System.Drawing.Size(100, 23);
            this.EditHits.TabIndex = 24;
            this.EditHits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditAtBats
            // 
            this.EditAtBats.Location = new System.Drawing.Point(113, 97);
            this.EditAtBats.Name = "EditAtBats";
            this.EditAtBats.Size = new System.Drawing.Size(100, 23);
            this.EditAtBats.TabIndex = 23;
            this.EditAtBats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(113, 37);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(100, 23);
            this.EditName.TabIndex = 22;
            this.EditName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditLineupNum
            // 
            this.EditLineupNum.Location = new System.Drawing.Point(113, 8);
            this.EditLineupNum.Name = "EditLineupNum";
            this.EditLineupNum.Size = new System.Drawing.Size(100, 23);
            this.EditLineupNum.TabIndex = 21;
            this.EditLineupNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(126, 169);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Location = new System.Drawing.Point(24, 169);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "At Bats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lineup Number";
            // 
            // EditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 206);
            this.Controls.Add(this.EditPosition);
            this.Controls.Add(this.EditHits);
            this.Controls.Add(this.EditAtBats);
            this.Controls.Add(this.EditName);
            this.Controls.Add(this.EditLineupNum);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPlayer";
            this.Text = "Edit Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EditPosition;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox EditName;
        private System.Windows.Forms.TextBox EditLineupNum;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button n;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EditAtBats;
        private System.Windows.Forms.TextBox EditHits;
        private System.Windows.Forms.Button SaveButto;
        private System.Windows.Forms.Button SaveButton;
    }
}