using System;
using System.Collections.Generic;

namespace BlazorFlow.Models
{
    public class HashSetComparable<T> : HashSet<T>, IComparable<HashSet<T>>
    {
        public HashSetComparable() {}

        public HashSetComparable(IEnumerable<T> collection) : base(collection) {}

        public int CompareTo (HashSet<T>? hashSet)
        {
            if (hashSet is {} existing)
            {
                return SetEquals(existing) ? 0 : -1;
            }
            else {
                return -1;
            }
        }
    }
}
