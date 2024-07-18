using System.Data;

namespace Program
{


    internal class Program
    {
       

        static void ArrayPint(int[] list, int i) 
        {
            
            if(i <list.Length-1) // 재귀가 종료되는 조건 
            {
                Console.WriteLine(list[i]);
                ArrayPint(list, i + 1);

            }
  
        }
        
        //static void MergeSort(int[]list, int left, int right)
        //{
        //    if(left == right) 
        //    {
        //        // Console.WriteLine(list[left]);
        //        return;
        //    }
        //    else
        //    {
        //        MergeSort(list, left,  (left+ right) /2);
        //        MergeSort(list, (right - left) / 2 + 1, right);
        //    }
        //}
        static void Merge(int[] list, int start, int end)
        {

            int[] leftArray = new int[list.Length];
            int[] RightArray = new int[list.Length];

            int[] newArray = new int[list.Length+ list.Length];

            for(int k =0;  k < list.Length; k++) 
            {
                leftArray[k]= list[k];
                RightArray[k]= list[list.Length-1+ k];   
            }
            
            int i = 0;
            int j = 0;
            int count = 0;

            while (count > newArray.Length-1) 
            {
                if (leftArray[i] < RightArray[j])
                {
                    newArray[count] = leftArray[i];
                    count++;
                    j++;
                }
                else if(leftArray[i] > RightArray[j])
                {
                    newArray[count] = RightArray[j];
                    count++;
                    i++;
                }
            }
                
        }

        static void Merge2(int[] list, int start, int middle,int end)
        {
            int left = start;
            int right = middle + 1;

            int[] temporaryArray = new int[right - left + 1];
        }
        #region 강사님풀이
        static void MergeSort2(int[] list, int start, int end)
        {
            if(start<end)
            {
                int middle = (start + end) / 2;

                MergeSort2(list, start, middle);
                
                MergeSort2(list, middle+1,end);

                Merge2(list, start,middle, end);
            }
        }


        #endregion
        static void Main(string[] args)
        {



            //ArrayPint(array, 0);

            #region 병합 정렬 
            //하나의 리스트를 두개의 균등한 크기로 분활하고
            //분활한 부분리스트를 정렬한 다음, 두개의 정렬된 부분 이스트를
            //합하여 전체체가 정렬된 리스트가 되게 하는 방법 .

            //1.리스트의 길이가 0 또는 1이면 이미 정렬된것으로 봅니다.

            //2. 그렇지 않은경우

            //2-1. 정렬되지 않은 리스트를 절반으로 잘라 비슷한 크기의 두 부분ㅇ리스트로 나눔

            //2-2 걱 뷰뷴아수투룰 쟈규적으로 병ㅎ랍 정렬을 이여ㅛㅇ해 정렬

            int[] array = new int[] { 21,10,12,20,25,13,15,22 };
            ArrayPint(array, 0);
            //MergeSort2(array, 0, array.Length);
            //MergeSort(array, 0, array.Length);
            #endregion
        }
    }
}
