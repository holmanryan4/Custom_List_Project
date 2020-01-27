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
                items = new T[Capacity];
            }
         
            items[Count] = itemToAdd;
            Count++;  
            
        }
        public void Remove(T itemToRemove)
        {
           

            for (int i = 0; i <= Capacity; i--)
            {
                items[Count] =itemToRemove;
            }

           
            
            Count--;
            
        }

    }
}
