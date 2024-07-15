namespace Class6th_Shell_Sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 쉘 정렬 

            // 먼 거리의 요소들을 먼저 정렬하여 배열을 부분적으로 
            //정렬한후, 점직적으로 더 작은 간격을 사용하는 정렬 알고리즘 

            int[] array = new int[11] { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };

            int key = 0;
            int gap = 0;


            gap = (array.Length - 1) / 2;

            while (gap > 0)
            {

                for (int j = 0; j < array.Length; j++)
                {


                    int number = gap + j;
                    if (number < array.Length)
                    {
                        key = array[number];

                        if (key < array[j])
                        {
                            array[number] = array[j];
                            array[j] = key;
                        }
                    }
                }

                gap = gap / 2;

                if (gap != 0 && gap % 2 == 0)
                {
                    gap = gap + 1;
                }
            }


            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);
            }

            //int[] array = new int[11] { 10, 8, 6, 20, 4, 3, 22, 1, 0, 15, 16 };

            //int gap = 0;
            //int i = 0;
            //int j = 0;
            //int key = 0;

            //for(gap= array.Length/2; gap>=0; gap/=2 )
            //{
            //    if(gap %2 ==0)
            //    {
            //        gap++;
            //    }

            //    for(i = gap; i < array.Length; i++) 
            //    {
            //        key = array[i];

            //        for(j = i; j>= gap && array[j -gap] > key; j -= gap)
            //        {
            //            array[j] = array[j - gap];
            //        }

            //        array[j] = key;
            //    }
            //}

            //for (int k = 0; k < array.Length; k++)
            //{

            //    Console.WriteLine(array[k]);
            //}
            #endregion
        }
    }
}
