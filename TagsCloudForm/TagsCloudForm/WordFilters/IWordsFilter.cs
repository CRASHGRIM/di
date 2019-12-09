﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagsCloudForm.CircularCloudLayouter;

namespace TagsCloudForm.WordFilters
{
    interface IWordsFilter
    {
        Result<IEnumerable<string>> Filter(CircularCloudLayouterWithWordsSettings settings, IEnumerable<string> words);
    }
}
