namespace gyak9
{
    internal class Program
    {

        static void prim()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            int s = 0;
            for (int i = n; i < m; i++)
            {
                int o = 0;
                for (int j = 2; j < i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        o++;
                    }
                }
                if (o == 0 && i > 1)
                {
                    s += i;
                }
            }
            Console.WriteLine(s);
        }

        static void eso()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] napok = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string sor = Console.ReadLine();
                napok[i] = new int[7];
                for (int j = 0; j < 7; j++)
                {
                    napok[i][j] = int.Parse(sor.Split()[j]);
                }

            }
            List<int> esos = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int e = 0;
                for (int j = 0; j < 7; j++)
                {
                    if (napok[i][j] > 0)
                    {
                        e++;
                    }
                }
                if (e >= 3)
                {
                    esos.Add(i);
                }
            }
            for(int i = 0; i < esos.Count; i++)
            {
                Console.WriteLine((esos[i] + 1) + " ");
            }
        }

        static void fagyi()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[][] szavazatok = new string[n][];
            for (int i = 0; i < n; i++)
            {
                szavazatok[i] = Console.ReadLine().Split();
            }
            int pontE = 0;
            int pontC = 0;
            int pontV = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (szavazatok[i][j].Equals("E"))
                    {
                        pontE += j;
                    }
                    else if (szavazatok[i][j].Equals("C"))
                    {
                        pontC += j;
                    }
                    else
                    {
                        pontV += j;
                    }
                }
            }
            if (pontE < pontV && pontE < pontC)
            {
                Console.WriteLine("E nyert!");
            }
            else if (pontC < pontE && pontC < pontV)
            {
                Console.WriteLine("C nyert!");
            }
            else if (pontV < pontC && pontV < pontE)
            {
                Console.WriteLine("V nyert!");
            }
            else
            {
                Console.WriteLine("Holtverseny!");
            }
        }

        static void Main(string[] args)
        {
            //prim számok összege
            prim();
            //esős hetek
            eso();
            //fagyi verseny szar
            fagyi();
        }
    }
}