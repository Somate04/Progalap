namespace loverseny
{
    internal class Program
    {
        static int n;
        static int[] nyeremeny;

        static int osszeg(ref int i)
        {
            int s = 0;
            for(int j = 0; j <= i; j++)
            {
                s += nyeremeny[j];
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            nyeremeny = new int[n];
            for(int i = 0; i < n; i++)
            {
                nyeremeny[i] = int.Parse(Console.ReadLine());
            }

            int j = 0;
            while(j < n && osszeg(ref j) >= 0)
            {
                j++;
            }
            int ind = j+1;
            Console.WriteLine(ind);
        }
    }
}