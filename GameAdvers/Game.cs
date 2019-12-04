using System;
using System.Collections.Generic;
using System.Text;

namespace GameAdvers
{
    public class Game : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string Developer { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public double Price { get; set; }
    }
}
