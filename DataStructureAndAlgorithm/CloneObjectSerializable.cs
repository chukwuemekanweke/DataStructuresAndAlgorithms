using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DataStructureAndAlgorithm
{
    public static class CloneObjectSerializable
    {
        public static T CloneObject<T>(this T obj) where T: class
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, obj);
            ms.Position = 0;
            object result = bf.Deserialize(ms);
            ms.Close();
            return (T)result;
        }
        }
    }

