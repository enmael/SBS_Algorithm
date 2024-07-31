namespace Class23th_Prefix_Sum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 누적합
            /*특정한 배열이 있을때 해당 배열 까지의 합을 의미
             * 
             */

            int[] array = new int[] { 7, 3, 4, 5, 1 };

            //int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i <= array.Length - 2)
                {
                    array[i + 1] = array[i] + array[i + 1];
                }
            }


            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(j + "번째 " + array[j]);
            }
            #endregion

        }
    }
}
