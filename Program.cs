using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROWNANIE___Równanie_kwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta = 0;

            double a, b, c;
            string input = "";



            string[] data = new string[input.Length];

            List<int> pierwiastki = new List<int>();

          
         
            int counter = 0;
            bool flaga = true;
            while (flaga)
            {
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    flaga = false;
                }
                else if(input.Length > 4)
                {

                    input = input.Replace('.', ',');
                    data = input.Split(' ');
                    a = Convert.ToDouble(data[0]);
                    b = Convert.ToDouble(data[1]);
                    c = Convert.ToDouble(data[2]);
                    delta = ((b * b) - (4 * (a * c)));
                    pierwiastki.Add(Results(delta));
       
                }
            }


            foreach(var item in pierwiastki)
            {
                Console.WriteLine(item);
            }
     




            Console.ReadKey();
        }


        public static int Results(double delta)
        {
            var number = 0;
            if (delta < 0)
            {
                number = 0;
            }
            else if (delta == 0)
            {
                number = 1;
            }
            else if (delta > 0)
            {
                number = 2;
            }
            return number;

        }
    }

      

    }

