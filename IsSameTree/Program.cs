namespace IsSameTree {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
        }

        public bool IsSameTree(TreeNode p, TreeNode q) {
            if (p == null && q == null) {
                return true;
            }
            if (p == null || q == null) {
                return false;
            }
            if (p.val != q.val) {
                return false;
            }
            return IsSameTree( p.left, q.left ) && IsSameTree( p.right, q.right );
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
