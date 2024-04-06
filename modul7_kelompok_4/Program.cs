using System;
using System.Data;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

public class DataMahasiswa_1302220086
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public Address address { get; set; }
    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public Courses[] courses { get; set; }

    public void ReadJSON(string jsonString)
    {
        DataMahasiswa_1302220086 data = JsonSerializer.Deserialize<DataMahasiswa_1302220086>(jsonString);
        firstName = data.firstName; lastName = data.lastName;
        gender = data.gender;
        age = data.age;
        address = data.address;
        courses = data.courses;
    }

    public void PrintData()
    {
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
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string faqihJson = "{\"firstName\": \"Muhammad Faqih\", \"lastName\": \"Ainulyaqin\", \"gender\": \"Male\", \"Age\": 19, \"address\": {\"streetAddress\": \"Bojongsoang\", \"city\": \"Bandung\", \"state\": \"West Java\"}, \"courses\": [{\"code\": \"CRI2C4\", \"name\": \"Konstruksi Perangkat Lunak\"}, {\"code\": \"CRI2E4\", \"name\": \"Basis Data\"}]}";
        DataMahasiswa_1302220086 faqih = new DataMahasiswa_1302220086();
        faqih.ReadJSON(faqihJson);
        faqih.PrintData();
    }
}