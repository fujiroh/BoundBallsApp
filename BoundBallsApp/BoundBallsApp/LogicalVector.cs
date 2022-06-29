using System;
using System.Globalization;

namespace BoundBallsApp
{
    public class LogicalVector : IEquatable<LogicalVector>
    {
        private readonly float _x;
        private readonly float _y;

        public LogicalVector(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public float X => _x;
        public float Y => _y;

        public LogicalVector Add(LogicalVector v1)
        {
            return new LogicalVector(v1._x + _x, v1._y + _y);
        }

        public LogicalVector Multiply(float multiply)
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

        public override string ToString()
        {
            return "X:" + _x + " " + "Y:" + _y;
        }
    }
}