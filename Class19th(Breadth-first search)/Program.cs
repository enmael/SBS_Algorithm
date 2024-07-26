namespace Class19th_Breadth_first_search_
{
    class Graph
    {
        private int arraySize;

        private Queue<int> queue;
        private bool[] array;
        private List<int>[] graph;

        public Graph()
        {
            arraySize = 8;

            array = new bool[arraySize];
            graph = new List<int>[arraySize];
            queue = new Queue<int>();

            for (int i = 0; i < arraySize; i++)
            {
                graph[i] = new List<int>();
            }

        }

        public void Insert(int vertex, int edge)
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
            //int x = 0;

            //if (array[start] ==false) 
            //{
            //    array[start] = true;
            //    queue.Enqueue(start);

            //    while (queue.Count > 0) 
            //    {
            //        x = queue.Peek();
            //        Console.Write(x + ", ");
            //        queue.Dequeue();

            //        for (int i = 0;i < graph[x].Count; i++)
            //        {
            //            if (array[])
            //        }

            //    }

            //}

            queue.Enqueue(start);
            array[start] = true;

            while (queue.Count > 0)
            {
                int x = queue.Dequeue();
                Console.Write(x + ", ");

                for (int i = 0; i < graph[x].Count; i++)
                {
                    int next = graph[x][i];

                    if (array[next] == false)
                    {
                        queue.Enqueue(next);
                        array[next] = true;
                    }
                }
            }

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 너비 우선 탐색 
            // 시작 정점을 반문한 후 시작 정점에 인접한 모든 정점들을 
            //우선 방문하는 방법 입니다.

            //더이상 방문하지 않은 정점이 없을 때 까지 방문하지 
            //않은 모든 정점들에 대해서도 너비 우선 탐색을 적용한다.

            Graph graph = new Graph();

            graph.Insert(1, 2);
            graph.Insert(1, 3);

            graph.Insert(2, 3);

            graph.Insert(2, 4);
            graph.Insert(2, 5);

            graph.Insert(3, 6);
            graph.Insert(3, 7);

            graph.Insert(4, 5);
            graph.Insert(6, 7);

            //graph.Show();

            graph.Search(1);

            #endregion
        }
    }
}
