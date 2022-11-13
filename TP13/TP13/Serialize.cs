using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace TP13
{
    public class Serialize
    {
        public static void serializeClass()
        {
            List<Voo> voos = Desserialize.readAndDesserializeXml();
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(voos.GetType());

            var path = "C:\\Users\\Gabriel\\Desktop\\facul\\serialized\\Voos.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            serializer.Serialize(file, voos);
        }
    }
}
