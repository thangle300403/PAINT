using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class RectangleShapeFill : Shape
{
    public RectangleShapeFill( SolidBrush brush) : base(brush)
    {
        Name = "RECF";
    }

    public override void Draw(PaintEventArgs e, ComboBox a)
    {
        int x = Math.Min(startPoint.X, endPoint.X);
        int y = Math.Min(startPoint.Y, endPoint.Y);
        int width = Math.Abs(startPoint.X - endPoint.X);
        int height = Math.Abs(startPoint.Y - endPoint.Y);
        Rectangle rect = new Rectangle(x, y, width, height);
        e.Graphics.FillRectangle(brush, rect);
    }
}
