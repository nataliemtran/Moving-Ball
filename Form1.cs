using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalPartA_Problem2
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;

        public Form1()
        {
            InitializeComponent();
            Paint += Game_Paint;
            x = 60;
            y = 170;
        }
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Font drawFont = new Font("Times New Roman Black", 12);

            // pen and brush
            Pen blackPen = new Pen(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);

            // start and end
            Point startpoint = new Point(3, 210);
            Point endpoint = new Point(250, 210);
            g.DrawString("Start", drawFont, blackBrush, startpoint);
            g.DrawString("End", drawFont, redBrush, endpoint);

            // pond
            Point pondpoint = new Point(125, 120);
            g.FillEllipse(blueBrush, 100, 60, 100, 150);
            g.DrawString("Pond", drawFont, whiteBrush, pondpoint);

            // orange ball
            g.FillEllipse(orangeBrush, x, y, 30, 30);
            
            // Vertical Lines
            g.DrawLine(blackPen, 50, 10, 50, 210);
            g.DrawLine(blackPen, 100, 10, 100, 210);
            g.DrawLine(blackPen, 150, 10, 150, 210);
            g.DrawLine(blackPen, 200, 10, 200, 210);
            g.DrawLine(blackPen, 250, 10, 250, 210);

            // Horizontal Lines
            g.DrawLine(blackPen, 50, 10, 250, 10);
            g.DrawLine(blackPen, 50, 60, 250, 60);
            g.DrawLine(blackPen, 50, 110, 250, 110);
            g.DrawLine(blackPen, 50, 160, 250, 160);
            g.DrawLine(blackPen, 50, 210, 250, 210);
            
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int newpos = 0;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    {
                        newpos = x - 50;

                        if ((x >= 200 && y >= 60 && newpos <= 200) || (newpos <= 50))
                        {
                            MessageBox.Show("You cannot go in that direction!");
                        }
                        else { x -= 50; }
                        break;
                    }
                case Keys.Right:
                    {
                        newpos = x + 50;

                        if ((x <= 100 && y >= 60 && newpos >= 100) || (newpos >= 250))
                        {
                            MessageBox.Show("You cannot go in that direction!");
                        }
                        else { x += 50; }
                        break;
                    }

                case Keys.Up:
                    {
                        newpos = y - 50;

                        if (newpos <= 10)
                        {
                            MessageBox.Show("You cannot go in that direction!");
                        }
                        else { y -= 50; }
                        break;
                    }
                case Keys.Down:
                    {
                        newpos = y + 50;

                        if (((x >= 100 && x <= 200) && newpos >= 60 && y <= 60) || (newpos >= 210))
                        {
                            MessageBox.Show("You cannot go in that direction!");
                        }
                        else { y += 50; }
                        break;
                    }
            }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
