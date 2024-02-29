using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int map(int value, int fromLow, int fromHigh, int toLow, int toHigh) { //stolen mapping function
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }

        void fluctuateValue(Star star, int value, int period, int minVal, int maxVal) {
            float kVal = (2 * Math.PI) / period;

            value = map (Math.Sin(kVal * 0)pp)
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Pen blackPen = new Pen(Color.Black);

            Point point = new Point((this.Width - 100) /  2, (this.Height - 100) / 2);

            Star testStar = new Star(point, 100, 15, 50);

            testStar.SetPoints();

            PointF[] testStarPts = testStar.starPoints;


            e.Graphics.DrawPolygon(blackPen, testStarPts);
        }
    }
}
