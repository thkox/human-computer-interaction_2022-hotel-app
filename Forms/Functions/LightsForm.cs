﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_app.Forms.Functions
{
    public partial class LightsForm : Form
    {
        private Color light1Color;
        private Color light2Color;
        private Color light3Color;
        private Color light4Color;
        private Color light5Color;
        private Color light6Color;

        public LightsForm()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void lightButton1_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);
        }

        private void lightButton2_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);
        }

        private void lightButton3_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);
        }

        private void changeBackcolorOnMouseHover(IconButton light)
        {
            light.BackColor = Color.FromArgb(96, 144, 191);
        }

        private void color1Button_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                light1Color = colorPicker.Color;
                lightButton1.IconColor = light1Color;
            }
        }

        private void color2Button_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                light2Color = colorPicker.Color;
                lightButton2.IconColor = light2Color;
            }
        }

        private void color3Button_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                light3Color = colorPicker.Color;
                lightButton3.IconColor = light3Color;
            }
        }

        private void frontLightButton_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void mainDoorLightButton_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void storageLightButton_Click(object sender, EventArgs e)
        {
            changeStateOfLight((IconButton)sender);
        }

        private void colorFrontButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                light4Color = colorPicker.Color;
                frontLightButton.IconColor = light4Color;
            }
        }

        private void colorMainButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                light5Color = colorPicker.Color;
                mainDoorLightButton.IconColor = light5Color;
            }
        }

        private void colorStorageButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                light6Color = colorPicker.Color;
                storageLightButton.IconColor = light6Color;
            }
        }

        private void changeStateOfLight(IconButton light)
        {
            if (light.IconColor == Color.FromArgb(236, 241, 246)) //if the light is off
            {
                light.IconColor = Color.Yellow;
            }
            else light.IconColor = Color.FromArgb(236, 241, 246); //if the light is on
        }

        private void frontLightButton_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);
        }

        private void mainDoorLightButton_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);

        }

        private void storageLightButton_MouseHover(object sender, EventArgs e)
        {
            changeBackcolorOnMouseHover((IconButton)sender);

        }
    }
}
