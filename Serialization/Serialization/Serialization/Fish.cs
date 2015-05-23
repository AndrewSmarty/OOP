using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialization
{
    [XmlInclude(typeof(Clown))]
    [XmlInclude(typeof(Barbus))]
    [XmlInclude(typeof(Sackgill))]
    [XmlInclude(typeof(Guppi))]
    [XmlInclude(typeof(OctupusFish))]
    [XmlInclude(typeof(CatFish))]

    public class Fish
    {

        public string Name { get; set; }
        public string Price { get; set; }
        public string ID { get; set; }

        public Fish()
        {
            Name = "";
            Price = "";
            ID = GetType().ToString();
        }

    }
}
