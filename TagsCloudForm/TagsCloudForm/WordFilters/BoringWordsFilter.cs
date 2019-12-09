﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TagsCloudForm.CircularCloudLayouter;

namespace TagsCloudForm.WordFilters
{
    public class BoringWordsFilter : IWordsFilter
    {
        public Result<IEnumerable<string>> Filter(CircularCloudLayouterWithWordsSettings settings,
            IEnumerable<string> words)
        {
            HashSet<string> boringWords;
            try
            {
                var settingsFilename = settings.BoringWordsFile;
                boringWords = File.ReadAllLines(settingsFilename).ToHashSet(StringComparer.OrdinalIgnoreCase);
            }
            catch (Exception e)
            {
                return new Result<IEnumerable<string>>("Не удалось загрузить файл с boring words", words);
            }

            return Result.Ok(words.Where(x => !boringWords.Contains(x)));
        }

        public IEnumerable<string> Filter(HashSet<string> boringWords, IEnumerable<string> words)
            {
                return words.Where(x => !boringWords.Contains(x));
            }
        }
}
