namespace pertemuan2;

class Program
{
    static void Main(string[] args)
    {
        Mahasiswa mhs1 = new Mahasiswa("John Doe", "1234567890","BCI");
        Mahasiswa mhs2 = new Mahasiswa("Jane Smith", "0987654321","BCI");

        mhs1.PrintInfo();
        mhs2.PrintInfo();
        List<Mahasiswa> mahasiswaList = new List<Mahasiswa>();

        string jawaban;

        do
        {
            Console.WriteLine("Apakah anda ingin menambahkan mahasiswa? (Y/N)");
            jawaban = Console.ReadLine();
            if (jawaban.ToLower() == "y")
            {
                Console.WriteLine("Masukkan nama mahasiswa:");
                string nama = Console.ReadLine();
                Console.WriteLine("Masukkan NIM mahasiswa:");
                string nim = Console.ReadLine();
                Console.WriteLine("Masukkan jurusan mahasiswa:");
                string jurusan = Console.ReadLine();
                Mahasiswa mhs = new Mahasiswa(nama, nim, jurusan);
                mahasiswaList.Add(mhs);
            }
        } while (jawaban.ToLower() != "n");

        foreach (Mahasiswa mhs in mahasiswaList)
        {
            mhs.PrintInfo();
        }
        Console.WriteLine("\nTerima kasih telah menggunakan program ini.");
        Console.ReadKey();
    }
}
