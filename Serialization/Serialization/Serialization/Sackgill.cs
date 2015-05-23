using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    [DataContract]
    public class Sackgill : CatFish
    {
        [DataMember]
        public string TailLength { get; set; }

        [DataMember]
        public string Color { get; set; }

        public Sackgill()
        {
            Color = "";
            TailLength = "";
        
        }
    }
}
