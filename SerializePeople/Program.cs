using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ben", new DateTime(1990, 09, 12), Gender.Male);
            Console.WriteLine(p1.ToString());

            Stream stream = File.Open("PersonInfo.osl", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            
            bformatter.Serialize(stream, p1);
            stream.Close();

            p1 = null;

            stream = File.Open("PersonInfo.osl", FileMode.Open);
            bformatter = new BinaryFormatter();

            Console.WriteLine("Reading Person Information");
            p1 = (Person)bformatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("Person Name: {0}", p1.Name);
            Console.WriteLine("Person birthDate: {0}", p1.BirthDate);
            Console.WriteLine("Person gender: {0}", p1.Gender);
            Console.WriteLine("Person age: {0}", p1.Age);
        }
    }
}
