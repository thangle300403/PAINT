using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class PolygonShape : Shape { 
    public PolygonShape(Pen pen) : base(pen)
    {
        Name = "POLY";
    }
    public override void Start(Point startPoint)
    {
        base.Start(startPoint);
        points.Add(startPoint);
    }

    public override void Draw(PaintEventArgs e, ComboBox a)
    {
        e.Graphics.DrawPolygon(pen, points.ToArray());
    }

    public override void End()
    {
        base.End();
        if (points.Count > 2)
        {
            points.RemoveAt(points.Count - 1);
        }
    }
    public override void OGPoints()
    {
        for (int i = 0; i < points.Count; i++)
        {
            pointOG.Add(points[i]);
        }
    }
}

