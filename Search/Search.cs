using System;
using System.Collections.Generic;
namespace Dotnet.Search
{
    public class Search
    {
        private readonly static List<int> lsDefault = new List<int>() { 2, 2, 5, 6, 3, 3, 7, 8, 1, 4 };

        private readonly static List<int> lsDefault2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        static void Main_search(string[] args)
        {

            SearchBase searchBase;

            //顺序查找
            // searchBase = new OrderSearch();
            // searchBase.Init(lsDefault);

            //二分法查找
            searchBase = new BinarySearch();
            searchBase.Init(lsDefault2);



            Log.i(10 + 10 + "    q    " + 10 + 10);

            searchBase.Excute(8);
            Log.i("end: " + System.DateTime.Now.Millisecond);
        }

    }
}