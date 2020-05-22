using System;
using System.Linq;
using System.Threading.Tasks;


namespace CS50
{
    class mario
    {
        static void Main(string[] args)
        {

            string sym1 = "#";
            string sym2 = "#";
            string outPut = "";
            string sp = "";

            Console.Write("How high would you like your mountain, in bricks? ");
            var height = Console.ReadLine();

            int hgt = Int32.Parse(height);
            Console.WriteLine("Your mountain will be " + hgt + " bricks high!");

            int cnt = hgt;

            for (int i = 0; i < hgt; i++)
            {
                sp = AdjustSpacing(sp, cnt);
                outPut = sym1 + " " + sym2;
                Console.WriteLine(sp + outPut);

                cnt--;

                sym1 += "#";
                sym2 += "#";
            }
            Console.WriteLine();
            Console.WriteLine("DONE!!");
        }

        static string AdjustSpacing(string sp, int c)
        {
            sp = "";

            for (int i = 0; i < c; i++)
            {
                sp += " ";
            }

            return sp;
        }
    }
}
