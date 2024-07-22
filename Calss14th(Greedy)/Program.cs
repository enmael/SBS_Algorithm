namespace Calss14th_Greedy_
{
    internal class Program
    {
        static void money(int n)
        {
            int x = n;
            int count = 0;

            //int number1 = 0;
            //int number2 = 0;
            //int number3 = 0;
            //int number4 = 0;

            int[] array = new int[5];

            while (n > 0)
            {
                if (n >= 1000)
                {
                    n = n - 1000;
                    array[0]++;
                    count++;
                }
                else if (n < 1000 && n >= 500)
                {
                    n = n - 500;
                    array[1]++;
                    count++;
                }
                else if (n < 500 && n >= 100)
                {
                    n = n - 100;
                    array[2]++;
                    count++;
                }
                else if (n < 100 && n >= 50)
                {
                    n = n - 50;
                    array[3]++;
                    count++;
                }
                else if (n < 50 && n >= 10)
                {
                    n = n - 10;
                    array[4]++;
                    count++;
                }

            }

            //for(int i = 0; i < array.Length; i++) 
            //{
            //    if (array[i] != 0)
            //    {
            //        count = count+array[i];    
            //    }
            //}

            Console.WriteLine(x + "잔돈은");
            Console.WriteLine("1000원짜리 :" + array[0] + ", " + "100원짜리 :" + array[1] + ", " + "500원짜리 :" + array[2] + ", " + "50원짜리 :" + array[3] + ", " + "10원짜리 :" + array[4]);
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {

        }
    }
}
