using System;

namespace GraphAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph test = initialize();
            test.isAdjacent(1,2);
            test.isAdjacent(2,1);
        }

        public static Graph initialize()
        {
            Graph toReturn = new Graph();
            toReturn.connect(1,2);
            toReturn.connect(1,3);
            toReturn.connect(1,8);
            toReturn.connect(2,5);
            toReturn.connect(2,4);
            toReturn.connect(3,1);
            toReturn.connect(3,4);
            toReturn.connect(4,5);
            toReturn.connect(6,5);
            toReturn.connect(7,6);
            toReturn.connect(7,8);
            toReturn.connect(8,7);
            toReturn.connect(8,6);
            return toReturn;
        }
    }
}
