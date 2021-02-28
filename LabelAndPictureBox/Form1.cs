using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LabelAndPictureBox
{
    public partial class Form1 : Form
    {
        private List<PictureBox> boxes;
        private List<Label> Labels;

        public Form1()
        {
            InitializeComponent();
            boxes = new List<PictureBox>()
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
            };
            Labels = new List<Label>()
            {
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10,
            };
        }

          Facade facade;

        private void button1_Click(object sender, EventArgs e)
        {
            facade = new Facade(Labels, boxes);
            facade.ChangeColor(colorDialog1.Color);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button2.BackColor = colorDialog1.Color;
             
        }
    }
}