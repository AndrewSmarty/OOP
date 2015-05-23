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
    public class Clown : OctupusFish
    {
        [DataMember]
        public string StripesOrientaion { get; set; }

        public Clown()
        {
            StripesOrientaion = "";
        }
    }
}
