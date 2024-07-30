namespace Class22th_weighted_graph_
{
    internal class Program
    #region 신장트리
        class Graph
    {
        //public class Edge
        //{
        //    public int x;
        //    public int y;
        //    public int distance;
        //    private object get;

        //    public Edge()
        //    {
        //        this.x = 0;
        //        this.y = 0;
        //        this.distance = 0;
        //    }

        //    public int X()
        //    {
        //        get { return x; }
        //    }

        //    public int  Y(int y)
        //    {
        //        get { return y; }
        //    }

        //    public int Distance()
        //    {
        //        get { return distance; }
        //    }

        //}

        public class Edge : IComparable<Edge>
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Distance { get; set; }

            public Edge(int x, int y, int distance)
            {
                X = x;
                Y = y;
                Distance = distance;
            }

            public int CompareTo(Edge? other)
            {
                return Distance.CompareTo(other.Distance);
            }

        }

        int size;
        int sum;

        List<Edge> graph;
        int[] parent;

        public Graph()
        {
            size = 8;
            sum = 0;

            graph = new List<Edge>();
            parent = new int[size];

            for (int i = 1; i < parent.Length; i++)
            {
                parent[i] = i;
            }

        }

        public void Insert(int x, int y, int distance)
        {
            graph.Add(new Edge(x, y, distance));
            graph.Sort();
        }

        private void Union(int x, int y)
        {
            int number = 0;
            int arraySize = 0;
            if (x < y)
            {
                number = Find(x);
                arraySize = y;
            }
            else if (y < x)
            {
                number = Find(y);
                arraySize = x;
            }

            if (Same(number, arraySize) == true)
            {
                Console.WriteLine(number + "과 " + arraySize + " 은 " + "이미 연결된 노드 입니다.");
            }
            else
            {
                for (int i = number; i <= arraySize; i++)
                {
                    if (i <= size - 2)
                    {
                        parent[i + 1] = i;
                    }
                }
                //parent[arraySize] = number;
            }

        }

        private int Find(int x)
        {
            if (x == parent[x])
            {
                return x;
            }
            else
            {
                return Find(x - 1);
            }
        }

        private bool Same(int x, int y)
        {
            int number = 0;
            int arraySize = 0;
            if (x < y)
            {
                number = Find(x);
                arraySize = y;
            }
            else if (y < x)
            {
                number = Find(y);
                arraySize = x;
            }

            int count = arraySize - number;

            for (int i = number; i < arraySize; i++)
            {
                if (i <= size - 2)
                {
                    if (i == parent[i + 1])
                    {
                        count--;
                    }

                }
            }

            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }


        public void Kruskal()
        {
            int sum = 0;

            for (int i = 0; i < graph.Count; i++)
            {

                if (Same(graph[i].X, graph[i].Y) == false)
                {
                    sum = sum + graph[i].Distance;
                    Union(graph[i].X, graph[i].Y);
                }

            }
            Console.WriteLine("그래프의 최소 비용은 :" + sum);
        }
    }
    #endregion
    {
        static void Main(string[] args)
        {
            #region 신장 트리 
            // 그래프의 모든 정점을 포함하면서 사이클ㅇ ㅣ존재하지 않은 그래프로,
            // 그래프의 모든 정점을 최소 비용으로 연결하ㅡㄴㄴ 트리

            //그래프의 정점의 수가 N개 일때, 간선의 수는 N-1개이다.
            Graph graph = new Graph();

            graph.Insert(1, 7, 12);
            graph.Insert(1, 4, 28);
            graph.Insert(1, 2, 73);
            graph.Insert(1, 5, 17);

            graph.Insert(2, 4, 24);
            graph.Insert(2, 5, 62);

            graph.Insert(3, 5, 20);
            graph.Insert(3, 6, 35);


            graph.Insert(4, 7, 13);

            graph.Insert(5, 6, 40);

            graph.Kruskal();
            //최소 비용 신장 트리
            //그래프의 간선들의 가중치 합이 최소인 신장트리


            #endregion
        }
    }
}
