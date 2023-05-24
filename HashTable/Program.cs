using System;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table.");

            Console.WriteLine("\n=========||===========\n");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine($"5th index value: {hash5}");

            Console.WriteLine("\n=========||===========\n");

            hash.Remove("2");
            string hash2 = hash.Get("2");
            Console.WriteLine($"2nd index value: {hash2}");
        }
    }
}
