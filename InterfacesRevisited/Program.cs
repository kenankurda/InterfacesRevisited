using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator(); //instance of Calculator class

            ICalculator calculator = new Calculator(); //instance of ICalculator interface


            calculator.Add(10, 2);
            calculator.Substract(10, 2);
            calculator.Multiply(10, 2);
            calculator.Divide(4, 2);
            //calculator.show();

        }
    }

    public interface ICalculator
    {
        void Add(int x, int y);
        void Substract(int x, int y);
        void Multiply(int a, int b);
        void Divide(int z, int r);
    }

    public class Calculator:ICalculator
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x+y);
        }

        public void Divide(int z, int r)
        {
            Console.WriteLine(z/r);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        public void Substract(int x, int y)
        {
            Console.WriteLine(x-y);
        }
        public void show()
        {
            Console.WriteLine("Hello Interface");
        }
    }

}
