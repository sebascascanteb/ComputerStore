﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Layers.Util
{
     class JSONGenericObject <T>
    {
        public static T JSonToObject(string pDatos)
        {

            T @object = (T)JsonConvert.DeserializeObject<T>(pDatos);

            return @object;

        }
    }
}
