using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelAndPictureBox
{
    class LabelColor:IObserver
    {

        List<Label> pictureBoxes;
     
        public LabelColor(List<Label> List)
        {
            pictureBoxes = List;
        }

        public void Update(Color color)
        {
            foreach (var observer in pictureBoxes)
            {
                observer.ForeColor = color;
            }
        }

    }

}
 
