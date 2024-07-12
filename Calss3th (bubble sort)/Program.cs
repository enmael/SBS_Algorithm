namespace Calss3th__bubble_sort_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 거품 정렬
            // 서로 인접한 두 원소를 검사하여 정렬하는 알고리즘 

            int[] array = new int[5] { 32, 5, 7, 1, 27 };
            int number = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < (array.Length - i) - 1; j++)
                {
                    //if (j < array.Length - 1)
                    //{
                    if (array[j] > array[j + 1])
                    {
                        number = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = number;
                    }
                    //}

                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            #endregion
        }
    }
}
