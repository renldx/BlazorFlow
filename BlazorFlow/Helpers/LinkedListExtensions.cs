using System.Collections.Generic;

namespace BlazorFlow.Helpers
{
    public static class LinkedListExtensions
    {
        public static IEnumerable<LinkedListNode<T>> Nodes<T>(this LinkedList<T> list)
        {
            for (var node = list.First; node != null; node = node.Next)
            {
                yield return node;
            }
        }
    }
}
