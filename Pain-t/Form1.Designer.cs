
using System.Windows.Forms;

namespace Pain_tssq2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Line = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RecFr = new System.Windows.Forms.Button();
            this.FillRec = new System.Windows.Forms.Button();
            this.EllFr = new System.Windows.Forms.Button();
            this.EllFilled = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CircleFr = new System.Windows.Forms.Button();
            this.FillCircle = new System.Windows.Forms.Button();
            this.FILLPOLY = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SizeCombo = new System.Windows.Forms.ComboBox();
            this.Layers = new System.Windows.Forms.CheckedListBox();
            this.layerlabel = new System.Windows.Forms.Label();
            this.SELECT = new System.Windows.Forms.Button();
            this.SIZEUP = new System.Windows.Forms.Button();
            this.SIZEDW = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.GROUP = new System.Windows.Forms.Button();
            this.UNGROUP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(19, 33);
            this.Line.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(117, 53);
            this.Line.TabIndex = 0;
            this.Line.Text = "LINE";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 574);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 596);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // RecFr
            // 
            this.RecFr.Location = new System.Drawing.Point(141, 33);
            this.RecFr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecFr.Name = "RecFr";
            this.RecFr.Size = new System.Drawing.Size(115, 53);
            this.RecFr.TabIndex = 2;
            this.RecFr.Text = "RECTANGLE FRAME";
            this.RecFr.UseVisualStyleBackColor = true;
            this.RecFr.Click += new System.EventHandler(this.button1_Click);
            // 
            // FillRec
            // 
            this.FillRec.Location = new System.Drawing.Point(261, 33);
            this.FillRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FillRec.Name = "FillRec";
            this.FillRec.Size = new System.Drawing.Size(116, 53);
            this.FillRec.TabIndex = 3;
            this.FillRec.Text = "FILLED RECTANGLE";
            this.FillRec.UseVisualStyleBackColor = true;
            this.FillRec.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EllFr
            // 
            this.EllFr.Location = new System.Drawing.Point(383, 33);
            this.EllFr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EllFr.Name = "EllFr";
            this.EllFr.Size = new System.Drawing.Size(124, 53);
            this.EllFr.TabIndex = 0;
            this.EllFr.Text = "ELLIPSE FRAME";
            this.EllFr.UseVisualStyleBackColor = true;
            this.EllFr.Click += new System.EventHandler(this.EllFr_Click);
            // 
            // EllFilled
            // 
            this.EllFilled.Location = new System.Drawing.Point(512, 33);
            this.EllFilled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EllFilled.Name = "EllFilled";
            this.EllFilled.Size = new System.Drawing.Size(121, 53);
            this.EllFilled.TabIndex = 4;
            this.EllFilled.Text = "FILLED ELLIPSE";
            this.EllFilled.UseVisualStyleBackColor = true;
            this.EllFilled.Click += new System.EventHandler(this.EllFilled_Click);
            // 
            // CircleFr
            // 
            this.CircleFr.Location = new System.Drawing.Point(639, 33);
            this.CircleFr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CircleFr.Name = "CircleFr";
            this.CircleFr.Size = new System.Drawing.Size(119, 53);
            this.CircleFr.TabIndex = 5;
            this.CircleFr.Text = "CIRCLE FRAME";
            this.CircleFr.UseVisualStyleBackColor = true;
            this.CircleFr.Click += new System.EventHandler(this.CircleFr_Click);
            // 
            // FillCircle
            // 
            this.FillCircle.Location = new System.Drawing.Point(763, 33);
            this.FillCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FillCircle.Name = "FillCircle";
            this.FillCircle.Size = new System.Drawing.Size(116, 53);
            this.FillCircle.TabIndex = 0;
            this.FillCircle.Text = "FILLED CIRCLE";
            this.FillCircle.UseVisualStyleBackColor = true;
            this.FillCircle.Click += new System.EventHandler(this.FillCircle_Click);
            // 
            // FILLPOLY
            // 
            this.FILLPOLY.Location = new System.Drawing.Point(884, 33);
            this.FILLPOLY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FILLPOLY.Name = "FILLPOLY";
            this.FILLPOLY.Size = new System.Drawing.Size(115, 53);
            this.FILLPOLY.TabIndex = 6;
            this.FILLPOLY.Text = "POLYGON FRAME";
            this.FILLPOLY.UseVisualStyleBackColor = true;
            this.FILLPOLY.Click += new System.EventHandler(this.FILLPOLY_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1004, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "FILLED POLYGON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1129, 33);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "ARC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "ADJ COLOR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "PEN SETTING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "SELECTING SHAPE";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            System.Drawing.Drawing2D.DashStyle.Solid,
            System.Drawing.Drawing2D.DashStyle.Dash,
            System.Drawing.Drawing2D.DashStyle.Dot,
            System.Drawing.Drawing2D.DashStyle.DashDot,
            System.Drawing.Drawing2D.DashStyle.DashDotDot});
            this.comboBox1.Location = new System.Drawing.Point(142, 106);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "solid";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SizeCombo
            // 
            this.SizeCombo.FormattingEnabled = true;
            this.SizeCombo.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.SizeCombo.Location = new System.Drawing.Point(262, 106);
            this.SizeCombo.Name = "SizeCombo";
            this.SizeCombo.Size = new System.Drawing.Size(115, 24);
            this.SizeCombo.TabIndex = 15;
            this.SizeCombo.Text = "5";
            this.SizeCombo.SelectedIndexChanged += new System.EventHandler(this.SizeCombo_SelectedIndexChanged);
            // 
            // Layers
            // 
            this.Layers.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Layers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Layers.FormattingEnabled = true;
            this.Layers.Location = new System.Drawing.Point(1257, 149);
            this.Layers.Margin = new System.Windows.Forms.Padding(0);
            this.Layers.Name = "Layers";
            this.Layers.Size = new System.Drawing.Size(127, 580);
            this.Layers.TabIndex = 16;
            // 
            // layerlabel
            // 
            this.layerlabel.AutoSize = true;
            this.layerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.layerlabel.Location = new System.Drawing.Point(1276, 117);
            this.layerlabel.Name = "layerlabel";
            this.layerlabel.Size = new System.Drawing.Size(90, 25);
            this.layerlabel.TabIndex = 17;
            this.layerlabel.Text = "LAYERS";
            this.layerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SELECT
            // 
            this.SELECT.Location = new System.Drawing.Point(383, 106);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(124, 39);
            this.SELECT.TabIndex = 18;
            this.SELECT.Text = "SELECT";
            this.SELECT.UseVisualStyleBackColor = true;
            this.SELECT.Click += new System.EventHandler(this.SELECT_Click);
            // 
            // SIZEUP
            // 
            this.SIZEUP.Location = new System.Drawing.Point(512, 105);
            this.SIZEUP.Name = "SIZEUP";
            this.SIZEUP.Size = new System.Drawing.Size(121, 40);
            this.SIZEUP.TabIndex = 19;
            this.SIZEUP.Text = "SIZE UP";
            this.SIZEUP.UseVisualStyleBackColor = true;
            this.SIZEUP.Click += new System.EventHandler(this.SIZEUP_Click);
            // 
            // SIZEDW
            // 
            this.SIZEDW.Location = new System.Drawing.Point(639, 105);
            this.SIZEDW.Name = "SIZEDW";
            this.SIZEDW.Size = new System.Drawing.Size(119, 40);
            this.SIZEDW.TabIndex = 20;
            this.SIZEDW.Text = "SIZE DW";
            this.SIZEDW.UseVisualStyleBackColor = true;
            this.SIZEDW.Click += new System.EventHandler(this.SIZEDW_Click);
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(766, 105);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(113, 40);
            this.DEL.TabIndex = 21;
            this.DEL.Text = "DELETE";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // GROUP
            // 
            this.GROUP.Location = new System.Drawing.Point(886, 106);
            this.GROUP.Name = "GROUP";
            this.GROUP.Size = new System.Drawing.Size(113, 39);
            this.GROUP.TabIndex = 22;
            this.GROUP.Text = "GROUP";
            this.GROUP.UseVisualStyleBackColor = true;
            this.GROUP.Click += new System.EventHandler(this.GROUP_Click);
            // 
            // UNGROUP
            // 
            this.UNGROUP.Location = new System.Drawing.Point(1005, 105);
            this.UNGROUP.Name = "UNGROUP";
            this.UNGROUP.Size = new System.Drawing.Size(119, 39);
            this.UNGROUP.TabIndex = 23;
            this.UNGROUP.Text = "UNGROUP";
            this.UNGROUP.UseVisualStyleBackColor = true;
            this.UNGROUP.Click += new System.EventHandler(this.UNGROUP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 723);
            this.Controls.Add(this.UNGROUP);
            this.Controls.Add(this.GROUP);
            this.Controls.Add(this.DEL);
            this.Controls.Add(this.SIZEDW);
            this.Controls.Add(this.SIZEUP);
            this.Controls.Add(this.SELECT);
            this.Controls.Add(this.layerlabel);
            this.Controls.Add(this.Layers);
            this.Controls.Add(this.SizeCombo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FILLPOLY);
            this.Controls.Add(this.FillCircle);
            this.Controls.Add(this.CircleFr);
            this.Controls.Add(this.EllFilled);
            this.Controls.Add(this.EllFr);
            this.Controls.Add(this.FillRec);
            this.Controls.Add(this.RecFr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Line);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RecFr;
        private System.Windows.Forms.Button FillRec;
        private System.Windows.Forms.Button EllFr;
        private System.Windows.Forms.Button EllFilled;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button CircleFr;
        private System.Windows.Forms.Button FillCircle;
        private System.Windows.Forms.Button FILLPOLY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox SizeCombo;
        private System.Windows.Forms.CheckedListBox Layers;
        private System.Windows.Forms.Label layerlabel;
        private System.Windows.Forms.Button SELECT;
        private Button SIZEUP;
        private Button SIZEDW;
        private Button DEL;
        private Button GROUP;
        private Button UNGROUP;
    }
}

