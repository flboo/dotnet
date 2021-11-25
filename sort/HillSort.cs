namespace Dotnet
{
    public class HillSort : SortBase
    {
        //希尔排序  针对有序序列在插入时采用交换法
        public override void Execute()
        {
            base.Execute();
            Console("希尔排序");


            for (int gap = lst.Count / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < lst.Count; i++)
                {
                    int j = i;
                    while (j - gap > 0 && lst[j] < lst[j - gap])
                    {
                        ExchangeValue(j, j - gap);
                        j -= gap;
                    }
                }
            }

            ConsoleAll();
        }
    }
}