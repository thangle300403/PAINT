using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Pain_tssq2
{
    public partial class Form1 : Form
    {
        bool polu = false;
        Random rnd = new Random();
        Graphics graphics;
        System.Drawing.SolidBrush solidBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        Color myColor = Color.Black;
        int size = 5;
        Pen myPen = new Pen(Color.Black, 5);
        Point move;

        bool isStart = false;
        bool istat2 = false;
        bool polu2 = false;
        bool select = false;
        bool dragging = false;
        List<Shape> shapes = new List<Shape>();
        List<Shape> groups = new List<Shape>();
        List<int> idx = new List<int>();
        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });
            graphics = this.panel1.CreateGraphics();
            solidBrush = new SolidBrush(myColor);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           myPen.DashStyle = (System.Drawing.Drawing2D.DashStyle)comboBox1.SelectedItem;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Color a = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            if(select == true)
            {
                dragging = true;
                move = new Point(e.X, e.Y);
                foreach (int i in idx)
                    shapes[i].OGPoints();
                Console.WriteLine("MOVE");
            }
            else if (polu == true)
            {
                Console.WriteLine("POLU");
                if(istat2 == true)
                {
                    Console.WriteLine("POLUstat");
                    Console.WriteLine(e.Location);
                    shapes[shapes.Count() - 1].points.Add(e.Location);
                    shapes[shapes.Count() - 1].startPoint = e.Location;

                }
                shapes[shapes.Count() - 1].points.Add(shapes[shapes.Count() - 1].startPoint);
                polu2 = true;
                isStart = true;
            }
            else
            {
                if(istat2 == true)
                {
                    shapes[shapes.Count() - 1].Start(e.Location);
                    isStart = true;
                }
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //this.label1.Text = Convert.ToString(e.Location);
            if(dragging == true)
            {
                foreach (int i in idx)
                {
                    int w1 = e.X - move.X;
                    int h1 = e.Y - move.Y;
                    if(shapes[i].Name.Equals("Group"))
                    {
                        int len = shapes[i].Shapes.Count();
                        for(int k=0;k<len;k++)
                        {
                            if (shapes[i].Shapes[k].Name.Equals("POLY") || shapes[i].Shapes[k].Name.Equals("FPOLY"))
                            {
                                int len1 = shapes[i].Shapes[k].points.Count();
                                for (int j = 0; j < len1; j++)
                                {
                                    Point temp = new Point(shapes[i].Shapes[k].pointOG[j].X + w1, shapes[i].Shapes[k].pointOG[j].Y + h1);
                                    shapes[i].Shapes[k].points[j] = temp;
                                }
                            }
                            else
                            {
                                Point temp = new Point(shapes[i].Shapes[k].pointOG[0].X + w1, shapes[i].Shapes[k].pointOG[0].Y + h1);
                                Point temp2 = new Point(shapes[i].Shapes[k].pointOG[1].X + w1, shapes[i].Shapes[k].pointOG[1].Y + h1);
                                shapes[i].Shapes[k].startPoint = temp;
                                shapes[i].Shapes[k].endPoint = temp2;
                            }
                        }
                    }
                    else if (shapes[i].Name.Equals("POLY") || shapes[i].Name.Equals("FPOLY"))
                    {
                        int len = shapes[i].points.Count();
                        for (int j = 0; j < len; j++)
                        {
                            Point temp = new Point(shapes[i].pointOG[j].X + w1, shapes[i].pointOG[j].Y + h1);
                            shapes[i].points[j] = temp;
                        }
                    }
                    else
                    {
                        Point temp = new Point(shapes[i].pointOG[0].X + w1, shapes[i].pointOG[0].Y + h1);
                        Point temp2 = new Point(shapes[i].pointOG[1].X + w1, shapes[i].pointOG[1].Y + h1);
                        shapes[i].startPoint = temp;
                        shapes[i].endPoint = temp2;
                    }
                    this.panel1.Refresh();
                }
            }
            else if (polu == true)
            {
                try 
                {
                    if(polu2 == true && isStart == true)
                    {
                        Console.WriteLine("LOL");
                        Console.WriteLine(e.Location);
                        shapes[shapes.Count() - 1].points[shapes[shapes.Count() - 1].points.Count() - 1] = e.Location;
                        this.panel1.Refresh();
                    }   
                }
                catch(Exception fix)
                {

                }
            }
            else
                if (isStart == true)
                {
                    shapes[shapes.Count() - 1].endPoint = e.Location;
                    this.panel1.Refresh();
                }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //this.label1.Text = Convert.ToString(e.Location);
            idx.Clear();
            dragging = false;
            select = false;
            isStart = false;
            istat2 = false;
            polu2 = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(e ,this.comboBox1);
            }
        }
        
        private void Line_Click(object sender, EventArgs e)
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            istat2 = true;
            polu2 = false;
            polu = false;
            shapes.Add(new LineShape(myPen));
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }
        private void button1_Click(object sender, EventArgs e)//RecFR
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            istat2 = true;
            polu2 = false;
            polu = false;
            shapes.Add(new RectangleShape(myPen));
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }
        private void button1_Click_1(object sender, EventArgs e)//FillRec
        {
            DEL_NULL();
            istat2 = true;
            polu2 = false;
            polu = false;
            shapes.Add(new RectangleShapeFill(solidBrush));
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }
        private void EllFr_Click(object sender, EventArgs e)
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            istat2 = true;
            polu2 = false;
            polu = false;
            shapes.Add(new EllipseShape(myPen));
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }
        private void EllFilled_Click(object sender, EventArgs e)
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            istat2 = true;
            polu2 = false;
            polu = false;
            shapes.Add(new EllipseShapeFill(solidBrush));
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }
        private void CircleFr_Click(object sender, EventArgs e)
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            istat2 = true;
            polu2 = false;
            polu = false;
            shapes.Add(new CircleShape(myPen));
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }
        private void FillCircle_Click(object sender, EventArgs e)
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            istat2 = true;
            isStart = false;
            polu2 = false;
            polu = false;
            shapes.Add(new CircleShapeFill(solidBrush));
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }

        private void FILLPOLY_Click(object sender, EventArgs e)
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            polu = true;
            isStart = false;
            shapes.Add(new PolygonShape(myPen));
            istat2 = true;
            polu2 = false;
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }

        private void button1_Click_2(object sender, EventArgs e) //Fpoly
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            polu = true;
            shapes.Add(new PolygonShapeF(solidBrush));
            istat2 = true;
            polu2 = false;
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }

        private void button3_Click(object sender, EventArgs e) //Arc
        {
            DEL_NULL();
            idx.Clear();
            dragging = false;
            select = false;
            istat2 = true;
            polu2 = false;
            polu = false;
            shapes.Add(new ArcShape(myPen));
            this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
        }

        private void button2_Click(object sender, EventArgs e) //adjustcolor
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                myColor = selectedColor;
                myPen = new Pen(myColor, size);
                solidBrush = new SolidBrush(myColor);
                myPen.DashStyle = (System.Drawing.Drawing2D.DashStyle)this.comboBox1.SelectedItem;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int len = shapes.Count();
            if(len >=0 )
            {
                myPen = new Pen(myColor, size);
                myPen.DashStyle = (System.Drawing.Drawing2D.DashStyle)this.comboBox1.SelectedItem;
                //Console.WriteLine(shapes[len - 1].pen.DashStyle);
                //Console.WriteLine(shapes[len - 2].pen.DashStyle);
            }
        }

        private void SizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int len = shapes.Count();
            if (len >= 0)
            {
                size = Convert.ToInt32(this.SizeCombo.SelectedItem);
                myPen = new Pen(myColor, size);
                myPen.DashStyle = (System.Drawing.Drawing2D.DashStyle)this.comboBox1.SelectedItem;
            }
        }

        private void DEL_NULL()
        {
            if (shapes.Count() > 0)
                if (shapes[shapes.Count() - 1].startPoint.IsEmpty)
                {
                    this.Layers.Items.RemoveAt(shapes.Count() - 1);
                    shapes.RemoveAt(shapes.Count() - 1);
                }
        }

        private void SELECT_Click(object sender, EventArgs e)
        {
            idx.Clear();
            dragging = false;
            isStart = false;
            istat2 = false;
            polu2 = false;
            int len = this.Layers.Items.Count;
            for (int i = 0; i < len; i++)
                if (this.Layers.GetItemChecked(i))
                    idx.Add(i);
            if(idx.Count() > 0)
                select = true;
            Console.WriteLine(idx.Count);
        }

        private void SIZEUP_Click(object sender, EventArgs e)
        {
            if (idx.Count() > 0)
            {
                foreach (int i in idx)
                    shapes[i].pen.Width = size + 3;
                size += 3;
                this.panel1.Refresh();
            }
        }

        private void SIZEDW_Click(object sender, EventArgs e)
        {
            if (idx.Count() > 0)
            {
                int ck = size;
                ck -= 3;
                if (ck > 3)
                {
                    foreach (int i in idx)
                        shapes[i].pen.Width = size - 3;
                    size -= 3;
                    this.panel1.Refresh();
                }
            }
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (idx.Count() > 0)
            {
                idx.Sort();
                idx.Reverse();
                foreach (int i in idx)
                {
                    this.Layers.Items.RemoveAt(i);
                    shapes.RemoveAt(i); 
                }
                this.panel1.Refresh();
                idx.Clear();
            }
        }

        private void GROUP_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (idx.Count() > 1)
            {
                idx.Sort();
                idx.Reverse();
                foreach (int i in idx)
                    if (shapes[i].Name.Equals("Group"))
                        flag = false;
                if (flag == true)
                {
                    Group a = new Group(myPen, shapes, idx);
                    foreach (int i in idx)
                    {
                        this.Layers.Items.RemoveAt(i);
                        groups.Add(shapes[i]);
                        shapes.RemoveAt(i);
                    }
                    shapes.Add(a);
                    this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
                    idx.Clear();
                    this.panel1.Refresh();
                }
                else
                    MessageBox.Show("cannot group");
            }
            else
                MessageBox.Show("cannot ungroup or press select first");
        }

        private void UNGROUP_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (idx.Count() > 0)
            {
                idx.Sort();
                idx.Reverse();
                foreach (int i in idx)
                    if (!shapes[i].Name.Equals("Group"))
                        flag = false;
                if (flag == true)
                {
                    foreach (int i in idx)
                    {
                        this.Layers.Items.RemoveAt(i);
                        shapes.RemoveAt(i);
                    }
                    for (int i = groups.Count() - 1; i >= 0; i--)
                    {
                        shapes.Add(groups[i]);
                        this.Layers.Items.Add(Convert.ToString(shapes[shapes.Count() - 1].Name) + " " + shapes.Count());
                    }
                    groups.Clear();
                    idx.Clear();
                    this.panel1.Refresh();
                }
                else
                    MessageBox.Show("cannot ungroup");
            }
            else
                MessageBox.Show("cannot ungroup or press select first");
        }
    }
}

