using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Author: Aline Vetrov
 Date: Jan.20, 2020
 Title: Dictionaries and Sorted Lists
     */

namespace SortedListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myFirstDict = new Dictionary<int, string>();

            myFirstDict.Add(1, "Aline");
            myFirstDict.Add(2, "Alex");
            myFirstDict.Add(5, "Daria");
            myFirstDict.Add(4, "Costa");
            myFirstDict.Add(3, "Jessie");

            P("print out the dict\n");
            foreach(var item in myFirstDict)
            {
                P(item.ToString());
            }

            P("\nvalue of key 4: " + myFirstDict[4]);

            P("\nSort the dict by key:\n");
            foreach (var item in myFirstDict.OrderBy(d => d.Key))
            {
                P(item.ToString());
            }

            P("\nSort the dict by value:\n");
            foreach (var item in myFirstDict.OrderBy(d => d.Value))
            {
                P(item.ToString());
            }

            P("\noriginal order is intact\n");
            foreach (KeyValuePair<int, string> item in myFirstDict)
            {
                P(item.ToString());
            }

            P("#####################################################");

            SortedList<string, int> myFirstSortedList = new SortedList<string, int>();

            myFirstSortedList.Add("Daria", 4);
            myFirstSortedList.Add("Alex", 1);
            myFirstSortedList.Add("Costa", 39);
            myFirstSortedList.Add("Aline", 34);

            P("\n print out sorted list\n");
            foreach (var item in myFirstSortedList)
            {
                P(item.ToString());
            }

            P("\nget value of key 'daria'\n");
            P("Daria is " + myFirstSortedList["Daria"].ToString() + " years old.");

            bool existsKey = myFirstSortedList.ContainsKey("Aline");
            P($"key 'Aline' exists? {existsKey}");
            myFirstSortedList.Remove("Aline");
            existsKey = myFirstSortedList.ContainsKey("Aline");
            P($"key 'Aline' exists aftre removal? {existsKey}");

            P("\nCreate a sorted list string double\n");

            SortedList<string, double> mySecondSortedList = new SortedList<string, double>()
            {
                {"Aline", 160},
                {"Alex", 95.5},
                {"Costa", 175.5},
                {"Daria",112}
            };

            foreach (var item in mySecondSortedList)
            {
                P(item.ToString());
            }

            Console.ReadLine();
        }


        static void P(string mssg)
        {
            Console.WriteLine(mssg);
        }
    }
}
