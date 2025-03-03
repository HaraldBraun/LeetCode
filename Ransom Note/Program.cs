namespace Ransom_Note {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
        }

        public static bool CanConstruct( string ransomNote, string magazine ) {
            Dictionary<char, int> ransomNoteDict = new Dictionary<char, int>( );
            Dictionary<char, int> magazineDict = new Dictionary<char, int>( );
            foreach (char c in ransomNote) {
                if (ransomNoteDict.ContainsKey( c )) {
                    ransomNoteDict[c]++;
                } else {
                    ransomNoteDict.Add( c, 1 );
                }
            }
            foreach (char c in magazine) {
                if (magazineDict.ContainsKey( c )) {
                    magazineDict[c]++;
                } else {
                    magazineDict.Add( c, 1 );
                }
            }
            foreach (KeyValuePair<char, int> pair in ransomNoteDict) {
                if (!magazineDict.ContainsKey( pair.Key ) || magazineDict[pair.Key] < pair.Value) {
                    return false;
                }
            }
            return true;
        }
    }
}
