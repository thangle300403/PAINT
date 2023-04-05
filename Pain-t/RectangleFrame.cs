using System;
using System.Drawing;
using System.Windows.Forms;
public class RectangleShape : Shape
{
    public RectangleShape(Pen pen) : base(pen)
    {
        Name = "REC";
    }

    public override void Draw(PaintEventArgs e, ComboBox a)
    {
        int x = Math.Min(startPoint.X, endPoint.X);
        int y = Math.Min(startPoint.Y, endPoint.Y);
        int width = Math.Abs(startPoint.X - endPoint.X);
        int height = Math.Abs(startPoint.Y - endPoint.Y);
        Rectangle rect = new Rectangle(x, y, width, height);
        e.Graphics.DrawRectangle(pen, rect);
    }
}
