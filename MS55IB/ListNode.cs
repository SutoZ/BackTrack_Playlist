using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS55IB
{
    class ListNode<T>
    {
        T tartalom;

        public T Tartalom
        {
            get { return tartalom; }
            set { tartalom = value; }
        }
        ListNode<T> next;

        public ListNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }
        public ListNode(ListNode<T> next)
        {
            this.tartalom = default(T);
            this.next = next;
        }
    }
}
