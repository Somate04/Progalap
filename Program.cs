

namespace magassagdiszkriminacio
{
    internal class Program
    {
        public struct Nber
        {
            public string nev;
            public double magassag;
        }
        static void Main(string[] args)
        {
            int n;
            while(!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("NEEEEEEEEEEEEEEEEEEEM\nNEEEEEEEEEEEEEEEEEM\nMEGÖLLLLLLEK\nTE KURVAAAAA");
            }
            List<Nber> x = new List<Nber>();
            for(int i = 0; i < n; i++)
            {
                Nber ert;
                ert.nev = Console.ReadLine();
                while (!double.TryParse(Console.ReadLine(), out ert.magassag) || ert.magassag <= 0)
                {
                    Console.WriteLine("NEEEEEEEEEEEEEEEEEEEM");
                }

                x.Add(ert);
            }
            List<string> y1 = new List<string>();
            List<string> y2 = new List<string>();
            List<string> y3 = new List<string>();

            for(int i = 0; i < n; i++)
            {
                if (x[i].magassag < 140)
                {
                    y1.Add(x[i].nev);
                }
                else if (x[i].magassag >= 180)
                {
                    y3.Add(x[i].nev);
                }
                else
                {
                    y2.Add(x[i].nev);
                }
            }
            Console.WriteLine("<140");
            for (int i = 0; i < y1.Count; i++)
            {
                Console.Write(y1[i] + " ");
            }
            Console.WriteLine("\n140<=x<180");
            for (int i = 0; i < y2.Count; i++)
            {
                Console.Write(y2[i] + " ");
            }
            Console.WriteLine("\n>180");
            for (int i = 0; i < y3.Count; i++)
            {
                Console.Write(y3[i] + " ");
            }


        }
    }
}