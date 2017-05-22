using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.IO;

namespace Proekt
{
    public partial class Form1 : Form
    {
        GameDoc GameDoc;
        bool first = true;
        public Form1()
        {
            InitializeComponent();
            GameDoc = new GameDoc();
            DoubleBuffered = true;
            Timer t = new Timer();
            t.Tick += T_Tick;
            t.Interval = 100;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            pbCrocodile.Location = new Point(pbCrocodile.Location.X - 10, pbCrocodile.Location.Y);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        
            
        }

        private void pbCrocodile_Paint(object sender, PaintEventArgs e)
        {
            if (first)
            {

                Bitmap bmp = new Bitmap(pbCrocodile.Width, pbCrocodile.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    Brush b = new SolidBrush(Color.White);
                    g.DrawString("LALALA", new Font("Calibri", 23, FontStyle.Bold), b, 200, 200);
                    b.Dispose();
                }
                pbCrocodile.Image = bmp;
                first = false;
            }
        }
    }
}
