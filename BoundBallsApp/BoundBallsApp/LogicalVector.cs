using System;

namespace BoundBallsApp
{
    public class LogicalVector : IEquatable<LogicalVector>
    {
        private readonly double _x;
        private readonly double _y;

        public LogicalVector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public float X => (float) _x;
        public float Y => (float) _y;

        public LogicalVector Add(LogicalVector v1, LogicalVector v2)
        {
            return new LogicalVector(v1._x + v2._x, v1._y + v2._y);
        }

        public LogicalVector Multiply(double multiply)
        {
            return new LogicalVector(_x * multiply, _y * multiply);
        }

        public LogicalVector GetInvert()
        {
            return Multiply(-1);
        }

        public double Dot(LogicalVector targetVector)
        {
            return _x * targetVector._x + _y * targetVector._y;
        }

        public bool Equals(LogicalVector other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _x.Equals(other._x) && _y.Equals(other._y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((LogicalVector) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_x.GetHashCode() * 397) ^ _y.GetHashCode();
            }
        }
    }
}