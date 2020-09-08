using System;

namespace Models
{
    public class books
    { 
        public int id { get; set; }
        public string Author { get; set; }
        public string description { get; set; }
        public string PhotoPath { get; set; }
        public Genre? Genres { get; set; }
    }
}
