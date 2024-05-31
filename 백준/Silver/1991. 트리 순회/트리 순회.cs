public class Program
{
    static StreamReader SR = new StreamReader(Console.OpenStandardInput());
    static StreamWriter SW = new StreamWriter(Console.OpenStandardOutput());

    static int size;
    static Node[] nodes;

    struct Node
    {
        public char left;
        public char right;

        public Node(char left, char right)
        {
            this.left = left;
            this.right = right;
        }
    }

    static void Main(string[] args)
    {
        size = int.Parse(SR.ReadLine());
        nodes = new Node[26];

        SetTree();

        Preorder('A');
        SW.WriteLine();

        Inorder('A');
        SW.WriteLine();

        Postorder('A');
        SW.WriteLine();

        SR.Close();
        SW.Close();
    }

    static void SetTree()
    {
        char[] input;

        for (int i = 0; i < size; ++i)
        {
            input = Array.ConvertAll(SR.ReadLine().Split(), char.Parse);
            nodes[input[0] - 'A'] = new Node(input[1], input[2]);
        }
    }

    static void Preorder(char id)
    {
        if (id == '.')
        {
            return;
        }
        SW.Write(id);
        Preorder(nodes[id - 'A'].left);
        Preorder(nodes[id - 'A'].right);
    }

    static void Inorder(char id)
    {
        if (id == '.')
        {
            return;
        }
        Inorder(nodes[id - 'A'].left);
        SW.Write(id);
        Inorder(nodes[id - 'A'].right);
    }

    static void Postorder(char id)
    {
        if (id == '.')
        {
            return;
        }
        Postorder(nodes[id - 'A'].left);
        Postorder(nodes[id - 'A'].right);
        SW.Write(id);
    }
}