namespace Calss13th_Dynamic_program_
{
    internal class Program
    {
        #region 동적 계획법

        static int Fibonacci(int x)
        {
            //int n = x;

            if (x <= 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(x - 1) + Fibonacci(x - 2);
            }

        }

        static uint FibonacciMemoization(uint x)
        {

            uint[] array = new uint[x + 1];


            if (x <= 0)
            {
                array[x] = 0;
                return 0;
            }
            else if (x == 1)
            {
                array[x] = 1;
                return 1;
            }
            else
            {
                if (array[x] != 0)
                {
                    return array[x];
                }
                else
                {
                    return array[x] = FibonacciMemoization(x - 1) + FibonacciMemoization(x - 2);

                }

            }

        }
        #endregion
        static void Main(string[] args)
        {
            #region 동적 계획법

            //특정범위 까지의 값을 구하기 위해 그것과
            //다른 범위꺼ㅏ지의 값을 이용하여 효울적으로 값을 구하는 알고리즘

            //메모이재이션

            // 프로그래밍이 동일한 계산을 반복해야 할때, 이전에
            //계산하 값을 메모리에 저장함으로써 동일한 계산을
            //반복 수행하는 작업을 제거하여 프로그램의 실행속도를 향상 시키는 기법
            #endregion

            //Console.WriteLine(Fibonacci(1));

            for (uint i = 0; i < 46; i++) // 47에서 터짐  
            {
                Console.WriteLine(i + "번째 : " + FibonacciMemoization(i));
            }


            //for (int i = 0; i < 46; i++) // 47에서 터짐  
            //{
            //    Console.WriteLine(i + "번째 : " + Fibonacci(i));
            //}
        }
    }
}
