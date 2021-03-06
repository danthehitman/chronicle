﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arkdj.Chronicle.Model
{
    public class Page
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public User Author { get; set; }
        public IList<Entry> Entries { get; set; }
    }
}
