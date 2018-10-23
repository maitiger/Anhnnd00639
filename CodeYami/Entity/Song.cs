using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYami.Entity
{
    class Song
    {
        private string _name;
        private string _singer;
        private string _author;
        private string _thumbnail;
        private string _link;
        private string _id;


        public string name { get => _name; set => _name = value; }
        public string singer { get => _singer; set => _singer = value; }
        public string author { get => _author; set => _author = value; }
        public string thumbnail { get => _thumbnail; set => _thumbnail = value; }
        public string link { get => _link; set => _link = value; }
        public string id { get => _id; set => _id = value; }
    }
}
