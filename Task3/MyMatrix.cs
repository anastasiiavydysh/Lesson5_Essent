using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class MyMatrix
    {
        public int NumStrings { get; set; }
        public int NumColumns { get; set; }

        public MyMatrix(int numStrings, int numColumns)
        {
            NumColumns = numColumns;
            NumStrings = numStrings;
        }

        public void EditNumColumnsStrings(int numStrings, int numColumns)
        {
            NumColumns = numColumns;
            NumStrings = numStrings;
        }

        public void Display()
        {
            for (int i = 0; i < NumStrings; i++)
            {
                for (int j = 0; j < NumColumns; j++)
                    Console.Write("1 ");
                Console.WriteLine();
            }
        }
        public void DisplayDifferentOrders()
        {
            if (NumStrings == NumColumns)
            {
                for (int s = NumStrings, c = NumColumns; s > 0 && c>0; s--, c--)
                {
                        for (int i = 0; i < s; i++)
                        {
                            for (int j = 0; j < c; j++)
                                Console.Write("1 ");
                            Console.WriteLine();
                        }                     
                    Console.WriteLine("\n");
                }
            }
            else
                Console.WriteLine("Impossible display other matrix's order. It can be only when number of columns = number of strings.");
        }
    }
}
