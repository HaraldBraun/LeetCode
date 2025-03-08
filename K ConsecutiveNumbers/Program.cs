namespace K_ConsecutiveNumbers {
    internal class Program {
        static void Main( string[] args ) {
            Console.WriteLine( "Hello, World!" );
            Console.WriteLine( MinimumRecolors( "WBBWWBBWBW", 7 ) ); // Ausgabe: 3
            Console.WriteLine( MinimumRecolors( "WBWBBBW", 2 ) );    // Ausgabe: 0
            Console.ReadLine( );
        }

        public static int MinimumRecolors( string blocks, int k ) {
            int n = blocks.Length;
            int minOps = 0;

            // Zähle die Anzahl der 'W' im ersten Fenster der Größe k
            for (int i = 0; i < k; i++) {
                if (blocks[i] == 'W')
                    minOps++;
            }

            int currentOps = minOps;

            // Sliding Window über den Rest des Strings
            for (int i = k; i < n; i++) {
                // Entferne das linke Zeichen aus dem vorherigen Fenster
                if (blocks[i - k] == 'W')
                    currentOps--;

                // Füge das neue rechte Zeichen zum Fenster hinzu
                if (blocks[i] == 'W')
                    currentOps++;

                // Aktualisiere das Minimum der Operationen
                minOps = Math.Min( minOps, currentOps );
            }

            return minOps;
        }
    }
}
