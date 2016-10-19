using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arkdj.Chronicle.Model
{
    public class Entry: Resource
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public IList<Comment> Comments { get; set; }
        public EntryCategory Category { get; set; }
    }
}
