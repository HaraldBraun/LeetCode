using System.Text.RegularExpressions;

namespace String_To_Integer {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
            string[] input = { "1337c0d3", "words and 987", "+-12" };
            foreach (string s in input) {
                Console.WriteLine( MyAtoi( s ) );
            }
            Console.ReadLine( );
        }

        public static int MyAtoi( string s ) {
            string pattern = @"^([+-])?([0-9])*([0-9a-zA-Z]){0}";
            s = s.Trim( );
            Match match = Regex.Match(s, pattern);
            if (!match.Success || match.Value == "") {
                return 0;
            }
            int ret;
            try {
                ret = int.Parse( match.Value );
            } catch (OverflowException) {
                long temp;
                try {
                    temp = long.Parse( match.Value );
                } catch (OverflowException) {
                    return match.Value[0] == '-' ? int.MinValue : int.MaxValue;
                }
                return ret = temp > int.MaxValue ? int.MaxValue : int.MinValue;
            } catch (FormatException) {
                return 0;
            }
            
            return ret;
        }
    }
}
