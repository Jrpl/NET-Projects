using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Justin Ray Pfeifler
// Assignment: Homework 2 - Mass
namespace GeometricSolids
{
    public partial class MassForm : Form
    {
        // Sphere properites
        public double SphereDensity { get; set; } = 1.0;
        public int SphereRadius { get; set; } = 1;
        public double SphereVolume { get; set; } = 4.18;
        public double SphereSurfaceArea { get; set; } = 12.57;
        public double SphereMass { get; set; } = 4.18;
        public double SphereMassLb { get; set; } = 0.01;

        // Cube properties
        public double CubeDensity { get; set; } = 1.0;
        public int CubeSide { get; set; } = 1;
        public double CubeVolume { get; set; } = 1.00;
        public double CubeSurfaceArea { get; set; } = 6.00;
        public double CubeMass { get; set; } = 1.00;
        public double CubeMassLb { get; set; } = 0.00;

        public MassForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display starting values for Sphere
            var SphereBuilder = new StringBuilder();
            SphereBuilder.Append($"Density {this.SphereDensity}{Environment.NewLine}");
            SphereBuilder.Append($"Radius {this.SphereRadius:F2}{Environment.NewLine}");
            SphereBuilder.Append($"Volume {this.SphereVolume:F2}{Environment.NewLine}");
            SphereBuilder.Append($"Surface Area {this.SphereSurfaceArea:F2}{Environment.NewLine}");
            SphereBuilder.Append($"Mass in Grams {this.SphereMass:F2} g{Environment.NewLine}");
            SphereBuilder.Append($"Mass in Pounds {this.SphereMassLb:F2} lbs");
            this.SphereMassTextBox.Text = SphereBuilder.ToString();

            // Display starting values for Cube
            var CubeBuilder = new StringBuilder();
            CubeBuilder.Append($"Density {this.CubeDensity}{Environment.NewLine}");
            CubeBuilder.Append($"Side {this.CubeSide:F2}{Environment.NewLine}");
            CubeBuilder.Append($"Volume {this.CubeVolume:F2}{Environment.NewLine}");
            CubeBuilder.Append($"Surface Area {this.CubeSurfaceArea:F2}{Environment.NewLine}");
            CubeBuilder.Append($"Mass in Grams {this.CubeMass:F2} g{Environment.NewLine}");
            CubeBuilder.Append($"Mass in Pounds {this.CubeMassLb:F2} lbs");
            this.CubeMassTextBox.Text = CubeBuilder.ToString();
        }

        private void SphereDensityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CubeDensityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void SphereRadiusSlider_Scroll(object sender, EventArgs e)
        {
            // When the slider scrolls, update the Mass text box
            this.SphereDensity = double.Parse(SphereDensityTextBox.Text);
            this.SphereRadius = SphereRadiusSlider.Value;
            this.SphereVolume = 4 * Math.PI * (Math.Pow(this.SphereRadius, 3) / 3);
            this.SphereSurfaceArea = 4 * Math.PI * Math.Pow(this.SphereRadius, 2);
            this.SphereMass = this.SphereVolume * this.SphereDensity;
            this.SphereMassLb = this.SphereMass * 0.00220462;

            var builder = new StringBuilder();
            builder.Append($"Density {this.SphereDensity}{Environment.NewLine}");
            builder.Append($"Radius {this.SphereRadius:F2}{Environment.NewLine}");
            builder.Append($"Volume {this.SphereVolume:F2}{Environment.NewLine}");
            builder.Append($"Surface Area {this.SphereSurfaceArea:F2}{Environment.NewLine}");
            builder.Append($"Mass in Grams {this.SphereMass:F2} g{Environment.NewLine}");
            builder.Append($"Mass in Pounds {this.SphereMassLb:F2} lbs");
            this.SphereMassTextBox.Text = builder.ToString();
        }

        private void CubeSideSlider_Scroll(object sender, EventArgs e)
        {
            // When the slider scrolls, update the Mass text box
            this.CubeDensity = double.Parse(CubeDensityTextBox.Text);
            this.CubeSide = CubeSideSlider.Value;
            this.CubeVolume = Math.Pow(this.CubeSide, 3);
            this.CubeSurfaceArea = 6 * Math.Pow(this.CubeSide, 2);
            this.CubeMass = this.CubeVolume * this.CubeDensity;
            this.CubeMassLb = this.CubeMass * 0.00220462;

            var builder = new StringBuilder();
            builder.Append($"Density {this.CubeDensity}{Environment.NewLine}");
            builder.Append($"Side {this.CubeSide:F2}{Environment.NewLine}");
            builder.Append($"Volume {this.CubeVolume:F2}{Environment.NewLine}");
            builder.Append($"Surface Area {this.CubeSurfaceArea:F2}{Environment.NewLine}");
            builder.Append($"Mass in Grams {this.CubeMass:F2} g{Environment.NewLine}");
            builder.Append($"Mass in Pounds {this.CubeMassLb:F2} lbs");
            this.CubeMassTextBox.Text = builder.ToString();
        }

        private void SphereResetButton_Click(object sender, EventArgs e)
        {
            // Reset the SphereGroupBox on click
            this.SphereDensity = 1.0;
            this.SphereRadius = 1;
            this.SphereVolume = 4.18;
            this.SphereSurfaceArea = 12.57;
            this.SphereMass = 4.18;
            this.SphereMassLb = 0.01;

            this.SphereDensityTextBox.Text = this.SphereDensity.ToString();
            this.SphereRadiusSlider.Value = this.SphereRadius;

            var builder = new StringBuilder();
            builder.Append($"Density {this.SphereDensity}{Environment.NewLine}");
            builder.Append($"Radius {this.SphereRadius:F2}{Environment.NewLine}");
            builder.Append($"Volume {this.SphereVolume:F2}{Environment.NewLine}");
            builder.Append($"Surface Area {this.SphereSurfaceArea:F2}{Environment.NewLine}");
            builder.Append($"Mass in Grams {this.SphereMass:F2} g{Environment.NewLine}");
            builder.Append($"Mass in Pounds {this.SphereMassLb:F2} lbs");
            this.SphereMassTextBox.Text = builder.ToString();
        }

        private void CubeResetButton_Click(object sender, EventArgs e)
        {
            // Reset the CubeGroupBox on click
            this.CubeDensity = 1.0;
            this.CubeSide = 1;
            this.CubeVolume = 1.00;
            this.CubeSurfaceArea = 6.00;
            this.CubeMass = 1.00;
            this.CubeMassLb = 0.00;

            this.CubeDensityTextBox.Text = this.CubeDensity.ToString();
            this.CubeSideSlider.Value = this.CubeSide;

            var builder = new StringBuilder();
            builder.Append($"Density {this.CubeDensity}{Environment.NewLine}");
            builder.Append($"Side {this.CubeSide:F2}{Environment.NewLine}");
            builder.Append($"Volume {this.CubeVolume:F2}{Environment.NewLine}");
            builder.Append($"Surface Area {this.CubeSurfaceArea:F2}{Environment.NewLine}");
            builder.Append($"Mass in Grams {this.CubeMass:F2} g{Environment.NewLine}");
            builder.Append($"Mass in Pounds {this.CubeMassLb:F2} lbs");
            this.CubeMassTextBox.Text = builder.ToString();
        }
    }
}
