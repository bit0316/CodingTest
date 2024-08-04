public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static int chicken;
    static int result;
    static List<(int, int)> house;
    static List<(int, int)> restaurant;
    static int[] input;
    static int[] distances;
    static bool[] visited;

    static void Main(string[] args)
    {
        int result;

        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
        size = input[0];
        chicken = input[1];

        SetMap();
        GetResult();
        PrintResult();

        SR.Close();
        SW.Close();
    }

    static void SetMap()
    {
        house = new List<(int, int)>();
        restaurant = new List<(int, int)>();

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);
            for (int j = 0; j < size; ++j)
            {
                if (input[j] == 1)
                {
                    house.Add((i, j));
                }
                else if (input[j] == 2)
                {
                    restaurant.Add((i, j));
                }
            }
        }
    }

    static void GetResult()
    {
        result = int.MaxValue;
        visited = new bool[restaurant.Count];
        distances = new int[house.Count * restaurant.Count];

        for (int i = 0; i < house.Count; ++i)
        {
            for (int j = 0; j < restaurant.Count; ++j)
            {
                distances[i * restaurant.Count + j] = Math.Abs(house[i].Item1 - restaurant[j].Item1) + Math.Abs(house[i].Item2 - restaurant[j].Item2);
            }
        }

        for (int i = 0; i <= restaurant.Count - chicken; ++i)
        {
            BackTracking(i, 0);
        }
    }

    static void BackTracking(int index, int count)
    {
        if (count == chicken)
        {
            GetDistance();
            return;
        }

        if (index < restaurant.Count)
        {
            visited[index] = true;
            BackTracking(index + 1, count + 1);
            visited[index] = false;
            BackTracking(index + 1, count);
        }
    }

    static void GetDistance()
    {
        int distance = 0;
        int min;

        for (int i = 0; i < house.Count; ++i)
        {
            min = int.MaxValue;
            for (int j = 0; j < restaurant.Count; ++j)
            {
                if (visited[j])
                {
                    min = Math.Min(min, distances[i * restaurant.Count + j]);
                }
            }
            distance += min;
        }

        result = Math.Min(result, distance);
    }

    static void PrintResult()
    {
        SW.WriteLine(result);
    }
}