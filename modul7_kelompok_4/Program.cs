using System;
using System.Text.Json;

public class DataMahasiswa1302223062
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON(string jsonString)
    {
        DataMahasiswa1302223062 data = JsonSerializer.Deserialize<DataMahasiswa1302223062>(jsonString);
        nama = data.nama;
        nim = data.nim;
        fakultas = data.fakultas;
    }

    public void PrintData()
    {
        Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {nim} dari fakultas {fakultas}");
    }
}

public class KuliahMahasiswa1302223062
{
    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public MataKuliah[] courses { get; set; }

    public void ReadJSON(string jsonString)
    {
        KuliahMahasiswa1302223062 data = JsonSerializer.Deserialize<KuliahMahasiswa1302223062>(jsonString);
        courses = data.courses;
    }

    public void PrintData()
    {
        Console.WriteLine("Daftar mata kuliah yang diambil:");
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {courses[i].code} - {courses[i].name}");
        }
    }
}


public class TeamMembers1302223062 
{
    public class Members
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }
        public string nim { get; set; }
        public Nama nama { get; set; }
        public string age { get; set; }
        public string gender { get; set; }


    }

    public Members[] anggota { get; set; }

    public void ReadJSON(string jsonString)
    {
        TeamMembers1302223062 data = JsonSerializer.Deserialize<TeamMembers1302223062>(jsonString);
        anggota = data.anggota;
    }

    public void PrintData()
    {
        Console.WriteLine("Team Members :");
        for (int i = 0; i < anggota.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {anggota[i].nim} - {anggota[i].nama.depan} - {anggota[i].nama.belakang} - {anggota[i].age} - {anggota[i].gender}");
        }
    }
}



class Program
{
    static void Main(string[] args)
    {
        // string mahasiswaJson = "{\"nama \": {\"depan\": \"Francisca\", \"belakang\": \"Manope\"}, \"nim\": 1302223062, \"fakultas\": \"Informatika\"}";
        // DataMahasiswa1302223062 mahasiswa = new DataMahasiswa1302223062();
        // mahasiswa.ReadJSON(mahasiswaJson);
        // mahasiswa.PrintData();

        // string kuliahJson = "{\"courses\": [{\"code\": \"CRI2C4\", \"name\": \"Konstruksi Perangkat Lunak\"}, {\"code\": \"CRI2E4\", \"name\": \"Basis Data\"}, {\"code\": \"CRI3J2\", \"name\": \"Bahasa Inggris: Writing And Speaking\"}, {\"code\": \"CII3B4\", \"name\": \"Pemrograman Berorientasi Objek\"}, {\"code\": \"CRJ2H3\", \"name\": \"Pengalaman Pengguna\"}, {\"code\": \"CRI2F2\", \"name\": \"Proyek Tingkat II\"}, {\"code\": \"CRJ2G3\", \"name\": \"Dasar Jaringan Komputer\"}]}";
        // KuliahMahasiswa1302223062 kuliah = new KuliahMahasiswa1302223062();
        // kuliah.ReadJSON(kuliahJson);
        // kuliah.PrintData();

        string memberJSON = "{\"anggota\": [{\"nim\": 1302223062, \"nama \": {\"depan\": \"Francisca\", \"belakang\": \"Manope\"}, \"age\": 20,\"gender\": \"female\"},{\"nim\": 1302220086, \"nama \": {\"depan\": \"Muhammad\", \"belakang\": \"Ainulyaqin\"}, \"age\": 20,\"gender\": \"male\"},{\"nim\": 13022230077, \"nama \": {\"depan\": \"Helmy\", \"belakang\": \"Alfarizhi\"}, \"age\": 20,\"gender\": \"male\"},{\"nim\": 1302220063, \"nama \": {\"depan\": \"Irham\", \"belakang\": \"Baehaqi\"}, \"age\": 20,\"gender\": \"male\"},{\"nim\": 1302223008, \"nama \": {\"depan\": \"Ayu\", \"belakang\": \"Lestari\"}, \"age\": 20,\"gender\": \"female\"},{\"nim\": 1302220052, \"nama \": {\"depan\": \"Naufal\", \"belakang\": \"Zaidan\"}, \"age\": 20,\"gender\": \"male\"}]}";
        TeamMembers1302223062 mahasiswa = new TeamMembers1302223062();
        mahasiswa.ReadJSON(memberJSON);
        mahasiswa.PrintData();
    }

}
