
namespace GeometricSolids
{
    partial class MassForm
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
            this.SphereGroupBox = new System.Windows.Forms.GroupBox();
            this.SphereResetButton = new System.Windows.Forms.Button();
            this.SphereMassTextBox = new System.Windows.Forms.RichTextBox();
            this.SphereMassLabel = new System.Windows.Forms.Label();
            this.SphereRadiusSlider = new System.Windows.Forms.TrackBar();
            this.SphereRadiusLabel = new System.Windows.Forms.Label();
            this.SphereDensityTextBox = new System.Windows.Forms.TextBox();
            this.SphereDensityLabel = new System.Windows.Forms.Label();
            this.CubeResetButton = new System.Windows.Forms.Button();
            this.CubeMassTextBox = new System.Windows.Forms.RichTextBox();
            this.CubeMassLabel = new System.Windows.Forms.Label();
            this.CubeSideSlider = new System.Windows.Forms.TrackBar();
            this.CubeSideLabel = new System.Windows.Forms.Label();
            this.CubeDensityTextBox = new System.Windows.Forms.TextBox();
            this.CubeDensityLabel = new System.Windows.Forms.Label();
            this.CubeGroupBox = new System.Windows.Forms.GroupBox();
            this.SphereGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRadiusSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CubeSideSlider)).BeginInit();
            this.CubeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SphereGroupBox
            // 
            this.SphereGroupBox.Controls.Add(this.SphereResetButton);
            this.SphereGroupBox.Controls.Add(this.SphereMassTextBox);
            this.SphereGroupBox.Controls.Add(this.SphereMassLabel);
            this.SphereGroupBox.Controls.Add(this.SphereRadiusSlider);
            this.SphereGroupBox.Controls.Add(this.SphereRadiusLabel);
            this.SphereGroupBox.Controls.Add(this.SphereDensityTextBox);
            this.SphereGroupBox.Controls.Add(this.SphereDensityLabel);
            this.SphereGroupBox.Location = new System.Drawing.Point(13, 13);
            this.SphereGroupBox.Name = "SphereGroupBox";
            this.SphereGroupBox.Size = new System.Drawing.Size(300, 285);
            this.SphereGroupBox.TabIndex = 0;
            this.SphereGroupBox.TabStop = false;
            this.SphereGroupBox.Text = "Sphere";
            // 
            // SphereResetButton
            // 
            this.SphereResetButton.Location = new System.Drawing.Point(133, 239);
            this.SphereResetButton.Name = "SphereResetButton";
            this.SphereResetButton.Size = new System.Drawing.Size(75, 23);
            this.SphereResetButton.TabIndex = 6;
            this.SphereResetButton.Text = "Reset";
            this.SphereResetButton.UseVisualStyleBackColor = true;
            this.SphereResetButton.Click += new System.EventHandler(this.SphereResetButton_Click);
            // 
            // SphereMassTextBox
            // 
            this.SphereMassTextBox.Location = new System.Drawing.Point(64, 96);
            this.SphereMassTextBox.Name = "SphereMassTextBox";
            this.SphereMassTextBox.ReadOnly = true;
            this.SphereMassTextBox.Size = new System.Drawing.Size(202, 122);
            this.SphereMassTextBox.TabIndex = 5;
            this.SphereMassTextBox.Text = "";
            // 
            // SphereMassLabel
            // 
            this.SphereMassLabel.AutoSize = true;
            this.SphereMassLabel.Location = new System.Drawing.Point(11, 99);
            this.SphereMassLabel.Name = "SphereMassLabel";
            this.SphereMassLabel.Size = new System.Drawing.Size(34, 15);
            this.SphereMassLabel.TabIndex = 4;
            this.SphereMassLabel.Text = "Mass";
            // 
            // SphereRadiusSlider
            // 
            this.SphereRadiusSlider.Location = new System.Drawing.Point(60, 56);
            this.SphereRadiusSlider.Maximum = 30;
            this.SphereRadiusSlider.Minimum = 1;
            this.SphereRadiusSlider.Name = "SphereRadiusSlider";
            this.SphereRadiusSlider.Size = new System.Drawing.Size(206, 45);
            this.SphereRadiusSlider.TabIndex = 3;
            this.SphereRadiusSlider.Value = 1;
            this.SphereRadiusSlider.Scroll += new System.EventHandler(this.SphereRadiusSlider_Scroll);
            // 
            // SphereRadiusLabel
            // 
            this.SphereRadiusLabel.AutoSize = true;
            this.SphereRadiusLabel.Location = new System.Drawing.Point(11, 65);
            this.SphereRadiusLabel.Name = "SphereRadiusLabel";
            this.SphereRadiusLabel.Size = new System.Drawing.Size(42, 15);
            this.SphereRadiusLabel.TabIndex = 2;
            this.SphereRadiusLabel.Text = "Radius";
            // 
            // SphereDensityTextBox
            // 
            this.SphereDensityTextBox.Location = new System.Drawing.Point(64, 27);
            this.SphereDensityTextBox.Name = "SphereDensityTextBox";
            this.SphereDensityTextBox.Size = new System.Drawing.Size(50, 23);
            this.SphereDensityTextBox.TabIndex = 1;
            this.SphereDensityTextBox.Text = "1.0";
            this.SphereDensityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SphereDensityTextBox_KeyPress);
            // 
            // SphereDensityLabel
            // 
            this.SphereDensityLabel.AutoSize = true;
            this.SphereDensityLabel.Location = new System.Drawing.Point(11, 31);
            this.SphereDensityLabel.Name = "SphereDensityLabel";
            this.SphereDensityLabel.Size = new System.Drawing.Size(46, 15);
            this.SphereDensityLabel.TabIndex = 0;
            this.SphereDensityLabel.Text = "Density";
            // 
            // CubeResetButton
            // 
            this.CubeResetButton.Location = new System.Drawing.Point(133, 239);
            this.CubeResetButton.Name = "CubeResetButton";
            this.CubeResetButton.Size = new System.Drawing.Size(75, 23);
            this.CubeResetButton.TabIndex = 6;
            this.CubeResetButton.Text = "Reset";
            this.CubeResetButton.UseVisualStyleBackColor = true;
            this.CubeResetButton.Click += new System.EventHandler(this.CubeResetButton_Click);
            // 
            // CubeMassTextBox
            // 
            this.CubeMassTextBox.Location = new System.Drawing.Point(64, 96);
            this.CubeMassTextBox.Name = "CubeMassTextBox";
            this.CubeMassTextBox.ReadOnly = true;
            this.CubeMassTextBox.Size = new System.Drawing.Size(202, 122);
            this.CubeMassTextBox.TabIndex = 5;
            this.CubeMassTextBox.Text = "";
            // 
            // CubeMassLabel
            // 
            this.CubeMassLabel.AutoSize = true;
            this.CubeMassLabel.Location = new System.Drawing.Point(11, 99);
            this.CubeMassLabel.Name = "CubeMassLabel";
            this.CubeMassLabel.Size = new System.Drawing.Size(34, 15);
            this.CubeMassLabel.TabIndex = 4;
            this.CubeMassLabel.Text = "Mass";
            // 
            // CubeSideSlider
            // 
            this.CubeSideSlider.Location = new System.Drawing.Point(60, 56);
            this.CubeSideSlider.Maximum = 30;
            this.CubeSideSlider.Minimum = 1;
            this.CubeSideSlider.Name = "CubeSideSlider";
            this.CubeSideSlider.Size = new System.Drawing.Size(206, 45);
            this.CubeSideSlider.TabIndex = 3;
            this.CubeSideSlider.Value = 1;
            this.CubeSideSlider.Scroll += new System.EventHandler(this.CubeSideSlider_Scroll);
            // 
            // CubeSideLabel
            // 
            this.CubeSideLabel.AutoSize = true;
            this.CubeSideLabel.Location = new System.Drawing.Point(11, 65);
            this.CubeSideLabel.Name = "CubeSideLabel";
            this.CubeSideLabel.Size = new System.Drawing.Size(29, 15);
            this.CubeSideLabel.TabIndex = 2;
            this.CubeSideLabel.Text = "Side";
            // 
            // CubeDensityTextBox
            // 
            this.CubeDensityTextBox.Location = new System.Drawing.Point(64, 27);
            this.CubeDensityTextBox.Name = "CubeDensityTextBox";
            this.CubeDensityTextBox.Size = new System.Drawing.Size(50, 23);
            this.CubeDensityTextBox.TabIndex = 1;
            this.CubeDensityTextBox.Text = "1.0";
            this.CubeDensityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CubeDensityTextBox_KeyPress);
            // 
            // CubeDensityLabel
            // 
            this.CubeDensityLabel.AutoSize = true;
            this.CubeDensityLabel.Location = new System.Drawing.Point(11, 31);
            this.CubeDensityLabel.Name = "CubeDensityLabel";
            this.CubeDensityLabel.Size = new System.Drawing.Size(46, 15);
            this.CubeDensityLabel.TabIndex = 0;
            this.CubeDensityLabel.Text = "Density";
            // 
            // CubeGroupBox
            // 
            this.CubeGroupBox.Controls.Add(this.CubeResetButton);
            this.CubeGroupBox.Controls.Add(this.CubeMassTextBox);
            this.CubeGroupBox.Controls.Add(this.CubeMassLabel);
            this.CubeGroupBox.Controls.Add(this.CubeSideSlider);
            this.CubeGroupBox.Controls.Add(this.CubeSideLabel);
            this.CubeGroupBox.Controls.Add(this.CubeDensityTextBox);
            this.CubeGroupBox.Controls.Add(this.CubeDensityLabel);
            this.CubeGroupBox.Location = new System.Drawing.Point(319, 13);
            this.CubeGroupBox.Name = "CubeGroupBox";
            this.CubeGroupBox.Size = new System.Drawing.Size(300, 285);
            this.CubeGroupBox.TabIndex = 1;
            this.CubeGroupBox.TabStop = false;
            this.CubeGroupBox.Text = "Cube";
            // 
            // MassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 316);
            this.Controls.Add(this.CubeGroupBox);
            this.Controls.Add(this.SphereGroupBox);
            this.Name = "MassForm";
            this.Text = "Mass Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SphereGroupBox.ResumeLayout(false);
            this.SphereGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SphereRadiusSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CubeSideSlider)).EndInit();
            this.CubeGroupBox.ResumeLayout(false);
            this.CubeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SphereGroupBox;
        private System.Windows.Forms.Button SphereResetButton;
        private System.Windows.Forms.RichTextBox SphereMassTextBox;
        private System.Windows.Forms.Label SphereMassLabel;
        private System.Windows.Forms.TrackBar SphereRadiusSlider;
        private System.Windows.Forms.Label SphereRadiusLabel;
        private System.Windows.Forms.TextBox SphereDensityTextBox;
        private System.Windows.Forms.Label SphereDensityLabel;
        private System.Windows.Forms.Button CubeResetButton;
        private System.Windows.Forms.RichTextBox CubeMassTextBox;
        private System.Windows.Forms.Label CubeMassLabel;
        private System.Windows.Forms.TrackBar CubeSideSlider;
        private System.Windows.Forms.Label CubeSideLabel;
        private System.Windows.Forms.TextBox CubeDensityTextBox;
        private System.Windows.Forms.Label CubeDensityLabel;
        private System.Windows.Forms.GroupBox CubeGroupBox;
    }
}

