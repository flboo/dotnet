namespace Dotnet
{
    public class InsertSort : SortBase
    {
        public override void Execute()
        {
            base.Execute();


            for (int i = 1; i < lst.Count; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (lst[j] < lst[j - 1])
                    {
                        ExchangeValue(j, j - 1);
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }



            ConsoleAll();
        }
    }
}