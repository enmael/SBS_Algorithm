namespace Class_17th_back_tracking_
{
    internal class Program
    {
        #region 백트래킹(하노이탑)

        static void Hanoi(int n, char from, char by, char to)
        {
            if (n == 1)
            {
                Console.WriteLine("[ " + n + "]" + from + "->" + to);
            }
            else
            {
                Hanoi(n - 1, from, to, by);
                Console.WriteLine("[ " + n + "]" + from + "->" + to);
                Hanoi(n - 1, by, from, to);
            }

        }
        #endregion
        static void Main(string[] args)
        {
            #region 백트래킹(하노이탑)
            // 해를 찾아가는 도중에 지금의 경로가 해가 될것 같지 않으면,
            //더 이상 깊에 들어가지 않고, 이전 단계로 돌아가는 알고리즘


            //백트래킹의 유망성 판단
            //해가 될 만하지 판단한 후에 유망하지 않다고 결정된면.
            //ㄱ, 노드의 이전 노드로 돌아가 다음자식 노드로 이동

            //해가 될만한 가능성이 있다면 유망하다.(promising)
            //유망하지 않은 노드에 가지 않는것 (pruning)

            Hanoi(3, 'a', 'b', 'c');
            #endregion
        }
    }
}
