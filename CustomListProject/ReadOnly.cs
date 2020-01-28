using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public sealed class ReadOnly
    {
        private readonly CustomList<object> _items = new CustomList<object>();
        public IEnumerator<object> Items
        {
            get
            {
                foreach(int item in this._items)
                {
                    yield return Items;
                }
            }
        }
    }
}
