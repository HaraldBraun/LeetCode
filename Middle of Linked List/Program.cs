namespace Middle_of_Linked_List {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );

            Console.WriteLine( MiddleNode( new ListNode( 1, new ListNode( 2, new ListNode( 3, new ListNode( 4, new ListNode( 5, new ListNode( 6 ) ) ) ) ) ) ).val );

            
            Console.ReadLine( );
        }

        public static ListNode MiddleNode( ListNode head ) {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null) {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode( int val = 0, ListNode next = null ) {
                this.val = val;
                this.next = next;
            }
        }
    }
}
