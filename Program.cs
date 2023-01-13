
namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree binary = new BinaryTree();
            binary.Add(30);
            binary.Add(40);
            binary.Add(50);
            binary.Add(60);
            binary.Add(80);
            Console.WriteLine("After Preorder Result Will be: ");
            binary.TravesrePreorder(binary.root);
            Console.WriteLine("After Postorder Result Will be: ");
            binary.TravesrePostorder(binary.root);
            Console.WriteLine("After Inorder Result Will be: ");
            binary.TravesreInorder(binary.root);
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

            Console.WriteLine("Enter the node Element which You want to search:");
            int w = Convert.ToInt32(Console.ReadLine());
            bool t = binary.Search(w);
            if (t)
                Console.WriteLine("Searching Element is present:");
            else
                Console.WriteLine("Searching Element is not present");
        }

    }

}

