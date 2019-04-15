using System;

namespace GraphAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph test = new Graph();
            test.connect(1,2);
            test.connect(1,3);
            test.connect(1,8);
            test.connect(1,5);
            test.connect(1,3);
            System.Console.WriteLine(test.isAdjacent(5,2));

        }
    }
}
