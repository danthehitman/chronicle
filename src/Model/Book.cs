
using System.Collections;
using System.Collections.Generic;

namespace Arkdj.Chronicle.Model
{
    public class Book : Resource
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Page> Pages { get; set; }
    }
}