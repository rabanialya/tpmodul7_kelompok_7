using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa2311104046
{
    public class Course
    {
        public string? code { get; set; }
        public string? name { get; set; }
    }

    public class CourseList
    {
        public List<Course>? courses { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = "tp7_2_2311104046.json";
        string jsonText = File.ReadAllText(filePath);

        try
        {
            CourseList? data = JsonSerializer.Deserialize<CourseList>(jsonText);

            if (data?.courses != null)
            {
                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int i = 1;
                foreach (var course in data.courses)
                {
                    Console.WriteLine($"MK {i} {course.code} - {course.name}");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Data kosong atau format tidak sesuai.");
            }
        }
        catch (JsonException e)
        {
            Console.WriteLine($"JSON Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"General Error: {e.Message}");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        KuliahMahasiswa2311104046 kuliah = new KuliahMahasiswa2311104046();
        kuliah.ReadJSON();
    }
}