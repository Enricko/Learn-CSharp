namespace pertemuan2
{
    internal class Mahasiswa
    {
        public string Name { get; set; }
        public string Nim { get; set; }
        public string Jurusan { get; set; }
        public Mahasiswa(string name, string nim, string jurusan)
        {
            Name = name;
            Nim = nim;
            Jurusan = jurusan;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Nama\t" + Name);
            Console.WriteLine("NIM\t" + Nim);
            Console.WriteLine("Jurusan\t" + Jurusan);
            Console.WriteLine();
        }
    }
}