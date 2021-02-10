using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<A>//
    {
        A[] items;
        //constructor

        public MyList()
        {
            items = new A[0];

        }
        public void Add(A Item)
        {
            A[] tempArray = items;
            items = new A[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = Item;

        }
        public int Length
        {
            get { return items.Length; }
        }

        public IEnumerable<object> Item { get; internal set; }
    }
}
