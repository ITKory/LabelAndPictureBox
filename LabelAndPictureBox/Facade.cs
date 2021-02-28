using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelAndPictureBox
{
    class Facade
    {
        PictureBoxColor pictureBox;
        LabelColor LabelColor;
        Subject subject;
        public Facade(List<Label> labels , List<PictureBox> pictureBoxes)
        {
            pictureBox = new PictureBoxColor(pictureBoxes);
            LabelColor = new LabelColor(labels);
            subject = new Subject(); 
            subject.Attach(pictureBox);
            subject.Attach(LabelColor);
        }
        public void ChangeColor(Color color)
        {
            subject.Notify(color);
        }
    }
}
