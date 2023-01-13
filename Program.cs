
namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree binary = new BinaryTree();
            binary.Add(56);
            binary.Add(30);
            binary.Add(70);
            binary.Add(22);
            binary.Add(40);
            binary.Add(3);
            binary.Add(11);
            binary.Add(16);
            binary.Add(60);
            binary.Add(65);
            binary.Add(63);
            binary.Add(67);
            binary.Add(95);
            binary.Add(70);

            Console.WriteLine();
            Console.WriteLine("Preorder is: ");
            binary.TravesrePreorder(binary.root);
            Console.WriteLine();
            Console.WriteLine("Postorder is: ");
            binary.TravesrePostorder(binary.root);
            Console.WriteLine();
            Console.WriteLine("Inorder is: ");
            binary.TravesreInorder(binary.root);
            Console.WriteLine();
        }

    }
}
