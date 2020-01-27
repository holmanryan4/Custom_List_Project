using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{


    public class CustomList<T>
    {

        //Member Variables (HAS A)
        T[] items;
        public int Count;
        public int Capacity;
        //Indexer

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;

            }
        }

        //Constructor
        public CustomList()
        {
            Count = 0;
            Capacity = 4;
            items = new T[Capacity];


        }

        //Member Methods (CAN DO)
        public void Add(T itemToAdd)
        {
            if (Count == Capacity)
            {
                Capacity = Capacity * 2;
                T[] temp = new T[Capacity];

                for (int i = 0; i < Count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }

            items[Count] = itemToAdd;
            Count++;

        }
        public void Remove(T itemToRemove)
        {
          

            for (int i = 0; i < Count; i++)
            {
                if (Equals(items[i], itemToRemove))
                {
                    Count--;
                    break;
                }
                //else if (!Equals(items[i], itemToRemove))
                //{
                    
                //}

                
            }
            for (int i = 0; i < Count; i++)
            {
                if (Equals(itemToRemove, items[i]))
                {
                    T[] temp = new T[Capacity];
                    for (int j = 0; j < Count; j++)
                    {
                        temp[j] = items[i+1];
                    }
                    items = temp;
                }
            }
            
            //if (!Equals(Count, itemToRemove))
            //{

            //    T[] temp = new T[Capacity];

            //    for (int i = 0; i > Count; i++)
            //    {
            //        temp[0] = items[1];
            //    }
            //}






        }

    }
}
