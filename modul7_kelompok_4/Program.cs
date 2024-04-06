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