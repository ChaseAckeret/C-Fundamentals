using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //--Whole Numbers 
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;    //Int16
            int wholeNumber = 32;           //Int32
            long largeWholeNumber = 64;     //Int64

            int newNumber = oneBytesWorth;
            //--Decimals
            float floarExample = 1.234567f;
            double doubleExampe = 1.237909d; //Don't have to put the d
            decimal decimalNumber = 1.7000m; //Very percise calculations

            char letter = 'j';

            //--Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo; // 17/5=3 ??? Whole number, int never has decimals.
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; // 17/5=2 gets only the remainder
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");

            
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //--Strings
            string stringExample = "This is a string.";
            string name = "Chase";

            string declared;
            declared = "Now it's Intialized";

            //--Formatting Strings
            string concatenate = stringExample + " " + name; // This is a string. Chase
            string interpolate = $"{name}. Here is the string: {stringExample}"; //Chase. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //--Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2020, 11, 14);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //--Collections
            //--Arrays - Don't use as much in C#
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            //--Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawerence");

            //--Queues first in first out
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //--Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            //--Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();

        }
    }
}
