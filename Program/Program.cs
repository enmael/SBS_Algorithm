using System.Net.Security;
using System.Reflection;

namespace Program
{
    internal class Program
    {
        #region 강사님 풀이

        static void QuickSort(int[]list,int start, int end)
        {

            

            int pivot = start;
            int left = start - 1;
            int right = end;

            while (left <= right) 
            {
                while(left <= end && list[pivot] >= list[left] )
                {
                    left++;
                }

                while(right>start && list[pivot]<= list[right])
                {
                    right++;
                }
            }
            
            
        }
        #endregion

        static void QuickSort2(int[] list, int left, int right)
        {
            int pivot = 0;
            int tmep = 0;


            while (left <= right)
            {

                if (list[pivot] < list[right])
                {
                    right--;
                }
                else if (list[pivot] > list[left])
                {
                    left++;
                }
                else if (list[pivot] > list[right])
                {

                    tmep = list[right];
                    list[right] = list[left];
                    list[left] = tmep;
                }
            }

            tmep = list[pivot];
            list[pivot] = list[left];
            list[left] = tmep;

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static void Main(string[] args)
        {

            #region 퀵 정렬 
            // 기준점을 확득한 다음 해당 기준점을 기준으로 
            //배열을 나누고 한쪽에는 기준점보다 작은값들이
            //위치 하고 다른 한쪽에는 기준점보다 큰값들이 위치 하도록하나다.

            //나누어진 하위 배열에 대해 재귀적으로 퀵 정렬 을 호출
            //모든 배열이 기본 배열이 될때 까지 반복하는 정렬

            //퀵 정렬은 평균적으로 o(n log n)의 시간 복잡도를 가지며,
            //최악의 경우 o(n²)의 시간 복잡도를 가짐

            //1. 기준점을 선택한다.


            //2. 기준점을 기준으로 왼쪽은 기준점보다 큰 값,
            //오른족은 기준점보다 작은값을 탐색

            //3. 양방향에서 찾은 두 원소를 교환
            //4. 왼쪽에서 탐색하는 위치와 오른쪽에서 탐색하는 위치가 
            //엇갈리지 않을때 까지 2번으로 돌아가는 위의 과정을 반복

            //5.엇갈린 기점을 기준으로 두개의 부분 리스트로 나누어 1번으로 돌아가
            // 해당 부분 리스트의 길이가 1이 도리때까지 반복 한다.

            //6. 인접한 부분리스트 합하여 수행 합니다.


            int[] array = new int[] { 5, 3, 8, 9, 2, 4, 7 };

            QuickSort2(array,1, array.Length-1);
            #endregion

        }
    }
}
