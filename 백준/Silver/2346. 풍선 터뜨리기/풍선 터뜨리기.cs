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

        SetDeque(deque, size);
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
            front = (front + 1) % size;
            return deque[front];
        }

        public int PopBack()
        {
            int curBack = back;
            back = (size + back - 1) % size;
            return deque[curBack];
        }
    }

    static void SetDeque(Deque deque, int size)
    {
        for (int i = 1; i <= size; ++i)
        {
            deque.PushBack(i);
        }
    }

    static void ManageDeque(Deque deque, int size)
    {
        int move;
        int index;
        int[] input;
        
        input = Array.ConvertAll(SR.ReadLine().Split(), int.Parse);

        index = deque.PopFront();
        PrintResult(index);
        for (int i = 1; i < size; ++i)
        {
            move = input[index - 1];
            
            if (move > 0)
            {
                for (int j = 1; j < move; ++j)
                {
                    deque.PushBack(deque.PopFront());
                }
                index = deque.PopFront();
            }
            else
            {
                for (int j = 1; j < -move; ++j)
                {
                    deque.PushFront(deque.PopBack());
                }
                index = deque.PopBack();
            }
            PrintResult(index);
        }
    }

    static void PrintResult(int num)
    {
        SW.Write($"{num} ");
    }
}