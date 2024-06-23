using System;
using System.Collections.Generic;
using System.Linq;

namespace Epic2_Task2
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public List<Genre> Genres { get; set; }
    }
}

