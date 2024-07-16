using System.Net.Security;
using System.Reflection;

namespace Program
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region 이진 탐색 
            //탐색 범위를 반으로 나누어 찾는 값을 포함하는 범위를
            // 좁혀가는 방식으로 탐색하는 알고리즘


            int[] array = new int[10] { 5, 6, 8, 11, 22, 33, 44, 50, 51, 79 };

            int middle = 0;
            int left = 0;
            int right = 0;

            int number = 1;

            right = array.Length - 1; //9

            middle = 5;

            if(middle % 2 ==0)
            {
                middle = middle +1;
            }

            while (array[middle] != number) 
            {
                if(middle < number)
                {
                    left = middle+1;
                    middle = (left - right)/2;
                }
                else if(middle > number) 
                {
                    right = middle-1;
                    middle = (right - left) / 2  ;
                }
                //else if (array[middle] == number)
                //{
                //    Console.WriteLine(middle+ "번째에" + number +"존재");
                //    break;
                //}
                else if(left > right)
                {
                    Console.WriteLine("값이 존재하지 않는다.");
                    break;
                }
                
            }


            #endregion

        }
    }
}
