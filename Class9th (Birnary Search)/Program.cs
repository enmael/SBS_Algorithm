namespace Class9th__Birnary_Search_
{
    internal class Program
    {
        #region 강사님 풀이 

        static void BinanarySerach(int[] list, int key)
        {
            int left = 0;
            int right = list.Length - 1;

            while (left <= right)
            {
                //1.배열의 가운데 요소의 인덱스를 pivot으로 설정 합니다.
                int pivot = (left + right) / 2;

                //2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색을 종료 합니다.
                if (list[pivot] == key)
                {
                    Console.WriteLine("key Found : " + list[pivot]);
                    return;
                }
                //3.[pivot]의 값이 찾는 값보다 크다면 left ~pivot 사이의 값을 검색한다.
                else if (list[pivot] < key)
                {
                    right = pivot - 1;
                }
                //4.[pivot]의 값이 찾는 값보다 작다면 pivot~right 사이의 값을 검색
                else
                {
                    left = pivot + 1;
                }

            }
            Console.WriteLine("not key found");
        }
        #endregion
        static void Main(string[] args)
        {
            #region 이진 탐색 
            //탐색 범위를 반으로 나누어 찾는 값을 포함하는 범위를
            // 좁혀가는 방식으로 탐색하는 알고리즘


            //int[] array = new int[10] { 5, 6, 8, 11, 22, 33, 44, 50, 51, 79 };

            //int middle = 0;
            //int left = 0;
            //int right = 0;

            //int number = 1;

            //right = array.Length - 1; //9

            //middle = 5;

            //if(middle % 2 ==0)
            //{
            //    middle = middle +1;
            //}

            //while (array[middle] != number) 
            //{
            //    if(middle < number)
            //    {
            //        left = middle+1;
            //        middle = (left - right)/2;
            //    }
            //    else if(middle > number) 
            //    {
            //        right = middle-1;
            //        middle = (right - left) / 2  ;
            //    }
            //    //else if (array[middle] == number)
            //    //{
            //    //    Console.WriteLine(middle+ "번째에" + number +"존재");
            //    //    break;
            //    //}
            //    else if(left > right)
            //    {
            //        Console.WriteLine("값이 존재하지 않는다.");
            //        break;
            //    }

            //}

            #region 강사님 풀이 
            int[] array = new int[10] { 5, 6, 8, 11, 22, 33, 44, 50, 51, 79 };

            BinanarySerach(array, 51);
            #endregion

            #endregion
        }
    }
}
