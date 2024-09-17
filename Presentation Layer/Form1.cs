using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 
            SolidBrush b1 = new SolidBrush(Color.Aquamarine);
            g.FillEllipse(b1, 40, 40, 80, 80);

            HatchBrush b2 = new HatchBrush(HatchStyle.ZigZag, Color.Red);
            g.FillEllipse(b2, 80, 80, 80, 80);
        }
    }
}
