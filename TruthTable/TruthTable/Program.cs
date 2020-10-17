using System;

namespace TruthTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.loop(30);
        }

        public void loop(int columtCNT)
        {
            for (int i = 0; i < (int)Math.Pow(2, columtCNT); i++)
            {
                for (int j = 0; j < columtCNT; j++)
                {
                    Console.Write(fill(i, j, columtCNT));
                }
                Console.WriteLine();
            }
        }

        public int fill(int i, int j, int LogicCount)
        {
            //this is old vesion of algorithm 
            //bool logic_bool = !((i / Math.Pow(2, j + 1)) % (Math.Pow(2, LogicCount - 2 * j - 1)) < Math.Pow(2, LogicCount - 2 * j - 2));
            int logic_bool = (i / Convert.ToInt32(Math.Pow(2, LogicCount - j - 1))) % 2;
            return logic_bool;
        }
    }
}
