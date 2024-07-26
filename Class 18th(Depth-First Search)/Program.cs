namespace Class_18th_Depth_First_Search_
{
    public class Graph
    {
        private int arrraySize;
        private int size;

        private List<int>[] graph;
        private bool[] visited;


        public Graph()
        {
            arrraySize = 8;
            size = 0;

            graph = new List<int>[arrraySize];
            visited = new bool[arrraySize];

            for (int i = 0; i < arrraySize; i++)
            {
                graph[i] = new List<int>();
            }
        }


        public void lnsert(int vertex, int edge)
        {
            graph[vertex].Add(edge);
            graph[edge].Add(vertex);
        }

        public void Show()
        {
            for (int i = 0; i < graph.Length; i++)
            {
                for (int j = 0; j < graph[i].Count; j++)
                {
                    Console.Write(graph[i][j] + ", ");
                }
                Console.WriteLine();
            }
        }


        public void Search(int start)
        {

            if (visited[start] == false)
            {
                visited[start] = true;
                Console.WriteLine(start);


                for (int i = 0; i < graph[start].Count; i++)
                {
                    int number = graph[start][i];

                    if (visited[number] == false)
                    {
                        Search(number);
                    }

                }

            }
            #region 강사님 풀이
            ////1. 현재 노드를 방문한 것으로 표시
            //visited[start] = true;
            ////2. 현재 노드를 출력한다.
            //Console.Write(start + " ");

            ////3.현재 노드와 연결된 다른 노드를 재뒤적으로 방문

            //for(int i=0; i < graph[start].Count; i++)
            //{
            //    //4. 현재 노드와 연결된 다음 노드를 가져옵니다.
            //    int next = graph[start][i];

            //    if (visited[next] == false)
            //    {
            //        //다음 노드가 방문하지 않은 노드라면 재귀 호출
            //        Search(next);
            //    }
            //}
            #endregion

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 깊이 우선 탐색 

            //root 노드에서 시작해서 다음 분기로 넘어가기전에 
            //해당 분기를 완벽하게 탐색하는 방법


            // 1. 시작 노드를 스택에 넣고 방문 처리한다.
            //2. 스택의 최상단 노드에 방문하지 않은 인저 노드가 
            //있으면 그 노드를 스택에 넣고 방문 처리

            //3. 방문하지 않은 인접 노드가 없으면 스택에서 최상단 노드를 꺼냅니다.

            //4.더 이상 2버느이 과정을 수행할수 없을때까지 반복 

            // bool[] arrray = new bool[4];

            //for (int i = 0; i < arrray.Length; i++) 
            //{
            //    Console.WriteLine(arrray[i]);   
            //}

            Graph graph = new Graph();

            graph.lnsert(1, 2);
            graph.lnsert(1, 3);

            graph.lnsert(2, 3);

            graph.lnsert(2, 4);
            graph.lnsert(2, 5);

            graph.lnsert(3, 6);
            graph.lnsert(3, 7);

            graph.lnsert(4, 5);
            graph.lnsert(6, 7);

            //graph.Show();

            graph.Search(1);
            #endregion
        }
    }
}
