using ListInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List(6);
            list.InsertAtIndex(12, 0);
            list.InsertAtIndex(333, 4);
            list.PrintElements();
            list.DeleteElementAtIndex(3);
            list.PrintElements();
            list.GetElementAtIndex(4);


        }
    }
}
