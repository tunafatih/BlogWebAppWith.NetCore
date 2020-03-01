using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FatihTuna.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Yorum { get; set; }
        public string Nick { get; set; }
        public int Konu { get; set; }

    }
}
