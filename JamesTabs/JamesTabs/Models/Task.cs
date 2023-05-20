using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesTabs.Models
{
    public class Task
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime deadline { get; set; }
        public string description { get; set; }
    }
}
