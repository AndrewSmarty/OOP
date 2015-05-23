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
    public class Barbus : OctupusFish
    {
        [DataMember]
        public string MouthSize { get;  set; }

        [DataMember]
        public string EatsFish { get; set; }

        public Barbus()
        {
            MouthSize = "";
            EatsFish = "";

        }
    }
}
