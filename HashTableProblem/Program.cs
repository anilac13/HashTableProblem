using System;
using System.Collections;

namespace HashTableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hashTable = new HashTable(10);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Find frequency of words in Sentence \n2.Display Hash table \n3.Find frequency of words in Large paragraph \n4.Delete word from paragraph \n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        hashTable.Add("To");
                        hashTable.Add("be");
                        hashTable.Add("or");
                        hashTable.Add("not");
                        hashTable.Add("to");
                        hashTable.Add("be");
                        break;
                    case 2:
                        hashTable.Display();
                        break;
                    case 3:
                        hashTable.Add("Paranoids");
                        hashTable.Add("are");
                        hashTable.Add("not");
                        hashTable.Add("paranoid");
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
                        break;
                    case 4:
                        hashTable.RemoveWord("avoidable");
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}