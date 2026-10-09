using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    internal class Meme
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Caracteristic { get; set; }
        public string Recentness { get; set; }

        public Meme(int id, string image, string caracteristic, string recentness)
        {
            Id = id;
            Image = image;
            Caracteristic = caracteristic;
            Recentness = recentness;
        }
    }
}
