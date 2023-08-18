public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class BinaryTreeInorderTraversal {

    public static List<int> GetInorderTraversalIterative(TreeNode root) {
        List<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;

        while(stack.Count > 0 || current != null) {
            while(current != null) {
                stack.Push(current);
                current = current.left;
            }
            current = stack.Pop();
            result.Add(current.val);
            current = current.right;
        }
        return result;
    }

    List<int> result = new List<int>();
    public static void GetInorderTraversalRecursive(TreeNode root, List<int> result) {
        if(root == null) {
            return;
        }
        GetInorderTraversalRecursive(root.left, result);
        result.Add(root.val);
        GetInorderTraversalRecursive(root.right, result);
    }
}
