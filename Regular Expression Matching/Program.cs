using System.Text.RegularExpressions;

namespace Regular_Expression_Matching {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
            Console.WriteLine( IsMatch( "aa", "a" ) );
            Console.WriteLine( IsMatch( "aa", "a*" ) );
            Console.WriteLine( IsMatch( "ab", ".*" ) );
            Console.WriteLine( IsMatch( "aab", "c*a*b" ) );
            Console.ReadLine( );
        }

        public static bool IsMatch( string s, string p ) {
            Match m = Regex.Match( s, p );

            if (m.Success) {
                return m.Value == s;
            }

            return false;
        }
    }
}
