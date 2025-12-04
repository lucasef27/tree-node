using System;
using System.Linq;

public class TreeBuilder
{
    public static TreeNode BuildTree(int[] array)
    {
        if (array == null || array.Length == 0)
            return null;

        int maxValue = array.Max();
        int maxIndex = Array.IndexOf(array, maxValue);

        TreeNode root = new TreeNode(maxValue);

        int[] left = array
            .Take(maxIndex)
            .OrderByDescending(x => x)
            .ToArray();

        int[] right = array
            .Skip(maxIndex + 1)
            .OrderByDescending(x => x)
            .ToArray();

        root.Left = BuildTree(left);
        root.Right = BuildTree(right);

        return root;
    }
}
