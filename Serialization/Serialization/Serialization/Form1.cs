using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public partial class Form1 : Form
    {
        private Aquarium aquarium;
        private Shop shop;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aquarium = new Aquarium(ResultFishesPanel);
            shop = new Shop(CreateFishPanel);
           // aquarium.AddSpecifiedFish = (x) => x;
        }

        private void Barbus_CheckedChanged(object sender, EventArgs e)
        {
            shop.DisplayFish(shop.DisplayBarbus);
        }

        private void Sackgill_CheckedChanged(object sender, EventArgs e)
        {
            shop.DisplayFish(shop.DisplaySackgill);
        }

        private void Guppi_CheckedChanged(object sender, EventArgs e)
        {
            shop.DisplayFish(shop.DisplayGuppi);
        }

        private void Clown_CheckedChanged(object sender, EventArgs e)
        {
            shop.DisplayFish(shop.DisplayClown);
        }

        private void CreateFishBtn_Click(object sender, EventArgs e)
        {
           
        }


    }
}
