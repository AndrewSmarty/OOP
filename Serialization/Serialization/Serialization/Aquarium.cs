using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class Aquarium
    {
        public Fishes Fishes {get; set;}
        private readonly Panel surface;

        public Aquarium(Panel surface)
        {
            this.surface = surface;
            Fishes = new Fishes();
        }

        public void AddFish(Panel shopShelter)
        {
            foreach (Control control in shopShelter.Controls)
            {
                if (control is Label)
                {
                    
                }    
            }

            Barbus barbus = new Barbus();
            barbus.Name = "Barbus";
            barbus.Price = 1000;
            barbus.MouseSize = 20;
            var dbRep = new DatabaseRepository();
            dbRep.Insert(barbus);

            this.surface.Controls.Add(shopShelter);
        }

        private void DisplayFishes(IEnumerable<Fish> fishes)
        {
            int x = 10;
            int y = 10;
            int marginY = 0;


            foreach (Fish fish in fishes)
            {
                Shelter wc = new Shelter(
                    new Point(5, y), 
                    new Size(surface.Width - 10, 150), 
                    BorderStyle.FixedSingle
                );
                wc.fillWith(fish);
                surface.Controls.Add(wc.Self);
               
                y += wc.Self.Size.Height + marginY;
            }
        }

    }
}
