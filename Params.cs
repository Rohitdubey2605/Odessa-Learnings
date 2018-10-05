using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Params

{

    class Program

    {

        static void Main(string[] args)

        {

            ADDParameters(1);

            ADDParameters(1, 2, 3, 4, 5);

            ADDParameters1("sha", "rad");

            ADDParameters1("How", " are", " you", " ?");

            Console.ReadKey();

        }

        //for interger calculation

        public static void ADDParameters(params int[] arguemnts)

        {

            int add = 0;

            foreach (int argu in arguemnts)

            {

                add += argu;

            }

            Console.WriteLine(add);

        }

        public static void ADDParameters1(params string[] arguemnts)

        {

            string add = "";

            foreach (string argu in arguemnts)

            {

                add += argu;

            }

            Console.WriteLine(add);

        }

    }

}