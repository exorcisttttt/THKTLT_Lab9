using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace THKTLT_Lab8
{
    class Circle: DrawingShape, IDraw, IColor
    {
        public Circle(int diameter) : base(diameter)
        {
            
        }
        public override void Draw(Canvas canvas)
        {
            if (this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Ellipse();
            }
            base.Draw(canvas);
        }
    }
}
