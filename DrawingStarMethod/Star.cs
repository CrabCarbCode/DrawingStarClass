using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingStarMethod {

    public class Star {
        Pen starPen;

        PointF centerPoint = new PointF();

        int numOfAxes, radiusDelta, size;

        double angleDelta;

        public PointF[] starPoints;

        public Star (PointF _centerPoint, int _size, int _numOfAxes, int _radiusDelta) {

            centerPoint = _centerPoint;
            size = _size;
            numOfAxes = _numOfAxes;
            radiusDelta = _radiusDelta;

            starPoints = new PointF[numOfAxes * 2];

            angleDelta = (2 * Math.PI) / numOfAxes;
        }

        public void SetPoints() {

            double angleOffset = 0; // could be used to make star spin

            for (int j = 0; j < (numOfAxes * 2); j++) { //not sure why just "j % 2" doesn't work, it should return only 1 or 0
                double usedRadius = ((j % 2) == 0) ? size : size - radiusDelta;

                starPoints[j] = new PointF(centerPoint.X + (float)(usedRadius * Math.Cos(j * angleDelta + angleOffset)), centerPoint.Y + (float)(usedRadius * Math.Sin(j * angleDelta + angleOffset)));
            }
        }

        public void DrawStar(Pen _starPen) {

            starPen = _starPen;

            //need to figure out syntax for drawing in-class

        }
    }
}
