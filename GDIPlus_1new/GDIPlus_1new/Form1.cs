using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace GDIPlus_1new
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
            Image image = Image.FromFile("G:\\Paweena185.png");
            TextureBrush brush = new TextureBrush(image);
            Rectangle rect = new Rectangle(10, 10,380, 350);
            g.FillEllipse(brush, rect);
            g.Dispose();

        }
    }
}
