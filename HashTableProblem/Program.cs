using System;
using System.Collections;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(10);
            hashTable.Add("Paranoids");
            hashTable.Add("are");
            hashTable.Add("not");
            hashTable.Add("paranid");
            hashTable.Add("because");
            hashTable.Add("they");
            hashTable.Add("are");
            hashTable.Add("paranoid");
            hashTable.Add("but");
            hashTable.Add("because");
            hashTable.Add("they");
            hashTable.Add("keep");
            hashTable.Add("putting");
            hashTable.Add("themselves");
            hashTable.Add("deliberately");
            hashTable.Add("into");
            hashTable.Add("paranoid");
            hashTable.Add("avoidable");
            hashTable.Add("situations");

            hashTable.RemoveWord("avoidable");
            hashTable.Display();
        }
    }
}