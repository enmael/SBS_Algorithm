namespace Calss10th_Divide_and_Conquer_
{
    internal class Program
    {
        #region 분활 정복 

        static int Find(int[] list, int left, int right)
        {
            //int maxLeft = 0;
            //int maxfRight = 0;

            if (left == right)
            {
                return list[left];
            }
            else
            {
                int maxLeft = Find(list, left, (right + left) / 2);
                int maxRight = Find(list, (right + left) / 2 + 1, right);
                if (maxLeft > maxRight)
                {
                    return maxLeft;
                }
                else
                {
                    return maxRight;
                }
            }

        }

        #endregion
        static void Main(string[] args)
        {
            #region 분활 정복 

            // 주어진 문제를 2개 이상의 부분으로 분제를 나눈 뒤 각 부분
            //문제에 대한 답을 재귀 호출을 이용해서 계산한 다음, 그 답으로 부터
            // 전체 문제의 답을 계산해내는 알고리즘 

            // 분활(divide): 주어진 문제를 두개 혹은 그 이상의 형식으로 나눈다.

            // 정복(counquer) : 나누어진 문제를 재귀적으로 해결해서 나누어진 문제를
            //                  더이상 나누어 문제를 필요 없을 때까지 계속 분활

            //통합(combine) : 나누어서 해결한 문제들을 통합해서 원래 문제의 해답을 생성한다.


            int[] array = new int[] { 3, 6, 1, 5, 77, 4, 3, 19 };
            // Find(array , 0 , array.Length);
            Console.WriteLine(Find(array, 0, array.Length - 1));

            #endregion
        }
    }
}
