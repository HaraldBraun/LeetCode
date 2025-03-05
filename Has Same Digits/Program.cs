namespace Has_Same_Digits {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
            Console.WriteLine( HasSameDigits( "3902" ) );
            Console.WriteLine( HasSameDigits( "34789" ) );
            Console.ReadLine( );
        }

        public static bool HasSameDigits( string s ) {
            int[] numbers = s.Select(c => c -'0').ToArray();
            while (numbers.Length > 2) {
                numbers = AddPairs( numbers );
            }
            return numbers[0] == numbers[1];
        }

        private static int[] AddPairs( int[] numbers) {
            int[] result = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length - 1; i++) {
                result[i] = (numbers[i] + numbers[i + 1]) % 10;
            }
            return result;
        }
    }
}
