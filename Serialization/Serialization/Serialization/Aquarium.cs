using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class Aquarium
    {
        public List<Fish> fishes {get; set;}
        private Panel surface;

        public Aquarium(Panel surface)
        {
            this.surface = surface;
            Wash();
        }

        private int shelterOffset;

        public void Wash()
        {
            shelterOffset = 0;
            fishes = new List<Fish>();
            ClearSurface();
        }

        private void OutputFishControl(Dictionary<string, string> dictionary)
        {
            var shelter = new Shelter(new Point(5, shelterOffset), new Size(surface.Width - 10, 200), BorderStyle.None);
            shelter.AddProperties(dictionary, false);
            surface.Controls.Add(shelter.Self);
            
            shelterOffset += 200;
        }

        public void ClearSurface()
        {
            surface.Controls.Clear();
        }

        public void AddFishes(IEnumerable<Fish> fishes)
        {
            foreach (var fish in fishes)
            {
                var dictionary = new Dictionary<string, string>();

                var fields = fish.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (var field in fields)
                {
                    var propertyName = field.Name;
                    var propertyValue = field.GetValue(fish, null).ToString();
                    dictionary.Add(propertyName, propertyValue);
                }

                AddFishToShelter(dictionary);
            }    
        }

        private Fish GetFishFromDictionary(IReadOnlyDictionary<string, string> data)
        {
            Fish fish;
         
            switch (data["ID"].Split('.')[1])
            {
                case "Barbus":
                    fish = new Barbus(); break;
                case "Clown":
                    fish = new Clown(); break;
                case "Sackgill":
                    fish = new Sackgill(); break;
                case "Guppi":
                    fish = new Guppi(); break;
                default:
                    fish = new Fish(); break;
            }

            foreach (var property in data)
            {
                PropertyInfo prop = fish.GetType().GetProperty(property.Key, BindingFlags.Public | BindingFlags.Instance);
                if (null == prop || !prop.CanWrite) continue;
                try
                {
                    prop.SetValue(fish, Convert.ChangeType(property.Value, prop.PropertyType), null);
                }
                catch (Exception exception)
                {
                    prop.SetValue(fish, null, null);
                }
            }

            return fish;
        }

        public void AddFishToShelter(Dictionary<string, string> shelterContent)
        {
            if (shelterContent == null) return;

            OutputFishControl(shelterContent);
            var newFish = GetFishFromDictionary(shelterContent);
            fishes.Add(newFish);
        }

    }
}
