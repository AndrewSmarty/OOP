﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class ObjToSerialize
    {
        public List<Fish> Bson;

        public ObjToSerialize()
        {
            Bson = new List<Fish>();
        }

    }
}
