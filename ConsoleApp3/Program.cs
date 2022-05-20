using System;
using System.Collections;
namespace ConsoleApp3
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection List");
            // Creating arraylist
            ArrayList mylist = new ArrayList();
            // Adding Elements
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);

            mylist.Add(10.10);
            mylist.Add(20.30);
            mylist.Add(30.40);

            mylist.Add('A');
            mylist.Add('B');
            mylist.Add('C');

            mylist.Add("vicky");
            mylist.Add("abhi");
            mylist.Add("amit");

            int sum = 0;
            int count = 0;

            Console.WriteLine($"Length of array list={mylist.Count}");
            foreach (object obj in mylist)
            {
                if (obj is int)
                {
                    sum = sum + (int)obj;
                    if ((int)obj % 2 == 0)
                    {
                        Console.WriteLine("Even Number=" + (int)obj);
                        count++;
                        Console.WriteLine();
                    }
                }
                else if (obj is string)
                {
                    string obj1 = (string)obj;
                    Console.WriteLine("String Name" +
                        "=" + (string)obj + ",String Length" +
                        "=" + obj1.Length + ", Index=" + 
                        mylist.IndexOf((string)obj));
                }


            }
            Console.WriteLine($"int sum=" + sum);
            Console.WriteLine();
            Console.WriteLine($"Count of even numbers are{count}");





        }

    }
}

