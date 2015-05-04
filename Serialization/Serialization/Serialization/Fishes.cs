using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public class Fishes 
    {
        private List<Fish> fishes;

        public void AddFish(Fish fish)
        {
            fishes.Add(fish);
        }

        public IEnumerable<Fish> GetFishes()
        {
            return fishes;
        }



        

    }
}
