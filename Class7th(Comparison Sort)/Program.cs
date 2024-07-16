namespace Class7th_Comparison_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 계수 정렬

            // 데이터의 값을 직접 비교하지 않고, 단순하게 
            //각 숫자가 몇개 있는지 개수를 세어 저장한 다음
            //정렬하는 알고리즘 입니다.


            int[] array = new int[14] { 1, 6, 6, 6, 5, 1, 2, 3, 1, 2, 3, 6, 5, 4 };
            int[] arrayCount = new int[6];

            for (int i = 0; i < arrayCount.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i + 1 == array[j])
                    {

                        arrayCount[i] = arrayCount[i] + 1;
                    }

                }


            }

            for (int k = 0; k < arrayCount.Length; k++)
            {
                Console.WriteLine(arrayCount[k]);
            }
            #endregion
        }
    }
}
