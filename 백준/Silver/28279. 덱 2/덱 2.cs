using System;

public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static void Main(string[] args)
    {
        Deque deque;
        int size;

        size = int.Parse(SR.ReadLine());
        deque = new Deque(size);
        ManageDeque(deque, size);

        SW.Flush();
        SR.Close();
        SW.Close();
    }

    public class Deque
    {
        int[] deque;
        int front = 0;
        int back = 0;
        int size;

        public Deque(int size)
        {
            deque = new int[size];
            this.size = size;
        }

        public void PushFront(int num)
        {
            deque[front] = num;
            front = (size + front - 1) % size;
        }

        public void PushBack(int num)
        {
            back = (back + 1) % size;
            deque[back] = num;
        }

        public int PopFront()
        {
            if (IsEmpty())
            {
                return -1;
            }
            front = (front + 1) % size;
            return deque[front];
        }

        public int PopBack()
        {
            int curBack = back;
            if (IsEmpty())
            {
                return -1;
            }
            back = (size + back - 1) % size;
            return deque[curBack];
        }

        public int Size()
        {
            return (size - front + back) % size;
        }

        public int Empty()
        {
            return IsEmpty() ? 1 : 0;
        }

        public int Front()
        {
            return IsEmpty() ? -1 : deque[(front + 1) % size];
        }

        public int Back()
        {
            return IsEmpty() ? -1 : deque[back];
        }

        private bool IsEmpty()
        {
            return front == back;
        }
    }

    static void ManageDeque(Deque deque, int size)
    {
        string[] input;

        for (int i = 0; i < size; ++i)
        {
            input = SR.ReadLine().Split();

            switch (input[0])
            {
                case "1":
                    deque.PushFront(int.Parse(input[1]));
                    break;
                case "2":
                    deque.PushBack(int.Parse(input[1]));
                    break;
                case "3":
                    PrintResult(deque.PopFront());
                    break;
                case "4":
                    PrintResult(deque.PopBack());
                    break;
                case "5":
                    PrintResult(deque.Size());
                    break;
                case "6":
                    PrintResult(deque.Empty());
                    break;
                case "7":
                    PrintResult(deque.Front());
                    break;
                case "8":
                    PrintResult(deque.Back());
                    break;
            }
        }
    }

    static void PrintResult(int num)
    {
        SW.WriteLine(num);
    }
}