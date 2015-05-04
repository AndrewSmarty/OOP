using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class DatabaseRepository
    {
        public void Insert(Fish fish)
        {
            BinaryFormatter bf = new BinaryFormatter();
            string dbName = "database.bin";
            if (!File.Exists(dbName))
            {
                using (File.Create(dbName)) { }
            }

            using (Stream stream = new FileStream(dbName, FileMode.Append))
            {
                bf.Serialize(stream, fish);
            }

            
        }
    }
}
