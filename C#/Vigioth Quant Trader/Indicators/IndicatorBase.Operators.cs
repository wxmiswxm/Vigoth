﻿

namespace VigiothCapital.QuantTrader.Indicators
{

    public abstract partial class IndicatorBase<T>
    {
        /// <summary>
        /// Returns the current value of this instance
        /// </summary>
        /// <param name="instance">The indicator instance</param>
        /// <returns>The current value of the indicator</returns>
        public static implicit operator decimal(IndicatorBase<T> instance)
        {
            return instance.Current;
        }

        /// <summary>
        /// Determines if the indicator's current value is greater than the specified value
        /// </summary>
        public static bool operator >(IndicatorBase<T> left, double right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value > (decimal)right;
        }

        /// <summary>
        /// Determines if the indicator's current value is less than the specified value
        /// </summary>
        public static bool operator <(IndicatorBase<T> left, double right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value < (decimal)right;
        }

        /// <summary>
        /// Determines if the specified value is greater than the indicator's current value
        /// </summary>
        public static bool operator >(double left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left > right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is less than the indicator's current value
        /// </summary>
        public static bool operator <(double left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left < right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is greater than or equal to the specified value
        /// </summary>
        public static bool operator >=(IndicatorBase<T> left, double right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value >= (decimal)right;
        }

        /// <summary>
        /// Determines if the indicator's current value is less than or equal to the specified value
        /// </summary>
        public static bool operator <=(IndicatorBase<T> left, double right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value <= (decimal)right;
        }

        /// <summary>
        /// Determines if the specified value is greater than or equal to the indicator's current value
        /// </summary>
        public static bool operator >=(double left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left >= right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is less than or equal to the indicator's current value
        /// </summary>
        public static bool operator <=(double left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left <= right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is equal to the specified value
        /// </summary>
        public static bool operator ==(IndicatorBase<T> left, double right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value == (decimal)right;
        }

        /// <summary>
        /// Determines if the indicator's current value is not equal to the specified value
        /// </summary>
        public static bool operator !=(IndicatorBase<T> left, double right)
        {
            if (ReferenceEquals(left, null)) return true;
            return left.Current.Value != (decimal)right;
        }

        /// <summary>
        /// Determines if the specified value is equal to the indicator's current value
        /// </summary>
        public static bool operator ==(double left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left == right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is not equal to the indicator's current value
        /// </summary>
        public static bool operator !=(double left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return true;
            return (decimal)left != right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is greater than the specified value
        /// </summary>
        public static bool operator >(IndicatorBase<T> left, float right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value > (decimal)right;
        }

        /// <summary>
        /// Determines if the indicator's current value is less than the specified value
        /// </summary>
        public static bool operator <(IndicatorBase<T> left, float right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value < (decimal)right;
        }

        /// <summary>
        /// Determines if the specified value is greater than the indicator's current value
        /// </summary>
        public static bool operator >(float left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left > right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is less than the indicator's current value
        /// </summary>
        public static bool operator <(float left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left < right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is greater than or equal to the specified value
        /// </summary>
        public static bool operator >=(IndicatorBase<T> left, float right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value >= (decimal)right;
        }

        /// <summary>
        /// Determines if the indicator's current value is less than or equal to the specified value
        /// </summary>
        public static bool operator <=(IndicatorBase<T> left, float right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value <= (decimal)right;
        }

        /// <summary>
        /// Determines if the specified value is greater than or equal to the indicator's current value
        /// </summary>
        public static bool operator >=(float left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left >= right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is less than or equal to the indicator's current value
        /// </summary>
        public static bool operator <=(float left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left <= right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is equal to the specified value
        /// </summary>
        public static bool operator ==(IndicatorBase<T> left, float right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value == (decimal)right;
        }

        /// <summary>
        /// Determines if the indicator's current value is not equal to the specified value
        /// </summary>
        public static bool operator !=(IndicatorBase<T> left, float right)
        {
            if (ReferenceEquals(left, null)) return true;
            return left.Current.Value != (decimal)right;
        }

        /// <summary>
        /// Determines if the specified value is equal to the indicator's current value
        /// </summary>
        public static bool operator ==(float left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return (decimal)left == right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is not equal to the indicator's current value
        /// </summary>
        public static bool operator !=(float left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return true;
            return (decimal)left != right.Current.Value;
        }
        /// <summary>
        /// Determines if the indicator's current value is greater than the specified value
        /// </summary>
        public static bool operator >(IndicatorBase<T> left, int right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value > right;
        }

        /// <summary>
        /// Determines if the indicator's current value is less than the specified value
        /// </summary>
        public static bool operator <(IndicatorBase<T> left, int right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value < right;
        }

        /// <summary>
        /// Determines if the specified value is greater than the indicator's current value
        /// </summary>
        public static bool operator >(int left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left > right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is less than the indicator's current value
        /// </summary>
        public static bool operator <(int left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left < right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is greater than or equal to the specified value
        /// </summary>
        public static bool operator >=(IndicatorBase<T> left, int right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value >= right;
        }

        /// <summary>
        /// Determines if the indicator's current value is less than or equal to the specified value
        /// </summary>
        public static bool operator <=(IndicatorBase<T> left, int right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value <= right;
        }

        /// <summary>
        /// Determines if the specified value is greater than or equal to the indicator's current value
        /// </summary>
        public static bool operator >=(int left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left >= right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is less than or equal to the indicator's current value
        /// </summary>
        public static bool operator <=(int left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left <= right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is equal to the specified value
        /// </summary>
        public static bool operator ==(IndicatorBase<T> left, int right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value == right;
        }

        /// <summary>
        /// Determines if the indicator's current value is not equal to the specified value
        /// </summary>
        public static bool operator !=(IndicatorBase<T> left, int right)
        {
            if (ReferenceEquals(left, null)) return true;
            return left.Current.Value != right;
        }

        /// <summary>
        /// Determines if the specified value is equal to the indicator's current value
        /// </summary>
        public static bool operator ==(int left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left == right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is not equal to the indicator's current value
        /// </summary>
        public static bool operator !=(int left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return true;
            return left != right.Current.Value;
        }
        /// <summary>
        /// Determines if the indicator's current value is greater than the specified value
        /// </summary>
        public static bool operator >(IndicatorBase<T> left, long right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value > right;
        }

        /// <summary>
        /// Determines if the indicator's current value is less than the specified value
        /// </summary>
        public static bool operator <(IndicatorBase<T> left, long right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value < right;
        }

        /// <summary>
        /// Determines if the specified value is greater than the indicator's current value
        /// </summary>
        public static bool operator >(long left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left > right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is less than the indicator's current value
        /// </summary>
        public static bool operator <(long left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left < right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is greater than or equal to the specified value
        /// </summary>
        public static bool operator >=(IndicatorBase<T> left, long right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value >= right;
        }

        /// <summary>
        /// Determines if the indicator's current value is less than or equal to the specified value
        /// </summary>
        public static bool operator <=(IndicatorBase<T> left, long right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value <= right;
        }

        /// <summary>
        /// Determines if the specified value is greater than or equal to the indicator's current value
        /// </summary>
        public static bool operator >=(long left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left >= right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is less than or equal to the indicator's current value
        /// </summary>
        public static bool operator <=(long left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left <= right.Current.Value;
        }

        /// <summary>
        /// Determines if the indicator's current value is equal to the specified value
        /// </summary>
        public static bool operator ==(IndicatorBase<T> left, long right)
        {
            if (ReferenceEquals(left, null)) return false;
            return left.Current.Value == right;
        }

        /// <summary>
        /// Determines if the indicator's current value is not equal to the specified value
        /// </summary>
        public static bool operator !=(IndicatorBase<T> left, long right)
        {
            if (ReferenceEquals(left, null)) return true;
            return left.Current.Value != right;
        }

        /// <summary>
        /// Determines if the specified value is equal to the indicator's current value
        /// </summary>
        public static bool operator ==(long left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return false;
            return left == right.Current.Value;
        }

        /// <summary>
        /// Determines if the specified value is not equal to the indicator's current value
        /// </summary>
        public static bool operator !=(long left, IndicatorBase<T> right)
        {
            if (ReferenceEquals(right, null)) return true;
            return left != right.Current.Value;
        }
    }
}