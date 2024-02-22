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
        double media = 0, min = 0, max = 0;
        Statistiche(ref pesi, ref media, ref min, ref max);
        Console.WriteLine($"Media: {media}, Minimo: {min}, Massimo: {max}");
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
    static void Statistiche(ref double[] pesi, ref double media, ref double min, ref double max)
    {
        double somma = 0;
        min = pesi[0];
        max = pesi[0];
        foreach (double peso in pesi)
        {
            somma += peso;
            if (peso < min)
                min = peso;
            if (peso > max)
                max = peso;
        }
        media = somma / pesi.Length;
    }
}