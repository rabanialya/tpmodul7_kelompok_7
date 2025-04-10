using System;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa2311104076
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }

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

        string filePath = "tp7_2_2311104076.json";
        string jsonText = File.ReadAllText(filePath);

        CourseList data = JsonSerializer.Deserialize<CourseList>(jsonText);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var course in data.courses)
        {
            Console.WriteLine($"MK {i} {course.code} - {course.name}");
            i++;
        }

        string json = File.ReadAllText("tp7_1_2311104076.json");
        Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(json);
        Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");

    }
}

class Program
{
    static void Main(string[] args)
    {

        KuliahMahasiswa2311104076 kuliah = new KuliahMahasiswa2311104076();
        kuliah.ReadJSON();
    }
}

        DataMahasiswa2311104076 data = new DataMahasiswa2311104076();
        data.ReadJSON();
    }
}

