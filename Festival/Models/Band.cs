using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Festival.Models
{
    public class Band
    {
        public string Country { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Image Photo { get; set; }
        public string Stage { get; set; }

        public Band()
        {
            
        }
    }
}
