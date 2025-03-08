namespace MirrorTree_BFS {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
        }

        public static bool IsSymetric(TreeNode root) {
            if ( root == null ) {
                return true;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>( );
            queue.Enqueue( root.left );
            queue.Enqueue( root.right );
            while (queue.Count > 0) {
                TreeNode left = queue.Dequeue( );
                TreeNode right = queue.Dequeue( );
                if (left == null && right == null) {
                    continue;
                }
                if (left == null || right == null || left.val != right.val) {
                    return false;
                }
                queue.Enqueue( left.left );
                queue.Enqueue( right.right );
                queue.Enqueue( left.right );
                queue.Enqueue( right.left );
            }
            return true;
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode( int val, TreeNode left, TreeNode right ) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
