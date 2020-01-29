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

        //public int count { get { return count; } }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        int count;
        int capacity;
        
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
            count = 0;
            capacity = 4;
            items = new T[capacity];





        }

        //Member Methods (CAN DO)
        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                T[] temp = new T[capacity];

                for (int i = 0; i < Count; i++)
                {
                    temp[i] = items[i];
                }
                items = temp;
            }

            items[count] = itemToAdd;
            count++;

        }
        public bool Remove(T itemToRemove)
        {   
            T[] temp = new T[capacity];

            bool removed = CheckForRemoval(itemToRemove);
            if (removed == true)
            {
                for (int i = 0, t = 0; i < count; i++, t++)
                {

                    if (Equals(itemToRemove, items[i]))
                    {
                        i++;
                        temp[t] = items[i];
                    }
                    else
                    {
                        temp[t] = items[i];
                    }
                }
                count--;
                items = temp;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Not today satan");
            }
            return removed;
        }
        bool CheckForRemoval(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
            {
                if (Equals(itemToRemove, items[i]))
                {
                    return true;
                }
            }
            return false;
        }
        

       
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
            yield return "No more items in list";
        }
        
        

        public override string ToString()
        {
            
            
            return base.ToString();
        }
        public static CustomList<T> operator+ (CustomList<T> odd, CustomList<T> even)
        {
       
            CustomList<T> Zipper = new CustomList<T>();
            for (int i = 0; i < odd.count; i++)
            {
                Zipper.Add(odd[i]);

            }
            for (int i = 0; i < even.count; i++)
            {
                Zipper.Add(even[i]);
            }
            return Zipper;
        }
        public static CustomList<T> operator- (CustomList<T> odd, CustomList<T> even)
        {
            CustomList<T> Zipper = new CustomList<T>();
            for (int i = 0; i < odd.count; i++)
            {
                Zipper.Remove(odd[i]);

            }
            for (int i = 0; i < even.count; i++)
            {
                Zipper.Remove(even[i]);
            }
            return Zipper;
        }

    }
    
}

    

