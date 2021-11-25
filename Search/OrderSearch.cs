using System;
using System.Collections.Generic;
namespace Dotnet.Search
{
    public class OrderSearch : SearchBase
    {
        public override void Excute(int value)
        {
            for (int i = 0; i < Lst.Count; i++)
            {
                if (Lst[i] == value)
                {
                    LogI(value + "  顺序查找 " + i);
                }
            }
        }

    }
}