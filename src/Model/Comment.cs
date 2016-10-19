using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arkdj.Chronicle.Model
{
    public class Comment
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
    }
}
