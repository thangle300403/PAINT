using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
    public class LineShape : Shape
    {
        public LineShape( Pen pen) : base(pen)
        {
        Name = "Line";
        }

        public override void Draw(PaintEventArgs e, ComboBox a)
        {
            e.Graphics.DrawLine(pen, startPoint, endPoint);
        }
    }

