using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace L3_Exercise_Solution
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Color> _colors;

        public Form1()
        {
            InitializeComponent();
            LoadColors();
            AddColorsToDropDown();
        }



        protected void LoadColors()
        {
            _colors = new Dictionary<string, Color>();
            _colors.Add("black", Color.Black);
            _colors.Add("blue", Color.Blue);
            _colors.Add("green", Color.Green);
        }

        private void AddColorsToDropDown()
        {
            foreach (var color in _colors)
            {
                colorDropDown.Items.Add(color);
            }
        }

        private void ShowColorBtn_Click(object sender, EventArgs e)
        {
            var selectedColor = (Color)colorDropDown.SelectedItem;
            colorPanel.BackColor = selectedColor;
        }


        private void ShowColor()
        {
            int R = int.Parse(Rinput.Text);
            int G = int.Parse(Binput.Text);
            int B = int.Parse(Ginput.Text);
            panelRGB.BackColor = Color.FromArgb(R, G, B);
        }
        private void Rinput_TextChanged(object sender, EventArgs e)
        {
            int R;
            if (int.TryParse(Rinput.Text, out R) == false)
            {
                Rinput.Text = "0";
            }
            else if (R > 255 || R < 0)
            {
                Rinput.Text = "0";
            }
            ShowColor();
        }

        private void Ginput_TextChanged(object sender, EventArgs e)
        {
            int G;
            if (int.TryParse(Ginput.Text, out G) == false)
            {
                Ginput.Text = "0";
            }
            else if (G > 255 || G < 0)
            {
                Ginput.Text = "0";
            }
            ShowColor();
        }

        private void Binput_TextChanged(object sender, EventArgs e)
        {
            int B;
            if (int.TryParse(Binput.Text, out B) == false)
            {
                Binput.Text = "0";
            }
            else if (B > 255 || B < 0)
            {
                Binput.Text = "0";
            }
            ShowColor();
        }

        private void colorDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
