using System;
using System.Drawing;

namespace BoundBallsApp
{
    public class BoundBall
    {
        private const int Radius = 20;

        private PointF _centerPoint;
        private readonly Color _ballColor = Color.Aqua;

        public BoundBall(PointF centerPoint)
        {
            _centerPoint = centerPoint;
        }

        public void Move(LogicalVector vector)
        {
            _centerPoint.X += vector.X;
            _centerPoint.X += vector.Y;
        }

        public void Draw(Graphics graphics)
        {
            using (var pens = new Pen(Color.Black))
            using (var brush = new SolidBrush(_ballColor))
            {
                var rectangleF = GetRectangleF();
                graphics.FillEllipse(brush, rectangleF);
                graphics.DrawEllipse(pens, rectangleF);
            }
        }

        private RectangleF GetRectangleF()
        {
            var leftUp = new PointF(_centerPoint.X - Radius, _centerPoint.Y - Radius);
            var sizeF = new SizeF(2 * Radius, 2 * Radius);
            return new RectangleF(leftUp, sizeF);
        }
    }
}