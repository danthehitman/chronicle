using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arkdj.Chronicle.Model
{
    public enum EntryCategory
    {
        Article,
        Image,
        Thought,
        Note
    }
    public class Category
    {
        public string Name { get; set; }
    }
}
