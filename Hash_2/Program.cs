﻿// See https://aka.ms/new-console-template for more information
using Hash_2;
using System.Collections;

Console.WriteLine("Hash Table Implementation using Linkedlist!");

while(true)
{
    Console.WriteLine("Please choose the option :\n1) Frequency of para1");
    int option = Convert.ToInt16(Console.ReadLine());
    switch(option)
    {
        case 1:
            HashMethods<string, int> hash = new HashMethods<string, int>(5);
            string Words = "To be or not to be";
            string[] array = Words.Split(' ');
            LinkedList<string> checkForDuplicationS = new LinkedList<string>();
            foreach (string element in array)
            {
                int count = 0;
                foreach (string match in array) 
                {
                    if (element == match)
                    {
                        count++;
                        if (checkForDuplicationS.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (!checkForDuplicationS.Contains(element))
                {
                    checkForDuplicationS.AddLast(element);
                    hash.Add(element, count);
                }
            }
            hash.Display();
            break; 
        default:
            Console.WriteLine("Please choose the correct option!");
            break;
    }
}

