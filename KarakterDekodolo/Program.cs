namespace KarakterDekodolo
{
    internal class Program
    {
        static List<Karakter> Karakterek = new();
        static char betu = '-';
        static void Main(string[] args)
        {
            KarakterekBeolvasasa();
            Feladat05();
            Feladat06();
            Feladat07();
        }

        private static void Feladat07()
        {
            int i = 0;
            while (i < Karakterek.Count && Karakterek[i].Betu != betu) i++;
            {
                Console.WriteLine("7. Feladat:");
                if (i < Karakterek.Count)
                {
                    Console.Write("\n");
                    for (int s = 0; s < Karakterek[i].Matrix.GetLength(0); s++)
                    {
                        for (int o = 0; o < Karakterek[i].Matrix.GetLength(1); o++)
                        {
                            if (Karakterek[i].Matrix[s, o] == 1)
                                Console.Write("X");
                            else Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                    
                }
                else Console.WriteLine("Nincs ilyen karakter a bankban!");
            }
        }

        private static void Feladat06()
        {
            string Valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine();

            while (!Valid.Contains(betu))
            {
                Console.Write("6. Feladat: Kérek egy angol nagybetűt:");
                string AngolNagybetu = Console.ReadLine();

                if(AngolNagybetu.Length==1)
                {
                    betu = char.Parse(AngolNagybetu);
                }

            }
        }

        private static void Feladat05()
        {
            Console.WriteLine($"5. Feladat: Karakterek száma: {Karakterek.Count}");
        }

        private static void KarakterekBeolvasasa()
        {
            using StreamReader sr = new(@"..\..\..\src\bank.txt");
            while (!sr.EndOfStream)
            {
                char Betu = char.Parse(sr.ReadLine());
                int[,] Matrix = new int[7, 4];
                for (int s = 0; s < Matrix.GetLength(0); s++)
                {
                    string teljesSor = sr.ReadLine();
                    for (int o = 0; o < teljesSor.Length; o++)
                    {
                        Matrix[s, o] = int.Parse(teljesSor[o].ToString());
                    }
                }

                Karakterek.Add(new Karakter(Betu,Matrix));

            }
        }
    }
}