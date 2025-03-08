namespace FindMissingRepeatedValues {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
            Console.WriteLine( string.Join(", ", FindMissingRepeatedValues( new int[][] {
                    new int[] { 9, 1, 7 },
                    new int[] { 8, 9, 2 },
                    new int[] { 3, 4, 6 }
                } ) ) );
            Console.WriteLine( string.Join(", ", FindMissingRepeatedValues( new int[][] {
                    new int[] { 1, 3 },
                    new int[] { 2, 2 }
                } ) ) );
            Console.ReadLine( );
        }

        public static int[] FindMissingRepeatedValues( int[][] grid ) {
            Dictionary<int, int> dict = new Dictionary<int, int>( );
            foreach (int[] row in grid.AsSpan()) {
                foreach (int value in row.AsSpan()) {
                    if (!dict.TryAdd( value, 1 )) dict[value]++;
                }
            }
            //var sortedList = dict.OrderBy( x => x.Key ).ToList( );
            var multipleValues = dict.ToList().Where( x => x.Value > 1 ).Select( x => x.Key );
            int maxValue = grid.Length * grid[0].Length;
            var missingValues = Enumerable.Range(1, maxValue).Where(x => !dict.ContainsKey(x));
            return multipleValues.Concat( missingValues ).ToArray( );
        }
    }
}
