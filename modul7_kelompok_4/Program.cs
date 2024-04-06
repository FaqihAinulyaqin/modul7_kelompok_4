<<<<<<< HEAD
<<<<<<< HEAD
﻿using Newtonsoft.Json;
using System;
=======
﻿using System;
>>>>>>> faqih
using System.Data;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DataMahasiswa_1302220086
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public class Address
=======
﻿using System;
using System.Text.Json;

public class DataMahasiswa_1302220077
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public class address
>>>>>>> a0a88280d2af72aea5d85abf25d6fcb33d5e8ee7
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
<<<<<<< HEAD
    public Address address { get; set; }
    public class Courses
=======

    public class MataKuliah
>>>>>>> a0a88280d2af72aea5d85abf25d6fcb33d5e8ee7
    {
        public string code { get; set; }
        public string name { get; set; }
    }
<<<<<<< HEAD
    public Courses[] courses { get; set; }

    public void ReadJSON(string jsonString)
    {
        DataMahasiswa_1302220086 data = JsonSerializer.Deserialize<DataMahasiswa_1302220086>(jsonString);
        firstName = data.firstName; lastName = data.lastName;
        gender = data.gender;
        age = data.age;
        address = data.address;
        courses = data.courses;
=======

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
>>>>>>> a0a88280d2af72aea5d85abf25d6fcb33d5e8ee7
    }

    public void PrintData()
    {
<<<<<<< HEAD
        Console.WriteLine($"Name: {firstName} {lastName}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Address: {address.streetAddress} {address.city} {address.state}");
        Console.WriteLine("Courses:");
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine("========================");
            Console.WriteLine($"Code: {courses[i].code}");
            Console.WriteLine($"Name: {courses[i].name}");
=======
        Console.WriteLine($"Nama : {nama.depan} {nama.belakang}");
        Console.WriteLine($"Alamat : {alamat.streetAddress} {alamat.city} {alamat.state}");
        Console.WriteLine("gender : " + gender);
        Console.WriteLine("Umur : " + umur);
        Console.WriteLine("Daftar Mata Kuliah Yang Diambil: ");
        for (int i = 0; i < courses.Length; i++) 
        {
            Console.WriteLine($"MK {i+1} {courses[i].code} - {courses[i].name}");
>>>>>>> a0a88280d2af72aea5d85abf25d6fcb33d5e8ee7
        }
    }
}

<<<<<<< HEAD
public class TeamMembers_1302220086
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
    public Member[] members { get; set; }

    public void ReadJSON(string jsonString)
    {
        TeamMembers_1302220086 data = JsonSerializer.Deserialize<TeamMembers_1302220086>(jsonString);
        members = data.members;
    }

    public void PrintData()
    {
        Console.WriteLine("Team member list:");
        for (int i = 0;i < members.Length;i++)
        {
            Console.WriteLine();
            Console.WriteLine($"<{members[i].nim}> <{members[i].firstName} {members[i].lastName}> (<{members[i].age}> <{members[i].gender}>)");
        }
    }
}

public class GlossaryItem_1302220086
{

}

class Program
{
    static void Main(string[] args)
    {
        string faqihJson = "{\"firstName\": \"Muhammad Faqih\", \"lastName\": \"Ainulyaqin\", \"gender\": \"Male\", \"Age\": 19, \"address\": {\"streetAddress\": \"Bojongsoang\", \"city\": \"Bandung\", \"state\": \"West Java\"}, \"courses\": [{\"code\": \"CRI2C4\", \"name\": \"Konstruksi Perangkat Lunak\"}, {\"code\": \"CRI2E4\", \"name\": \"Basis Data\"}]}";
        DataMahasiswa_1302220086 faqih = new DataMahasiswa_1302220086();
        faqih.ReadJSON(faqihJson);
        faqih.PrintData();

        Console.WriteLine();

        string teamFaqihJson = "{\"members\": [{\"firstName\": \"Muhammad Faqih\", \"lastName\": \"AinulYaqin\", \"gender\": \"Male\", \"age\": 19, \"nim\": \"1302220086\"}, {\"firstName\": \"Irham\", \"lastName\": \"Baehaqi\", \"gender\": \"Male\", \"age\": 20, \"nim\": \"1302220063\"}, {\"firstName\": \"Helmy\", \"lastName\": \"Farikh Alfarizhi\", \"gender\": \"Male\", \"age\": 19, \"nim\": \"1302220077\"}, {\"firstName\": \"Naufal Ammar\", \"lastName\": \"Zaidan\", \"gender\": \"Male\", \"age\": 19, \"nim\": \"1302220052\"}]}";
        TeamMembers_1302220086 TeamFaqih = new TeamMembers_1302220086();
        TeamFaqih.ReadJSON(teamFaqihJson);
        TeamFaqih.PrintData();
    }
}
=======
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
>>>>>>> a0a88280d2af72aea5d85abf25d6fcb33d5e8ee7
