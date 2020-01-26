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
        public int Count = 0;
        public int Capacity = 4;
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
            items = new T[Capacity];
        }

        //Member Methods (CAN DO)
        public void Add(T itemToAdd)
        {
            
            items[0] = itemToAdd;

            if(Count == Capacity)
            {
                items = new T[Capacity * 2];
            }
        }
        public void Remove(T itemToRTemove)
        {
            
        }

    }
}
