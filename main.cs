using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Aplikasi Calculator";

        Console.Write("Inputkan nilai a = ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Inputkan nilai b = ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));

        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();
    }

    static int Penambahan(int a, int b)
    {
        return a + b;
    }

    static int Pengurangan(int a, int b)
    {
        return a - b;
    }
}
