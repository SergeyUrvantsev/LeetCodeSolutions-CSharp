namespace LeetCode.Solutions.Common
{
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

        // Static method to create a TreeNode from an array of integers
        public static TreeNode FromArray(int[] arr)
        {
            if (arr == null || arr.Length == 0) return null;

            TreeNode root = new TreeNode(arr[0]);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int i = 1;
            while (i < arr.Length)
            {
                TreeNode current = queue.Dequeue();

                if (i < arr.Length && arr[i] != -1)
                {
                    current.left = new TreeNode(arr[i]);
                    queue.Enqueue(current.left);
                }
                i++;

                if (i < arr.Length && arr[i] != -1)
                {
                    current.right = new TreeNode(arr[i]);
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }
    }
}