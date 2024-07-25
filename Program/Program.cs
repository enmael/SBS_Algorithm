using System.Security.Cryptography;

namespace Program
{
 
    internal class Program
    {
        #region 완전수

        static void Number(int number)
        {
            int count = 0;
            for(int i = 1; i <= number/2; i++) 
            {
                if(number % i == 0)
                {
                    count = count + i;
                }

            }

            if(number == count)
            {
                Console.WriteLine(number + " 는 완전수이다");
            }
            else
            {
                Console.WriteLine(number + " 는 완전수가 아니다");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region 완전수
            //Number(6);
            //Number(28);
            //Number(496);
            //Number(8128);
            //Number(5);

            Number(523776);
            #endregion
        }
    }
}
