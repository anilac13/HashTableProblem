using System;
using System.Collections;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(10);
            hashTable.Add("To");
            hashTable.Add("be");
            hashTable.Add("or");
            hashTable.Add("not");
            hashTable.Add("to");
            hashTable.Add("be");
            hashTable.Display();

            Console.WriteLine("\nEnter word to search in Hash Table");
            string word = Console.ReadLine();
            hashTable.FindWord(word);
        }
    }
}