using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class Fish
    {
        public string Name { get; set; }
        public int Price { get; set; }

        protected Fish()
        {
            Name = "";
            Price = 0;
        }

    }
}
