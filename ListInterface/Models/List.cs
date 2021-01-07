using ListInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInterface.Models
{
    public class List : Ilist
    {
        private int[] _array;
        private int _size;

        public List(int size)
        {
            _array = new int[size];
            _size = size;
        }
        public void DeleteElementAtIndex(int index)
        {
            if (index < 0 || index > _size)
            {
                Console.WriteLine("The element is out of Range");
            }
            else
            {
                _array[index] = -999999;
            }
        }

        public int GetElementAtIndex(int index)
        {
            if (index < 0 || index >= _size)
            {
                Console.WriteLine("The element you are looking for does not exists");
                return 999999;
            }
            else
            {
                Console.WriteLine("____________");
                Console.WriteLine(_array[index]);
                return _array[index];
            }
        }

        public void InsertAtIndex(int element, int index)
        {
            if (index < 0 || index >= _size)
            {
                Console.WriteLine("You cannot insert in this position");
            }
            else
            {
                 _array[index] = element;
            }
        }

        public void PrintElements()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
