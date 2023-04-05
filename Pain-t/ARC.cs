using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class ArcShape : Shape
{
    public ArcShape(Pen pen) : base(pen)
    {
        Name = "ARC";
    }

    public override void Draw(PaintEventArgs e, ComboBox a)
    {

        if (startPoint != null && endPoint != null)
        {
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);
            if (height == 0) 
            {
                height += 1;
            }
            if(endPoint.X < startPoint.X)
            {
                endPoint.X = startPoint.X - height;
            }
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            Rectangle rect = new Rectangle(x, y, height, height);

            if (endPoint.Y < startPoint.Y)
            {
                e.Graphics.DrawArc(pen, rect, 0, -180);
            }
            else
            {
                e.Graphics.DrawArc(pen, rect, 0, 180);
            }
        }

    }
    public override void Start(Point startPoint)
    {
        this.startPoint = startPoint;
        this.isDrawing = true;
    }
}
