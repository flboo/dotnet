namespace Dotnet
{
    //选择排序
    public class SelectSort : SortBase
    {
        public override void Execute()
        {
            base.Execute();
            for (int i = 0; i < lst.Count; i++)
            {
                int value = i;
                for (int j = i; j < lst.Count; j++)
                {
                    if (lst[value] > lst[j])
                    {
                        value = j;
                    }
                }
                ExchangeValue(i, value);
            }

            ConsoleAll();
        }
    }
}