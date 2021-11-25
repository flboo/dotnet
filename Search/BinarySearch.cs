using System;
using System.Collections.Generic;
namespace Dotnet.Search
{
    public class BinarySearch : SearchBase
    {

        // 基本思想：元素必须是有序的，属于有序查找算法
        // 注：折半查找的前提条件是需要有序表顺序存储，对于静态查找表，
        // 一次排序后不再变化，折半查找能得到不错的效率。但对于需要频繁执行插入或删除
        // 操作的数据集来说，维护有序的排序会带来不小的工作量，那就不建议使用。——《大话数据结构》


        public override void Excute(int value)
        {

            int low = 0;
            int high = Lst.Count - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (value == Lst[mid])
                {
                    LogI(mid);
                    return;
                }
                else if (value > Lst[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            LogI(-1);
            return;
        }



    }
}