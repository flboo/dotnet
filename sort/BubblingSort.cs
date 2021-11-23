using System;
namespace Dotnet
{
    public class BubblingSort : SortBase
    {
        public override void Execute()
        {
            base.Execute();

            if (lst.Count > 0)
            {
                for (int i = 0; i < lst.Count - 1; i++)
                {
                    for (int j = 0; j < lst.Count - 1 - i; j++)
                    {
                        if (lst[j] > lst[j + 1])
                        {
                            ExchangeValue(j, j + 1);
                        }
                    }
                }
            }
            ConsoleAll();
        }


    }
}