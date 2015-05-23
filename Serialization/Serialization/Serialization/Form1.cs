using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
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
        private DatabaseRepository dbRepo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aquarium = new Aquarium(ResultFishesPanel);
            shop = new Shop(CreateFishPanel);
            dbRepo = new DatabaseRepository("mydb.xml");

           // aquarium.AddSpecifiedFish = (x) => x;
        }

        private void Barbus_CheckedChanged(object sender, EventArgs e)
        {
            shop.DisplayFish(typeof(Barbus));
            timer1.Enabled = true;
        }

        private void Sackgill_CheckedChanged(object sender, EventArgs e)
        {
            shop.DisplayFish(typeof(Sackgill));
            timer1.Enabled = true;
        }

        private void Guppi_CheckedChanged(object sender, EventArgs e)
        {
            shop.DisplayFish(typeof(Guppi));
            timer1.Enabled = true;
        }

        private void Clown_CheckedChanged(object sender, EventArgs e)
        {
            shop.DisplayFish(typeof(Clown));
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!shop.CurrentShelter.IsSubmitted) return;
            aquarium.AddFishToShelter(shop.CurrentShelter.Content);
            timer1.Enabled = false;
        }

        private void LoadFishesBtn_Click(object sender, EventArgs e)
        {
            aquarium.ClearSurface();
            aquarium.Wash();
            var fishes = dbRepo.Load();

            try
            {
                aquarium.AddFishes(fishes);
                MessageBox.Show(@"Fishes was successfully uploaded!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Loading fishes failed!");
            }
            
        }

        private void SaveFishesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbRepo.Save(aquarium.fishes);
                MessageBox.Show(@"Fishes were saved successfully!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Saving fishes failed!");
            }
            
        }

        private void DeleteFishesBtn_Click(object sender, EventArgs e)
        {
            aquarium.ClearSurface();

        }

    }
}
