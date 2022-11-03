namespace ingatlan
{
    internal class Program
    {
        static void beolvasas(ref int n, ref int[][] lakasok)
        {
            n = Convert.ToInt32(Console.ReadLine());
            lakasok = new int[n][];
            for (int i = 0; i < n; i++)
            {
                lakasok[i] = new int[2];
                string sor = Console.ReadLine();
                lakasok[i][0] = Convert.ToInt32(sor.Split()[0]);
                lakasok[i][1] = Convert.ToInt32(sor.Split()[1]);
            }
        }

        static int elso(int n, int[][] lakasok)
        {
            int legdragabbInd = 0;
            for (int i = 0; i < n; i++)
            {
                if (lakasok[i][1] > lakasok[legdragabbInd][1])
                {
                    legdragabbInd = i;
                }
            }
            return legdragabbInd;
        }
        static int masokdik(int n, int[][] lakasok)
        {
            int olcsoDb = 0;
            for (int i = 0; i < n; i++)
            {
                if (lakasok[i][0] > 100 && lakasok[i][1] < 40)
                {
                    olcsoDb++;
                }
            }
            return olcsoDb;
        }

        static List<int> negyedik(int n, int[][] lakasok)
        {
            List<int> dragak = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (lakasok[i][1] > 100)
                {
                    dragak.Add(i);
                }
            }

            
            return dragak;
        }

        static void kiiras(int legdragabbInd, int olcsoDb, List<int> dragak)
        {
            Console.WriteLine(legdragabbInd + 1);
            Console.WriteLine(olcsoDb);
            Console.Write(dragak.Count);
            foreach(int i in dragak)
            {
                Console.Write(" " + (i +1));
            }
        }



        static void Main(string[] args)
        {
            int n = 1;
            int[][] lakasok = new int[1][];
            beolvasas(ref n, ref lakasok);
            int legdragabbInd = elso(n, lakasok);
            int olcsoDb = masokdik(n, lakasok);
            List<int> dragak = negyedik(n, lakasok);
            kiiras(legdragabbInd, olcsoDb, dragak);

            



            /*
6
42 15
110 20
125 160
166 180
42 10
110 39
            */



        }
        
    }
}