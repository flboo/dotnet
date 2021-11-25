using System;
using System.Collections.Generic;
namespace Dotnet
{
    class Sort
    {
        private readonly static List<int> lsDefault = new List<int>() { 1, 2, 5, 6, 3, 1, 7, 8, 1, 4 };
        private readonly static List<int> lst2 = new List<int>() { 1, 2, 5, 6, -2, 10, 7, 8, 15, 4 };

        private readonly static Dictionary<int, string> dic = new Dictionary<int, string>()
        {
            {1,"1111"},
            {5,"2222"},
            {3,"3333"},
            {4,"3333"},
        };

        //TODO FL  Main
        static void Main_sort(string[] args)
        {
            Console.WriteLine("start test!");
            SortBase sortBase;

            //冒泡排序
            // sortBase = new BubblingSort();

            //快速排序
            // sortBase = new FastSort();

            //选择排序
            // sortBase = new SelectSort();

            // //堆排序
            // sortBase = new HeapSort();

            //插入排序
            // sortBase = new InsertSort();

            //希尔排序
            // sortBase = new HillSort();


            //归并排序
            sortBase = new OrderByMergingSort();



            sortBase.InitLst(lsDefault);
            sortBase.Execute();
        }

    }
}
