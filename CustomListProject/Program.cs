using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> customListOne = new CustomList<string>() { "1", "2", "3" };
            customListOne.Add("7");
            customListOne.Add("4");
            customListOne.Add("2");
            customListOne.Remove("2");
            Console.WriteLine(customListOne.Count);
            Console.ReadLine();
            customListOne.ToString();

        }

    }
}
