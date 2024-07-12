namespace Calss4th__selection_sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 선택 정렬
            // 주어진 리스트 중에 최소값을 찾아서 맨 앞에
            //위치한 결과를 교체 하는 방식으로 정렬하는
            // 알고리즘 

            //int[] array = new int[5] { 9, 6, 7, 3, 10 };
            //int number = 99;
            //int number2 = 0;
            //int number3 = 0;
            //for (int i = 0; i < array.Length-1; i++) 
            //{
            //    for(int j = i+1; j < array.Length-1; j++)
            //    {
            //        if (number > array[j])
            //        {
            //            number = array[j];
            //            number2 = j;
            //        }
            //    }
            //        number3 = array[i];
            //        array[i] = number;
            //        array[number2] = number3;
            //        number = 99;

            //}
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + ", ");
            //}


            //강사님 풀이
            int[] array = new int[5] { 9, 6, 7, 3, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                int min = array[i];

                int select = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (min > array[j])
                    {
                        min = array[j];

                        select = j;
                    }

                }

                int temp = array[i];
                array[i] = array[select];
                array[select] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            #endregion
        }
    }
}
