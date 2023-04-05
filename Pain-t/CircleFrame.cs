﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class CircleShape : Shape
{
    public CircleShape(Pen pen) : base(pen)
    {
        Name = "CIRCLE";
    }

    public override void Draw(PaintEventArgs e, ComboBox a)
    {
        int width = endPoint.X - startPoint.X;
        int height = endPoint.Y - startPoint.Y;
        int size = Math.Min(width, height);
        Rectangle rect = new Rectangle(startPoint.X, startPoint.Y, size, size);
        e.Graphics.DrawEllipse(pen, rect);
    }
}


