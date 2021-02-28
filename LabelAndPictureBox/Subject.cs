using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelAndPictureBox
{
    class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify(Color color)
        {
            foreach (var observer in _observers)
            {
                observer.Update(color);
            }
        }
    }
}
