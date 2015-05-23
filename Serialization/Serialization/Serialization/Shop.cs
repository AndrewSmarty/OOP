using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class Shop
    {
        
        public delegate void DelegateMethod(Panel subsurface);

        private readonly Panel surface;

        public Shelter CurrentShelter { get; private set; }

        public Shop(Panel fishPanel)
        {
            surface = fishPanel;
            CurrentShelter = new Shelter(new Point(5, 0), new Size(surface.Width - 10, 200), BorderStyle.None);
        }

        public void DisplayFish(Type type)
        {
            surface.Controls.Clear();
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var dictionary = new Dictionary<string, string>();
            foreach (var propertyName in properties.Select(property => property.Name))
            {
                if (propertyName == "ID")
                    dictionary.Add("ID", type.ToString());
                else
                    dictionary.Add(propertyName, "");
            }

            OutputFishControl(dictionary);
        }

        private void OutputFishControl(Dictionary<string, string> dictionary)
        {
            var shelter = new Shelter(new Point(5, 0), new Size(surface.Width - 10, 200), BorderStyle.None);
            shelter.AddProperties(dictionary, true);
            CurrentShelter = shelter;
            surface.Controls.Add(shelter.Self);
        }

    }
}




/*


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    [Serializable]
    public class Fishes : ISerializable
    {
        public List<Fish> list;

        public Fishes()
        {
            list = new List<Fish>();
        }

        //Deserialization constructor.
        public Fishes(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            list = (List<Fish>)info.GetValue("FishesList", typeof(List<Fish>));
//            EmpName = (String)info.GetValue("EmployeeName", typeof(string));
        }
        
        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"
            info.AddValue("FishesList", list);
        }

    }
}

*/