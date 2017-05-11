﻿using FedWireParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TagDefinedFileParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var MAX = (int)Math.Floor((double)(Int32.MaxValue / 5000));
            // read the file in
            var AllLines = new string[MAX]; //only allocate memory here
            AllLines = File.ReadAllLines(@"C:\Projects\Data\wire.txt");
            var tags = GetAllTagsWithValue(AllLines[0]);
            foreach (var item in tags)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press a key to continue");
            Console.ReadLine();

            Parallel.For(0, AllLines.Length, x =>
            {
                ProcessLine(AllLines[x]);
            });
        }

        private static List<string> GetAllTagsWithValue(string v)
        {
            var pattern = @"{\d\d\d\d}([^{]*)";
            var matches = Regex.Matches(v, pattern);
            var tags = new List<string>();
            foreach (var item in matches)
            {
                tags.Add(item.ToString());
            }
            return tags;
        }

        private static void ProcessLine(string l)
        {
            var tags = GetAllTagsWithValue(l);

            var wireType = typeof(WireBO);
            var classAttributes = Attribute.GetCustomAttributes(wireType);

            foreach (var property in wireType.GetProperties())
            {
                var propertyAttributes = Attribute.GetCustomAttributes(property);


            }



            // parse this line and 

        }
    }
}
