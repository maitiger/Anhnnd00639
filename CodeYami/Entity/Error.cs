using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeYami.Entity
{
    class Error
    {
        public int status { get; set; }
        public string message { get; set; }
        public Dictionary<string, String> error { get; set; }

    }
}
