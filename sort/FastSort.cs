using System;
using System.Collections.Generic;
namespace Dotnet
{
    public class FastSort : SortBase//重构 重在找到基准
    {
        public override void Execute()
        {
            base.Execute();
            QuickSort(lst, 0, lst.Count - 1);
            ConsoleAll();
        }
        private void QuickSort(List<int> lt, int low, int high)
        {
            if (low < high)
            {
                int axleIndex = GetZhouIndex(lt, low, high);
                QuickSort(lt, low, axleIndex);
                QuickSort(lt, axleIndex + 1, high);
            }
        }

        private int GetZhouIndex(List<int> lt, int low, int high)
        {
            int temp = lt[low];
            while (low < high)
            {
                while (low < high && lt[low] >= lt[high])
                {
                    high--;
                }
                lt[low] = lt[high];
                while (low < high && lt[low] <= lt[high])
                {
                    low++;
                }
                lt[high] = lt[low];
            }
            if (low != high)
            {
                Console("low " + low + "   high: " + high);
            }
            return low;
        }


    }
}