using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5._4
{
    class Program
    {
        class Sort_Table
        { 
            public void Read_Data(double[] tabl, int size)
            {
                int i;
                for(i = 0; i<size; i++)
                {
                    Console.WriteLine("Proszę podać liczbę nr {0}", i + 1);
                    tabl[i] = double.Parse(Console.ReadLine());
                }
            }
            public void Process_Data(double[] tabl, int size)
            {
                double swit = 0;
                int n = size;
                do
                {
                    for (int i = 1; i < size; i++)
                    {
                        if (tabl[i - 1] > tabl[i])
                        {
                            swit = tabl[i - 1];
                            tabl[i - 1] = tabl[i];
                            tabl[i] = swit;
                        }
                    }
                    n--;
                } while (n > 1);
            }
            public void View_Data(double[] tabl, int size)
            {
               
                Console.WriteLine("Program sortuje liczby podane do tablicy metodą sortowania bąelkowego.");
                Console.WriteLine("Oto posortowane liczby:");
                for(int i = 0; i < size; i++)
                {
                    Console.Write(tabl[i] + ", ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int size = 6;
            double[] tabl = new double[size];

            Sort_Table Table = new Sort_Table();

            Table.Read_Data(tabl, size);
            Table.Process_Data(tabl, size);
            Table.View_Data(tabl, size);

            Console.WriteLine("Naciśnij dowolny klawisz.");
            Console.ReadKey();

        }
    }
}
