using System;

namespace BlazorFlow.Helpers
{
    public static class OperationHelper
    {
        public static Func<T, T, bool> LessThan<T>() where T : IComparable => delegate (T lhs, T rhs) { return lhs.CompareTo(rhs) < 0; };
        public static Func<T, T, bool> LessThanOrEqualTo<T>() where T : IComparable => delegate (T lhs, T rhs) { return lhs.CompareTo(rhs) <= 0; };
        public static Func<T, T, bool> EqualTo<T>() where T : IComparable => delegate (T lhs, T rhs) { return lhs.CompareTo(rhs) == 0; };
        public static Func<T, T, bool> GreaterThan<T>() where T : IComparable => delegate (T lhs, T rhs) { return lhs.CompareTo(rhs) > 0; };
        public static Func<T, T, bool> GreaterThanOrEqualTo<T>() where T : IComparable => delegate (T lhs, T rhs) { return lhs.CompareTo(rhs) >= 0; };
    }
}
