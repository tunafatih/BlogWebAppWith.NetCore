using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FatihTuna.Models
{
    public class MultipleModel
    {
        public IEnumerable<Post> posts { get; set; }
        public IEnumerable<Comment> comments { get; set; }
    }
}
