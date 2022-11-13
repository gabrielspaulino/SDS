using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace TP13
{
    class Desserialize : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public static List<Voo> readAndDesserializeXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\Gabriel\\Desktop\\facul\\voos.xml");
            List<Voo> voos = new List<Voo>();
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                Voo voo = new Voo();
                voo.Origem = node.ChildNodes[0].InnerText;
                voo.Destino = node.ChildNodes[1].InnerText;
                voo.Horario = node.ChildNodes[2].InnerText;
                voo.Compania = node.ChildNodes[3].InnerText;
                voo.Operando = node.ChildNodes[4].InnerText;
                voos.Add(voo);
            }
            return voos;
        }
    }
}
