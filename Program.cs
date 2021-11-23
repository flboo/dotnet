using System;
using System.Collections.Generic;
namespace Dotnet
{
    class Program
    {
        private readonly static List<int> lst = new List<int>() { 1, 2, 5, 6, 3, 1, 7, 8, 1, 4 };
        private readonly static List<int> lst2 = new List<int>() { 1, 2, 5, 6, -2, 10, 7, 8, 15, 4 };

        private readonly static Dictionary<int, string> dic = new Dictionary<int, string>()
        {
            {1,"1111"},
            {5,"2222"},
            {3,"3333"},
            {4,"3333"},
        };


        static void Main(string[] args)
        {
            Console.WriteLine("start test!");
            SortBase sortBase;

            //冒泡排序
            // sortBase = new BubblingSort();
            // sortBase.InitLst(lst);

            //快速排序
            // sortBase = new FastSort();
            // sortBase.InitLst(lst);
            //选择排序
            // sortBase = new SelectSort();
            // sortBase.InitLst(lst);
            //堆排序
            sortBase = new HeapSort();
            sortBase.InitLst(lst2);

            sortBase.Execute();
        }

    }
}
