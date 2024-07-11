namespace Calsse1th_brtue_forse_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 시간 복잡도

            //특정 크기의 입력을 기준으로 할때 필요한 
            //연산 횟수를 의미한다.

            #region 상수 시간 O(1)

            // 입력 크기와 상관없이 일정한 시간 복잡도를 가지는 시간입니다.
            //ex) 배열의 인덱스 참조
            #endregion

            #region 로그 시간 O(log n)

            //데이터의 크기에 따라 실행 시간이 로그 함수의 형태로 
            //증가하는 시간 복잡도입니다.

            //예) 이진 탐색 트리 
            #endregion

            #region 선형시간  O(n)

            // 입력에 따라 걸리는 시간이 선형적으로 증가되는 시간 입니다
            // ex) for문 

            #endregion

            #region 제곱시간  O(n²)
            // 입력되는 데이터를 기준으로 n² 만큼의 시간이 증가되는 
            // 시간 복잡도입니다.

            // 여기까지 오면 잘못된 알고리즘이다. 
            // ex) 2중 for문 
            #endregion


            #endregion

            #region 공간 복잡도
            //프로그램 실행과 완료에 얼마나 많은 공간이 필요한지 나태내는 척도

            #region 고정 공간
            //코드가 저장되는 공간으로 알고리즘
            //실행을 위해 시스템이 필요로하는 공간

            //ex) 배열
            #endregion

            #region 가변 공간
            // 문제를 해결하기 위해 알고리즘이 필요로하는 공간으로
            // 순환 프로그램일 경우 순환 스택을 의미

            //ex) 재귀함수
            #endregion


            #endregion

            #region 브루트 포스(brute fore)
            //가능한 모든 경우의 수를 탐색하면서
            //결과를 도출하는 알고리즘 

            int[] pw = new int[3] { 9, 9, 3 };
            //int number = 0;

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i == pw[0])
                        {
                            if (j == pw[1])
                            {
                                if (k == pw[2])
                                {
                                    Console.WriteLine("정답: " + i + j + k);
                                    //Console.WriteLine("number: " + number);
                                }
                            }
                        }
                        //number++;
                    }
                }
            }
            #endregion
        }
    }
}
