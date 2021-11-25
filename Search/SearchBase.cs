using System;
using System.Collections.Generic;

namespace Dotnet.Search
{
    public abstract class SearchBase
    {
        protected List<int> Lst;
        public void Init(List<int> lst)
        {
            Log.i("start: " + System.DateTime.Now.Millisecond);
            this.Lst = lst;
        }

        public abstract void Excute(int value);

        protected void LogI(object obj)
        {
            Log.i(obj);
        }

    }
}