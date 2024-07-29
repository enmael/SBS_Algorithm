namespace Class21th__Union_Find_
{
    class Graph
    {
        private int size;
        private int[] parent;

        public Graph()
        {
            size = 7;
            parent = new int[size];

            for (int i = 1; i < parent.Length; i++)
            {
                parent[i] = i;
            }
        }

        public void Union(int x, int y)
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
            }

        }

        public int Find(int x)
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

        public bool Same(int x, int y)
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

        public void Show()
        {
            for (int i = 1; i < size; i++)
            {
                Console.WriteLine(i + "번째 :" + parent[i]);
            }
            Console.WriteLine(" ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  유니온 파인드 
            /*
             * 여러 노드가 존재할때 어떤 두개의 노드를 같은 집합으로
             * 묶은 더움 오딴 두노드가같은 집합에 있는지 확인
             */

            Graph graph = new Graph();
            //graph.Union(1, 2);
            //graph.Union(4, 6);
            //graph.Show();
            //graph.Union(1, 2);
            //graph.Union(4, 6);


            graph.Union(2, 3);
            graph.Union(1, 3);
            graph.Show();
            #endregion
        }
    }
}
