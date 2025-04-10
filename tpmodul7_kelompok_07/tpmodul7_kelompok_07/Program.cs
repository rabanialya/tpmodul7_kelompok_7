using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa2311104076
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class Mahasiswa
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_1_2311104076.json");
        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(json);
        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa2311104076 data = new DataMahasiswa2311104076();
        data.ReadJSON();
    }
}