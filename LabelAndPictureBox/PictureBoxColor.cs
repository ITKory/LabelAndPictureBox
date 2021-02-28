using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelAndPictureBox
{
    class PictureBoxColor:IObserver
    {
        List<PictureBox> pictureBoxes;
        Subject subject;
        public PictureBoxColor(List<PictureBox> List)
        { 
            pictureBoxes = List;
        }
    
        public void Update(Color color)
        {
            foreach (var observer in pictureBoxes)
            {
                observer.BackColor = color;
            }
        }
   
    }
}
