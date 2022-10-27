using System.Collections.Generic;
namespace konyvtar

{
    internal class Program
    {
        public struct Rendeles
        {
            public int kkod;
            public int tkod;
            public int ev;
            public int db;
        }

        public struct kodDb
        {
            public int kod;
            public int db;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Rendeles[] x = new Rendeles[n];

            for( int i = 0; i < n; i++)
            {
                string[] sor = Console.ReadLine().Split();
                x[i].kkod = int.Parse(sor[0]);
                x[i].tkod = int.Parse(sor[1]);
                x[i].ev = int.Parse(sor[2]);
                x[i].db = int.Parse(sor[3]);
            }

            //1.
            Console.WriteLine("#");
            int ev = 0;
            int mindb = n*100 + 1;
            int db = x[0].db;
            for(int i = 1; i < n; i++)
            {
                if (x[i].ev == x[i - 1].ev)
                {
                    db += x[i].db;
                }
                else
                {
                    if(mindb < db)
                    {
                        mindb = db;
                        ev = x[i - 1].ev;
                    }
                    db = x[i].db;
                }
            }

            if(mindb > db)
            {
                ev = x[n -1].ev;
            }
            Console.WriteLine(ev);

            //2.
            Console.WriteLine("#");
            List<int> list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                if (!list.Contains(x[i].ev))
                {
                    list.Add(x[i].ev);
                }
            }
            Console.WriteLine(list.Count);
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            //3
            Console.WriteLine("#");
            List<kodDb> kodDbs = new List<kodDb>();
            kodDbs.Add (new kodDb() { kod = x[0].kkod, db = x[0].db });
            for(int i = 0; i < n; i++)
            {
                // if(kodDbs.Any(item => item.kod == x[i].kkod))
                int j = 0;
                while (j < kodDbs.Count && kodDbs[j].kod != x[i].kkod)
                {
                    j++;
                }
                if(j == kodDbs.Count)
                {
                    kodDbs.Add(new kodDb() { kod = x[i].kkod, db = x[i].db });
                }
                else
                {
                    int ijDb = kodDbs[j].db + x[i].db;
                    kodDbs[j] = new kodDb() { kod = x[i].kkod, db = x[i].db };
                }
            }
            int maxInd = 0;
            for(int i = 0; i < kodDbs.Count; i++)
            {
                if (kodDbs[i].db > kodDbs[maxInd].db)
                {
                    maxInd = i;
                }

            }
            Console.WriteLine(kodDbs[maxInd].kod);
        }
    }
}