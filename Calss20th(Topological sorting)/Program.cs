namespace Calss20th_Topological_sorting_
{
    class Graph
    {
        private int arraySize;

        private int[] array;
        private List<int>[] graph;

        private Queue<int> quequ;

        public Graph()
        {
            arraySize = 8;

            array = new int[arraySize];
            quequ = new Queue<int>();
            graph = new List<int>[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                graph[i] = new List<int>();
            }

        }

        public void Insert(int vertex, int edge)
        {
            graph[vertex].Add(edge);

            array[edge]++;
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

        public void Show2()
        {
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine(i + "의 진입 차수는 :" + array[i] + ", ");
            }
        }

        public void Sorch()
        {
            for (int i = 1; i < arraySize; i++)
            {
                if (array[i] == 0)
                {
                    quequ.Enqueue(i);
                }
            }

            while (quequ.Count > 0)
            {
                int x = quequ.Dequeue();

                Console.WriteLine(x + " ");


                for (int i = 0; i < graph[x].Count; i++)
                {
                    int start = graph[x][i];

                    array[start]--;

                    if (array[start] == 0)
                    {
                        quequ.Enqueue(start);
                    }
                }
            }

        }

    }
    internal class Program
    {

        static void Main(string[] args)
        {
            #region  위상 정렬
            // 방향 그래프에 존재 하는 각 정점들의선행 순서를 지키며,
            //모든 정점들 차레때로 진행ㅎ는 알고리즘

            // 사이클이 발생하는 경우 위상 정렬 수행 x

            //DAG(DIRECTED ACYCLIC GRAPH) : 사이클이 존재하지 않는 그래프

            //시간복잡도 :O(V +E)

            //위상 정렬 하는 방법
            /*
             * 1. 진입 차수가 0인 정점을 큐에 삽입
             * 2.큐에서 원소를 꺼내 연결된 모든 간선을 제거
             * 3.가선 제거 이후에 진입 차수가ㅣ 0 인 된정점을 큐에 삽입
             * 4.큐가 비어있을깨까지 2번 3번 반복 수행
             */


            Graph graph = new Graph();
            graph.Insert(1, 2);
            graph.Insert(1, 5);

            graph.Insert(2, 3);

            graph.Insert(5, 6);

            graph.Insert(3, 4);

            graph.Insert(6, 4);

            graph.Insert(4, 7);


            //graph.Show();

            //graph.Show2();

            graph.Sorch();
            #endregion
        }
    }
}
