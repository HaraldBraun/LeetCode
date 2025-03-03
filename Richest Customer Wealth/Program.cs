namespace Richest_Customer_Wealth {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
        }

        public static int MaximumWealth( int[][] accounts ) {
            int max = 0;
            foreach (int[] account in accounts) {
                int sum = 0;
                foreach (int i in account) {
                    sum += i;
                }
                max = Math.Max( max, sum );
            }
            return max;
        }
    }
}
