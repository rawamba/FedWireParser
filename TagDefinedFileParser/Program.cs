using FedWireParser;
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
            var AllLines = new string[5000]; //only allocate memory here
            AllLines = File.ReadAllLines(@"C:\Projects\Data\wire.txt");
            var processedLines = new List<WireBO>();
            Parallel.For(0, AllLines.Length, x =>
            {
                processedLines.Add(ProcessLine(AllLines[x]));
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

        private static WireBO ProcessLine(string l)
        {
            var tags = GetAllTagsWithValue(l);
            var line = new WireBO();

            var wireType = typeof(WireBO);
            var classAttributes = Attribute.GetCustomAttributes(wireType);

            foreach (var property in wireType.GetProperties())
            {
                var propertyAttribute = property.GetCustomAttributes(false);

                var tn = ((FedWireTagNumberAttribute)propertyAttribute.FirstOrDefault()).TagNumber;
                var elt = ((FedWireTagNumberAttribute)propertyAttribute.FirstOrDefault()).ElementNumber;

                // go get the data
                var tag = tags.FirstOrDefault(t => t.StartsWith("{"+tn+"}"));

                if (!(tag == null))
                {
                    var tagData = tag.Split('}')[1];
                    property.SetValue(line, tagData); 
                }
            }

            return line;
        }
    }
}
