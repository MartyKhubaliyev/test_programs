using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            array[0] = 0;
            array[1] = 1;
            array[2] = 1;
            array[3] = 2;
            array[4] = 2;
            array[5] = 3;
            array[6] = 4;
            array[7] = 5;
            array[8] = 5;
            array[9] = 6;
            int c;// chislo nawe
            c = Convert.ToInt32(Console.ReadLine());
            int n = 10;// kolichestvo chisel
            int k;//konec massiva
            Search(array, c);
            Console.ReadLine();
        }
        static int Search ( int[] array, int c )
        {

            for ( int i = 0; i < 10; i++ )
            {
                for ( int j = 0; j > 0; j-- )
                {
                    if ( c <= array[(i+j)/2] )
                    {
                        if (c == array[i])
                        {
                            Console.WriteLine("index c = " + i);
                            return 1;
                        }
                        else if (c == array[(i + j) / 2])
                        {
                            Console.WriteLine("index c = " + (i+j)/2);
                            return 1;
                        }
                        else
                        {
                            j = (i + j) / 2;
                        }
                    }
                    else
                    {
                        if (c == array[j])
                        {
                            Console.WriteLine("index c = " + j);
                            return 1;
                        }
                        else
                        {
                            i = (i + j) / 2;
                        }

                    }
                }
            } return 0;
        }

    }
}
