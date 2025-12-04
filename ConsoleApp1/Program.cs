using System;

class Program
{
    static void PrintTree(TreeNode node, string indent = "", bool isLeft = true)
    {
        if (node == null) return;

        Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.Value);
        string nextIndent = indent + (isLeft ? "│   " : "    ");

        PrintTree(node.Left, nextIndent, true);
        PrintTree(node.Right, nextIndent, false);
    }

static void Main()
{
    var arrays = new List<int[]>
    {
        new [] { 3, 2, 1, 6, 0, 5 },
        new [] { 7, 5, 13, 9, 1, 6, 4},
       
    };

    int index = 1;
    foreach (var arr in arrays)
    {
        Console.WriteLine($"\n--- Árvore #{index} (Array: [{string.Join(", ", arr)}]) ---");

        TreeNode tree = TreeBuilder.BuildTree(arr);
        PrintTree(tree);

        index++;
    }
}
}
