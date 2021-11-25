using System;
using System.Collections.Generic;
namespace Dotnet
{
    public class OrderByMergingSort : SortBase
    {

        //归并法
        public override void Execute()
        {
            base.Execute();

            List<int> lsttt = new List<int>();
            lsttt.AddRange(lst);
            OrderSort(lst, 0, lst.Count - 1, lsttt);

            ConsoleAll();
        }

        //fenfrn 
        private void OrderSort(List<int> originlst, int left, int right, List<int> temp)
        {
            if (left < right)
            {
                int mid = (right + left) / 2;
                OrderSort(originlst, 0, mid, temp);
                OrderSort(originlst, mid + 1, right, temp);
                MergeSort(originlst, left, mid, right, temp);
            }
        }

        //heheheheh
        private void MergeSort(List<int> originlst, int left, int mid, int right, List<int> temp)
        {
            int i = left;
            int j = mid + 1;
            int t = 0;
            while (i <= mid && j <= right)
            {
                if (originlst[i] <= originlst[j])
                {
                    temp[t++] = originlst[i++];
                }
                else
                {
                    temp[t++] = originlst[j++];
                }
            }
            while (i <= mid)
            {
                temp[t++] = originlst[i++];
            }
            while (j <= right)
            {
                temp[t++] = originlst[j++];
            }
            t = 0;
            while (left <= right)
            {
                originlst[left++] = temp[t++];
            }
        }

    }
}