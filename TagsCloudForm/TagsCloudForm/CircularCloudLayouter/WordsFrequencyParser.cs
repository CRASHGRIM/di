﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudForm
{
    public class WordsFrequencyParser :IWordsFrequencyParser
    {
        public Dictionary<string, int> GetWordsFrequency(string filename)
        {
            var frequencies = new Dictionary<string, int>();
            string[] lines = File.ReadAllLines(filename);
            lines.ToList().ForEach(line =>
            {
                if (frequencies.ContainsKey(line))
                    frequencies[line] = frequencies[line] + 1;
                else
                    frequencies.Add(line, 1);
            });

            return frequencies;
        }
    }
}