namespace Reverse_Integer {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
            int test = Reverse(-2147483648);
            Console.WriteLine( test );
            test = Reverse( -123 );
            Console.WriteLine( test );
            Console.ReadLine( );
        
        }

        public static int Reverse( int x ) {
            int result;
            bool isNegative = x < 0;
            try {
                char[] temp = Math.Abs( x ).ToString( ).ToCharArray( );
                Array.Reverse( temp );
                result = int.Parse( new string( temp ) );
            } catch (OverflowException) {
                return 0;
            }
            return isNegative ? result * -1 : result;
        }
    }
}
