using System;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;

namespace modul7_kelompok_4;

public class DataMahasiswa1302220052
{
    public required string firstName { get; set; }
    public required string lastName { get; set; }
    public required string gender { get; set; }
    public required Address Address { get; set; }
    public required List<Course> courses { get; set; }
    public int Age { get; set; }
}

public class Address
{
    public required string StreetAddress { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
}

public class Course
{
    public required string Code { get; set; }
    public required string Name { get; set; }
}

public void ReadJSON()
{
    string json = File.ReadAllText("jurnal7_1_1302220052.json");
    var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220052>(json);

    if (dataMahasiswa != null)
    {
        Console.WriteLine($"Name: {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
        Console.WriteLine($"gender: {dataMahasiswa.gender}");
        Console.WriteLine($"Age: {dataMahasiswa.Age}");
        Console.WriteLine($"Address: {dataMahasiswa.Address}");
        Console.WriteLine($"Street: {dataMahasiswa.Address.StreetAddress}");
        Console.WriteLine($"City: {dataMahasiswa.Address.City}");
        Console.WriteLine($"State: {dataMahasiswa.Address.State}");
    }
}
