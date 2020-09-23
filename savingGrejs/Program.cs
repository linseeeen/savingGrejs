using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace savingGrejs
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena a1 = new Arena();
            Console.WriteLine("Vad ska din arena heta?");
            a1.name = Console.ReadLine();
            Console.WriteLine("Hur glad ska publiken vara? siffra");
            a1.peopleAmount = Check(Console.ReadLine());
            Console.WriteLine("Hur glada ska de vara? siffra");
            a1.peopleHappy = Check(Console.ReadLine());

            XmlSerializer arenaSerializer = new XmlSerializer(typeof(Arena));
            FileStream file = File.Open("arena.xml", FileMode.OpenOrCreate);
            arenaSerializer.Serialize(file, a1);
            file.Close();

        }
        static int Check (string tal)
        {
            int resultat;
            bool lyckad = int.TryParse(tal, out resultat);
            return resultat;
        }
    }
}
