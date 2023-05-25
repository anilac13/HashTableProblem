using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HashTableProblem
{
    public class HashTable
    {
        private Node[] Words;
        public HashTable(int size)
        {
            Words = new Node[size];
        }
        public void Add(string data)
        {
            Node newNode = new Node(data);
            int arrayIndex = Math.Abs(data.GetHashCode()) % Words.Length;
            Node nodesPresent = Words[arrayIndex];
            newNode.Next = nodesPresent;
            Words[arrayIndex] = newNode;
        }
        public void FindWord(string word)
        {
            int index = Math.Abs(word.GetHashCode()) % Words.Length;
            Node nodePresent = Words[index];
            while (nodePresent != null)
            {
                if (nodePresent.Data.Equals(word))
                {
                    Console.WriteLine($"Data '{word}' present at {index}th index in the Hash Table");
                    return;
                }
                nodePresent = nodePresent.Next;
            }
            Console.WriteLine($"Data '{word}' is not found");
        }
        public void RemoveWord(string word)
        {
            int index = Math.Abs(word.GetHashCode()) % Words.Length;
            Node currentNode = Words[index];
            Node prevNode = currentNode;
            if (currentNode != null && currentNode.Data == word)
            {
                Words[index] = currentNode.Next;
                return;
            }
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(word))
                {
                    prevNode = currentNode.Next;
                    return;
                }
                prevNode = currentNode;
                currentNode = currentNode.Next;
            }
        }
        public void Display()
        {
            for (int index = 0; index < Words.Length; index++)
            {
                Node temp = Words[index];
                Console.Write($"Index {index}: ");
                while (temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.Next;
                }
                Console.Write("NULL \n");
            }
        }
    }
}
