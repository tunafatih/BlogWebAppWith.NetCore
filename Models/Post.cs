using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FatihTuna.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Tags { get; set; }

        public static implicit operator int(Post v)
        {
            throw new NotImplementedException();
        }
    }
}
