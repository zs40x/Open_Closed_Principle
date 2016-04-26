
using System;

namespace Open_Closed_Principle.Shared
{
    public class Temperature : IEquatable<Temperature>
    {
        public Temperature(double value, TemperatureUnit unit)
        {
            Value = value;
            Unit = unit;
        }

        public double Value { get; }

        public TemperatureUnit Unit { get; }

        public static Temperature operator +(Temperature lhs, Temperature rhs)
        {
            if(lhs.Unit != rhs.Unit)
                throw new InvalidOperationException();

            return new Temperature(lhs.Value + rhs.Value, lhs.Unit);
        }


        public override bool Equals(object other)
        {
            if (ReferenceEquals(other, null))
                return false;
            if (ReferenceEquals(other, this))
                return true;
            if (GetType() != other.GetType())
                return false;
            return Equals(other as Temperature);
        }

        private double _epsilon = 0;
        private bool _isEpsilonPrecalculated = false;

        public bool Equals(Temperature other)
        {
            if(!_isEpsilonPrecalculated)
                _epsilon = Math.Max(Math.Abs(other.Value), Math.Abs(Value)) * 1E-15;

            if (Math.Abs(other.Value - Value) < _epsilon && other.Unit == Unit)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Value.GetHashCode() + Unit.GetHashCode()).GetHashCode();
        }
    }
}
