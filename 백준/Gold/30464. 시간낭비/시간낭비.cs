public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        int size = int.Parse(SR.ReadLine());
        int[] arr = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        int[][] distance = new int[size][];

        for (int i = 0; i < size; ++i)
        {
            distance[i] = new int[3];
            for (int j = 0; j < 3; ++j)
            {
                distance[i][j] = -1;
            }
        }

        Dijkstra(size, arr, distance);
        SW.WriteLine(Math.Max(distance[size - 1][0], Math.Max(distance[size - 1][1], distance[size - 1][2])));

        SR.Close();
        SW.Close();
    }

    static void Dijkstra(int size, int[] graph, int[][] distance)
    {
        PriorityQueue<(int, int, int), int> pq = new PriorityQueue<(int, int, int), int>();
        int[] dx = { 1, -1 };
        int nx;
        int index;

        pq.Enqueue((0, 0, 0), 0);
        distance[0][0] = 0;
        while (pq.Count > 0)
        {
            var (dist, changeCnt, vx) = pq.Dequeue();
            dist *= -1;

            if (graph[vx] == 0 || distance[vx][changeCnt] > dist || vx == size - 1)
            {
                continue;
            }

            if (changeCnt != 2 && dist > distance[vx][changeCnt + 1])
            {
                distance[vx][changeCnt + 1] = dist;
                pq.Enqueue((-dist, changeCnt + 1, vx), -dist);
            }

            index = changeCnt % 2;
            nx = vx + graph[vx] * dx[index];
            if (nx < 0 || nx >= size || distance[nx][changeCnt] >= dist + 1)
            {
                continue;
            }

            distance[nx][changeCnt] = dist + 1;
            pq.Enqueue((-dist - 1, changeCnt, nx), -dist - 1);
        }
    }
}