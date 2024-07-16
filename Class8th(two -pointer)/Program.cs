namespace Class8th_two__pointer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 투 포인터 (Two-pointer)
            // 두개의 포인터를 두고 값들을  비교하여 문제를 해결하는 알고리즘 

            int[] array = new int[5] { 1, 2, 5, 2, 5 };

            int start = 0;
            int end = 0;

            int count = 0;
            int sum = 0;

            int M = 5;

            while (start < array.Length) // start < 5
            {
                if (sum == M)
                {
                    count++;
                    start++;
                }
                else if (sum < M)
                {
                    end++;
                }
                else if (sum > M)
                {
                    start++;
                }

                sum = 0;

                if (start <= end)
                {
                    for (int j = start; j <= end; j++)
                    {
                        sum = sum + array[j];
                    }
                }
            }



            Console.WriteLine("count:" + count);
            #endregion
        }
    }
}
