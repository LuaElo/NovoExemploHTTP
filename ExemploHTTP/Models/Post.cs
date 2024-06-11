using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHTTP.Models
{
    public class Post
    { 
        public int UserId { get; set; }
        public int Id { get; set; }
        private string Title { get; set; }
        private string Body { get; set; }

    }
}
