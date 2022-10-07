namespace KarakterDekodolo
{
    internal class Karakter
    {

        public char Betu { get; set; }
        public int[,] Matrix { get; set; }

        public Karakter(char betu, int[,] matrix)
        {
            Betu = betu;
            Matrix = matrix;
        }
    }
}
