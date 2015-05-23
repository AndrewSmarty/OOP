using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class DatabaseRepository
    {
        private string dbname;

        public DatabaseRepository(string dbname)
        {
            this.dbname = dbname;
        }

        public List<Fish> Load()
        {
            using (FileStream filest = new FileStream(dbname, FileMode.Open, FileAccess.Read))
            {
                var serialiser = new XmlSerializer(typeof(List<Fish>));
                return (List<Fish>)serialiser.Deserialize(filest);
            }
        }

        public void Save(List<Fish> fishes)
        {
            using (FileStream filest = new FileStream(dbname, FileMode.Create, FileAccess.Write))
            {
                var serialiser = new XmlSerializer(typeof(List<Fish>));
                serialiser.Serialize(filest, fishes);
            }
        }

    }
}
