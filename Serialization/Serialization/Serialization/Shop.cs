using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class Shop
    {
        
        public delegate void DelegateMethod(Panel subsurface);

        private Fishes Fishes { get; set; }
        private readonly Panel surface;
        private Shelter shelter;

        public Panel CurrentShelter
        {
            get { return shelter.Self; }
            set { shelter.Self = value; }
        }

        public Shop(Panel FishPanel)
        {
            Fishes = new Fishes();
            surface = FishPanel;
            shelter = new Shelter(new Point(5, 0), new Size(surface.Width - 10, 150), BorderStyle.None);
        }

        public void DisplayFish(DelegateMethod DisplayFishMethod)
        {
            surface.Controls.Clear();
            DisplayFishMethod(surface);
        }


        public void OutputFishControl(Dictionary<string, string> dictionary)
        {
            var shelter = new Shelter(new Point(5, 0), new Size(surface.Width - 10, 150), BorderStyle.None);
            shelter.AddProperties(dictionary);
            CurrentShelter = shelter.Self;
            surface.Controls.Add(shelter.Self);
        }


        public void DisplayBarbus(Panel surface)
        {
            var dictionary = new Dictionary<string, string>
            {
                {"ID", "Barbus"},
                {"Name", ""},
                {"Price", ""},
                {"Mouth Size", ""},
                {"Eats fish", ""}
            };

            // var properties = new List<string> {"Name", "Price", "Mouth Size", "Eats fish"};
            OutputFishControl(dictionary);
        }

        public void DisplaySackgill(Panel surface)
        {
            var dictionary = new Dictionary<string, string>
            {
                {"ID", "Sackgill"},
                {"Name", ""},
                {"Price", ""},
                {"Tail Length", ""},
                {"Color", ""}
            };
            OutputFishControl(dictionary);
        }

        public void DisplayClown(Panel surface)
        {
            var dictionary = new Dictionary<string, string>
            {
                {"ID", "Clown"},
                {"Name", ""},
                {"Price", ""},
                {"Stripes orientation", ""}
            };
            OutputFishControl(dictionary);
        }

        public void DisplayGuppi(Panel surface)
        {
            //var properties = new List<string> {"Name", "Price", "Size"};

            var dictionary = new Dictionary<string, string>
            {
                {"ID", "Guppi"},
                {"Name", ""},
                {"Price", ""},
                {"Size", ""}
            };
            OutputFishControl(dictionary);
        }

        

    }
}
