using System.Collections.Generic;
namespace Dotnet
{
    public abstract class SortBase : ISortBase
    {
        protected List<int> lst;
        protected Dictionary<int, string> dic;
        public virtual void Execute()
        {
            if (lst != null)
            {
                Console("lst length: " + lst.Count.ToString());
            }
            if (dic != null)
            {
                Console("dic length: " + dic.Count.ToString());
            }
            Console(" execute start  time: " + System.DateTime.Now.Millisecond);
        }

        public virtual void InitLst(List<int> lst) { this.lst = lst; }
        public virtual void InitLst(Dictionary<int, string> dic) { this.dic = dic; }

        protected void ConsoleAll()
        {
            string str = "";
            if (lst != null)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    str += string.Format("{0}  ", lst[i]);
                }
            }
            if (dic != null)
            {
                foreach (var item in dic)
                {
                    str += string.Format("{0}  ", item.Value);
                }
            }
            Console(str);
            Console(" execute end  time: " + System.DateTime.Now.Millisecond);
        }

        protected void Console(string log) { System.Console.WriteLine(log); }

        protected void Console(int log) { System.Console.WriteLine(log.ToString()); }


        protected void ExchangeValue(int value1, int value2)
        {
            if (value1 != value2)
            {
                if (lst != null)
                {
                    int value = lst[value1];
                    lst[value1] = lst[value2];
                    lst[value2] = value;
                }
                if (dic != null)
                {

                    string str = dic[value1];
                    dic[value1] = dic[value2];
                    dic[value2] = str;
                }
            }
        }





    }
}