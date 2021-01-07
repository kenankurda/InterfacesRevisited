using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInterface.Interfaces
{
    public interface Ilist
    {
        void InsertAtIndex(int element, int index);
        int GetElementAtIndex(int index);
        void PrintElements();
        void DeleteElementAtIndex(int index);
    }
}
