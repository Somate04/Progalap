namespace probaevfolyamzh
{
    internal class Program
    {
        static int n;
        static int m;
        static int[,] orok;
        static int[] napok;

        static void beolvasas()
        {
            string[] sor = Console.ReadLine().Split();
            m = int.Parse(sor[0]);
            n = int.Parse(sor[1]);
            orok = new int[n, 2];
            napok = new int[m];
            for(int i = 0; i <n; i++)
            {
                sor = Console.ReadLine().Split();
                orok[i, 0] = int.Parse(sor[0]);
                orok[i, 1] = int.Parse(sor[1]);
                for(int j = orok[i, 0] - 1; j < orok[i, 1]; j++)
                {
                    napok[j]++;
                }
            }

        }

        static void elso()
        {
            int maxnapok = orok[0, 1] - orok[0, 0] + 1;
            for(int i = 0; i < n; i++)
            {
                if(maxnapok < orok[i,1] - orok[i, 0] + 1)
                {
                    maxnapok = orok[i, 1] - orok[i, 0] + 1;
                }
            }
            Console.WriteLine(maxnapok);
        }

        static void masodik()
        {
            for(int i =0; i < n; i++)
            {
                Console.Write(napok[i] + " ");
            }
            Console.WriteLine();
        }

        static void harmadik()
        {
            int maxind = 0;
            for(int i = 0; i < n; i++)
            {
                if (napok[maxind] < napok[i])
                {
                    maxind = i;
                }
            }
            Console.WriteLine(maxind + 1);
        }

        static void negyedik()
        {
            int e = -1;
            int u = -1;

            for (int i = 0; i < m; i++)
            {
                if (napok[i] < 2)
                {
                    int j = i + 1;
                    while (j < m && napok[j] < 2)
                    {
                        j++;
                    }
                    if (j == m)
                    {
                        j--;
                    }
                    if ((e == -1 && u == -1) || ((u - e) < (j - i)))
                    {
                        e = i;
                        u = j;
                    }
                }
            }

            if (e == -1 && u == -1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine((e + 1) + " " + (u + 1));
            }

        }

        static void Main(string[] args)
        {
            beolvasas();
            elso();
            masodik();
            harmadik();
            negyedik();
        }
    }
}