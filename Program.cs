using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enrico Spagnoli, 3G, Esercizio sugli array");
        Console.Write("Inserire il numero di persone: ");
        int dim = Convert.ToInt32(Console.ReadLine());
        double[] pesi = new double[dim];
        int[] eta = new int[dim];
        CaricaVettori(ref pesi, ref eta, dim);
    }
    static void CaricaVettori(ref double[] pesi, ref int[] eta, int elementi)
    {
        Random random = new Random();
        for (int i = 0; i < elementi; i++)
        {
            pesi[i] = random.Next(50, 101);
            eta[i] = random.Next(18, 100);
        }
    }
}