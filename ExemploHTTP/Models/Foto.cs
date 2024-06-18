using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHTTP.Models
{
    public class Foto
    {
        public int AlbumId { get; set; }
        public int UserId { get; set; }
        public int Id { get; set; }
        private string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
