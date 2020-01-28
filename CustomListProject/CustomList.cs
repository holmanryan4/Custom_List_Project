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

        //public int Count { get { return Count; } }
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

            for (int i = 0; i < Count; i++)
            {
                if (Equals(items[i], itemToRemove))
                {
                    Count--;
                    break;
                }

            }
            for (int i = 0; i < Count; i++)
            {
                T[] temp = new T[Capacity];
                if (Equals(itemToRemove, items[i]))
                {
                    items[i] = items[i + 1];

                    for (int j = 0; j < Count; j++)
                    {
                        temp[j] = items[j + 1];

                    }
                    items = temp;
                    items[Count] = itemToRemove;

                }
                else
                {
                    temp[i] = items[i];
                }
                if (removed)
                {
                    Count--;
                    items = temp;
                }
            }

            return removed;

        }

       
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return items[i];
            }
            yield return "No more items in list";
        }
        
        

        public override string ToString()
        {
            //StringBuilder toString = new StringBuilder();
            
            return base.ToString();
        }
        public static CustomList<T> operator+ (CustomList<T> odd, CustomList<T> even)
        {
            CustomList<T> Zipper = new CustomList<T>();
            for (int i = 0; i < odd.Count; i++)
            {
                Zipper.Add(odd[i]);

            }
            for (int i = 0; i < even.Count; i++)
            {
                Zipper.Add(even[i]);
            }
            return Zipper;
        }
        public static CustomList<T> operator- (CustomList<T> odd, CustomList<T> even)
        {
            CustomList<T> Zipper = new CustomList<T>();
            for (int i = 0; i < odd.Count; i++)
            {
                Zipper.Remove(odd[i]);

            }
            for (int i = 0; i < even.Count; i++)
            {
                Zipper.Remove(even[i]);
            }
            return Zipper;
        }

    }
    
}

    

