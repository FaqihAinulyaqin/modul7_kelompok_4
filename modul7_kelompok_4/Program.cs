using System;
using System.Text.Json;

public class DataMahasiswa_1302220077
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public MataKuliah[] courses { get; set; }
    public Nama nama { get; set; }
    public address alamat { get; set; }
    public string gender { get; set; }
    public string umur { get; set; }

    public void ReadJSON(string jsonString)
    {
        DataMahasiswa_1302220077 data = JsonSerializer.Deserialize<DataMahasiswa_1302220077>(jsonString);
        courses = data.courses;
        nama = data.nama;
        alamat = data.alamat;
        gender = data.gender;
        umur = data.umur;
    }

    public void PrintData()
    {
        Console.WriteLine($"Nama : {nama.depan} {nama.belakang}");
        Console.WriteLine($"Alamat : {alamat.streetAddress} {alamat.city} {alamat.state}");
        Console.WriteLine("gender : " + gender);
        Console.WriteLine("Umur : " + umur);
        Console.WriteLine("Daftar Mata Kuliah Yang Diambil: ");
        for (int i = 0; i < courses.Length; i++) 
        {
            Console.WriteLine($"MK {i+1} {courses[i].code} - {courses[i].name}");
        }
    }
}

public class program
{
    static void Main(string[] args)
    {
        string mahasiswaJson = "{\"nama\": {\"depan\": \"Helmy\", \"belakang\": \"Farikh Alfarizhi\"}," +
            "\"alamat\": {\"streetAddress\" : \"Bumi Ciborerang Indah\", \"city\" : \"Bandung\", \"state\" : \"Jawa Barat\"} , " +
            "\"gender\": \"Laki-Laki\"," +
            "\"umur\": \"20\", "+
            "\"courses\": [{\"code\": \"CRI2C4\", \"name\": \"Konstruksi Perangkat Lunak\"}, " +
            "{\"code\": \"CRI2E4\", \"name\": \"Basis Data\"}, " +
            "{\"code\": \"CRI3J2\", \"name\": \"Bahasa Inggris: Writing and Speaking\"}, " +
            "{\"code\": \"CRI3B4\", \"name\": \"Pemrograman Berbasis Objek\"}, " +
            "{\"code\": \"CRJ2H3\", \"name\": \"Pengalaman Pengguna\"}, " +
            "{\"code\": \"CRI2F2\", \"name\": \"Proyek Tingkat II\"}, " +
            "{\"code\": \"CRJ2G3\", \"name\": \"Dasar Jaringan Komputer\"}]}";

        DataMahasiswa_1302220077 mahasiswa = new DataMahasiswa_1302220077();
        mahasiswa.ReadJSON(mahasiswaJson);
        mahasiswa.PrintData();
    }
 
}
