using System.Net.Security;

namespace Program
{
    internal class Program
    {
        #region 소수 찾기
        //static bool IsPrime(int n)
        //{
        //    for(int i = 2; i < n; i++) 
        //    {
        //        if(n % i == 0)
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}

        #endregion
        static void Main(string[] args)
        {
            #region 소수 찾기 

            //int number = 19;
            //int number2 = 0;

            //for(int i = 2; i <= number; i++) 
            //{

            //    if (number % i == 0)
            //    {
            //        number2++;
            //    }

            //}

            //if (number2 == 1)
            //{
            //    Console.WriteLine("소수이다");
            //}
            //else
            //{
            //    Console.WriteLine("소수가 아니다");
            //}
            #endregion

            #region 에라토스 테네스의 체
            //소수를 판정하는 방법으로, 자연수를 순서대로 
            // 늘어놓은 표에서 합성수를 차례대로 지위나가면서
            // 소수의 목록을 얻어내는 방법 

            int number = 30; 
            int[] array = new int[number];
           


            for (int i = 0; i < number; i++) 
            {
                array[i] = i;
            }

            for(int i =2; i < number; i++)
            {
                if (array[i]% 2 == 0)
                {
                    array[i] = 0;
                }
                else if (array[i]%3 == 0) 
                {
                    array[i] = 0;
                }
            }

            array[2] = 2;
            array[3] = 3;
            for (int i =0; i < number; i++)
            {
                Console.WriteLine(i+"번째 값 : "+array[i]);
            }
            #endregion
        }
    }
}
