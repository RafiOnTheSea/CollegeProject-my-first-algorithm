using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[7];
            double[] array2 = new double[7];
            int x = 0;
            string ende = "";
            do
            {
                ende = "ja";

                Console.WriteLine("1.von groß nach klein 2.von klein nach groß");
                x = Convert.ToInt32(Console.ReadLine());

                for (int index = 0; index <= 6; index++)
                {
                    Console.WriteLine(" geben sie ihr zahl ein. " + index + " von 7");
                    array[index] = Convert.ToDouble(Console.ReadLine());
                    array2[index] = array[index];
                    Console.Clear();
                }
                
                //alg
                if (x == 1)
                {
                    double temp;
                    for (int loop = 0; loop <= 5; loop++)
                    {
                        for ( int index = 1; index <= 6; index++)
                        {
                            if (array[index] > array2[index - 1])
                            {
                           temp = array[index];
                           array[index] = array[index-1];
                           array[index-1] = temp;
                            }
                        }
                    }
                    
                }if (x == 2)
                {
                    double temp;
                    for (int loop = 0; loop <= 5; loop++)
                    {
                        for (int index = 1; index <= 6; index--)
                        {
                            if (array[index] < array2[index + 1])
                            {
                                temp = array[index];
                                array[index] = array[index + 1];
                                array[index + 1] = temp;
                            }
                        }
                    }
                }
                //alg END
                for (int index2 = 0; index2 <= 6; index2++)
                {
                    Console.WriteLine(array[index2]);
                }
                Console.WriteLine("wollen sie beenden? ja oder nein");
                ende = Console.ReadLine();
                Console.Clear();
            } while (ende != "ja");

        }
    }
}
