using System;
using System.Collections.Generic;
namespace Dotnet
{
    public class HeapSort : SortBase
    {       //大顶堆 和 小顶堆   升序一般选择大顶堆 降序一般选择小顶堆   
        public override void Execute()
        {
            base.Execute();

            BuildHeap();


            ConsoleAll();
        }

        //构建大顶堆
        private void BuildHeap()
        {
            //构建大堆顶
            for (int i = lst.Count / 2 - 1; i >= 0; i--)
            {
                //从第一个非叶子结点 从下至上 从右至 左 调整结构
                AdjustHeap(lst, i, lst.Count);
            }
            //调整对结构+交换堆顶元素与末尾元素
            for (int i = lst.Count - 1; i > 0; i--)
            {
                ExchangeHeap(0, i);
                AdjustHeap(lst, 0, i);
            }
        }
        private void AdjustHeap(List<int> lt, int parentIndex, int length)
        {
            int temp = lt[parentIndex];//先取出当前元素i
            int childIndex = parentIndex * 2 + 1;
            while (childIndex < length)
            {
                if (childIndex + 1 < length && lt[childIndex] < lt[childIndex + 1])
                {
                    childIndex++;
                }
                if (temp >= lt[childIndex])
                {
                    break;
                }
                lt[parentIndex] = lt[childIndex];
                parentIndex = childIndex;
                childIndex = childIndex * 2 + 1;
            }
            lt[parentIndex] = temp;
        }

        private void ExchangeHeap(int left, int right)
        {
            ExchangeValue(left, right);
        }

    }
}