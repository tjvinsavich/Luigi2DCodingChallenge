using LuigiChallenge;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] map = new int[][]{
                                               new int[] { 7, 0, 2, 5, 3 },
                                               new int[] { 5, 0, 0, 0, 2 },
                                               new int[] { 6, 9, 9, 0, 5 },
                                               new int[] { 8, 3, 2, 0, 1 }};
            Luigi luigi = new Luigi();

            string str = luigi.GoHome2D(map);

            Console.WriteLine(str);
        }
    }
}
