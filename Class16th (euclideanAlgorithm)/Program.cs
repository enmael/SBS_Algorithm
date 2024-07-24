namespace Class16th__euclideanAlgorithm_
{
    internal class Program
    {
        #region 최대 공략수

        static int greatestCommonDivisor(int x, int y)
        {
            int n = 2;
            int i = 0;

            int[] arrray = new int[10];

            while (x >= n && y >= n)
            {
                if (x % n == 0 && y % n == 0)
                {
                    arrray[i] = n;
                    i++;
                    n++;
                }
                else
                {
                    n++;
                }
            }

            int number = 0;

            for (int j = 0; j < arrray.Length; j++)
            {
                if (number < arrray[j])
                {
                    number = arrray[j];
                }
            }

            return number;
        }

        static int greatestCommonDivisor2(int x, int y)
        {
            int n = 2;
            int i = 0;
            int number = 0;

            while (x >= n && y >= n)
            {
                if (x % n == 0 && y % n == 0)
                {
                    number = n;
                    i++;
                    n++;
                }
                else
                {
                    n++;
                }
            }

            return number;
        }

        #endregion


        #region 유클리드 호제법
        //Euclidean algorithm
        static int euclideanAlgorithm(int x, int y)
        {
            int a = x;
            int b = y;
            int c = 0;


            c = a % b;


            if (c != 0 && b % c == 0)
            {
                return c;
            }
            else if (c == 0)
            {
                return b;
            }
            else
            {
                return euclideanAlgorithm(b, c);
            }

        }

        #endregion
        static void Main(string[] args)
        {
            #region 유쿨라두 호제법

            //두개의 자연수 또는 정식의 최대 공략수를 구하는 알고리즘으로 
            // 두 수가 서로 상대방 수를 나누어서 원하는 수를 얻어내는 알고리즘 입니다.

            #region 최대 공략수

            //Console.WriteLine(greatestCommonDivisor2(5, 15));
            //Console.WriteLine(greatestCommonDivisor2(30, 48));

            #endregion
            //Console.WriteLine(euclideanAlgorithm(24, 18));
            //Console.WriteLine(euclideanAlgorithm(24, 18));
            //Console.WriteLine(euclideanAlgorithm(78696, 19332));
            //Console.WriteLine(euclideanAlgorithm(48, 30));
            Console.WriteLine(euclideanAlgorithm(15, 5));
            //Console.WriteLine(78696 % 19332);
            #endregion
        }
    }
}
