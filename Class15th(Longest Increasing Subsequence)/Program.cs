namespace Class15th_Longest_Increasing_Subsequence_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 최장 증가 부분 수열(Longest Increasing Subsequence)
            // 원소가 N개인 일부 원소를 골라내서 부분 수열중 
            // 각 원소가 이전 원소가 크다는 조건을 만족하고 그길이가 최대인
            // 부분 수열입니다.


            // 주어진 배열에서 인덱스를 한칸씩 늘려가면서 확인
            // 내부 반복문으로 i보다 작은 인덱스들을 하나씩 살펴 보변서
            // array[j] <array[i]인 것이 있을 걍우 count배열을 업데이드
            // 업데이트 기준

            //1. j번째 인덱스에서 끝나는 최장 증가 부분 수열의 마지막에 array[i]
            //를 추가했을때 LIS 길이와

            //2.추가하지 않고 기존의 COUNT 배열[I]값
            //둘중에더큰값을로 COUNT[I] 배열 업데이트

            //int[] array = new int[] { 3, 2, 4, 1, 6 };
            //int[] arrayCont = new int[array.Length];

            //for (int i = 0; i < array.Length; i++)
            //{

            //    if (i == 0)
            //    {
            //        arrayCont[i] = 1;
            //    }
            //    else
            //    {
            //        for(int j  = 0; j < array.Length; j++)
            //        {
            //            if (i >= j && array[j] > array[i])
            //            {
            //                arrayCont[i] = 1;
            //            }
            //            else if(i > j && array[j] < array[i])
            //            {

            //                arrayCont[i]++;
            //            }



            //        }

            //    }

            //}

            //for (int k = 0; k < arrayCont.Length; k++)
            //{
            //    Console.Write(arrayCont[k]);
            //}

            int[] array = new int[] { 3, 2, 4, 1, 6 };
            int[] Cont = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[i])
                    {
                        Cont[i] = Math.Max(Cont[i], Cont[j] + 1);
                    }

                    if (Cont[i] == 0)
                    {
                        Cont[i] = 1;
                    }

                }
            }

            for (int k = 0; k < Cont.Length; k++)
            {
                Console.Write(Cont[k]);
            }
            #endregion
        }
    }
}
