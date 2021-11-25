using System;
using System.Collections.Generic;
namespace Dotnet
{
    public class HeapSort : SortBase
    {
        //大顶堆 和 小顶堆
        //1、将无序序列构建成一个堆    升序选择大顶堆 降序选择小顶堆   
        //2、将堆元素与末尾元素交换  将最大元素沉到元素末端
        //3、重新调整结构 时期满足堆定义  然后继续交换堆顶元素与末尾元素
        //4、反复执行 2和3步骤 直到整个数列有序  即可
        public override void Execute()
        {
            base.Execute();

            HighHeap();

            ConsoleAll();
        }

        private void HighHeap()
        {
            for (int i = lst.Count / 2 - 1; i >= 0; i--)
            {
                ChangeHeap(lst, i, lst.Count);
            }
            for (int j = lst.Count - 1; j > 0; j--)
            {
                ExchangeValue(0, j);
                ChangeHeap(lst, 0, j);
            }
        }

        private void ChangeHeap(List<int> lt, int parentIndex, int length)
        {
            int temp = lt[parentIndex];
            int childIndex = 2 * parentIndex + 1;
            while (childIndex < length)
            {
                if (childIndex + 1 < length && lt[childIndex] < lt[childIndex + 1])
                {
                    childIndex++;
                }
                if (lt[childIndex] < temp)
                {
                    break;
                }
                lt[parentIndex] = lt[childIndex];
                parentIndex = childIndex;
                childIndex = childIndex * 2 + 1;
            }
            lt[parentIndex] = temp;
        }

    }
}























//构建大顶堆
// private void BuildHeap()
// {
//     //构建大堆顶
//     for (int i = lst.Count / 2 - 1; i >= 0; i--)
//     {
//         //从第一个非叶子结点 从下至上 从右至 左 调整结构
//         AdjustHeap(lst, i, lst.Count);
//     }
//     //调整对结构+交换堆顶元素与末尾元素
//     for (int i = lst.Count - 1; i > 0; i--)
//     {
//         ExchangeHeap(0, i);
//         AdjustHeap(lst, 0, i);
//     }
// }
// private void AdjustHeap(List<int> lt, int parentIndex, int length)
// {
//     int temp = lt[parentIndex];//先取出当前元素i
//     int childIndex = parentIndex * 2 + 1;
//     while (childIndex < length)
//     {
//         if (childIndex + 1 < length && lt[childIndex] < lt[childIndex + 1])
//         {
//             childIndex++;
//         }
//         if (temp >= lt[childIndex])
//         {
//             break;
//         }
//         lt[parentIndex] = lt[childIndex];
//         parentIndex = childIndex;
//         childIndex = childIndex * 2 + 1;
//     }
//     lt[parentIndex] = temp;
// }

// private void ExchangeHeap(int left, int right)
// {
//     ExchangeValue(left, right);
// }