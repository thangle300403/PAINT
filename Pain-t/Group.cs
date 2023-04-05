using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Group : Shape
{
    public Group(Pen pen, List<Shape> shapes, List<int> idx) : base(pen)
    {
        Name = "Group";
        foreach (int i in idx)
        {
            this.Shapes.Add(shapes[i]);
            this.IDX++;
        }
    }
    public override void Draw(PaintEventArgs e, ComboBox a)
    {
        for (int i =0;i < IDX;i++)
        {
            this.Shapes[i].Draw(e, a);
        }
    }
    public override void OGPoints()
    {
        for (int i = 0; i < IDX; i++)
        {
            this.Shapes[i].OGPoints();
        }
    }
}

