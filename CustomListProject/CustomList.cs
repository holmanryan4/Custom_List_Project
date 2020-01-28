using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{


    public class CustomList<T> : IEnumerable
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
        public bool Remove(T itemToRemove)
        { 

            bool removed = false;
            T[] temp = new T[Capacity];

            int j = 0;
            for (int i = j; i < Count; i++)
            {
                if (Equals(items[i], itemToRemove) && (i == j))
                {
                    removed = true;
                }
                else
                {
                   
                    temp[j] = items[i];
                    j++;
                }
                if (removed)
                {
                    
                    Count--;
                    items = temp;
                }
                for (int i = 0; i < Count; i++)
                {
                    if (Equals(items[i], itemToRemove))
                    {
                        Count--;
                        break;
                    }

                }
                return removed;

        }
        //public CustomList<T> Zipper(CustomList<T> ListToZip)
        //{

        //}
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }
        

    }


     //for (int i = 0; i<Count; i++)
     //       {
     //           if (Equals(items[i], itemToRemove))
     //           {
     //               Count--;
     //               break;
     //           }
                

                
     //       }
     //       for (int i = 0; i<Count; i++)
     //       {
                
     //           if (Equals(itemToRemove, items[i]))
     //           {
     //               items[i] = items[i + 1];
     //               T[] temp = new T[Capacity];
     //               for (int j = 0; j<Count; j++)
     //               {
     //                   temp[j] = items[j + 1];
                        
     //               }
     //               items = temp;
     //               items[Count] = itemToRemove;
     //              Count--;
     //           }
     //       }
            
}

