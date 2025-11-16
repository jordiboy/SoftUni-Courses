
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.Utilities
{
    public static class XmlSerializerWrapper
    {
        public static T? Deserialize<T>(string inputXml, string rootAttributeName)
        {
            XmlRootAttribute xmlRootAttribute = new XmlRootAttribute(rootAttributeName);
            XmlSerializer xmlSerializer
                = new XmlSerializer(typeof(T), xmlRootAttribute);

            using StringReader stringReader = new StringReader(inputXml);
            T? importUserDtos = (T?)xmlSerializer.Deserialize(stringReader);

            return importUserDtos;
        }

        public static T? Deserialize<T>(Stream inputStream, string rootAttributeName)
        {
            XmlRootAttribute xmlRootAttribute = new XmlRootAttribute(rootAttributeName);
            XmlSerializer xmlSerializer
                = new XmlSerializer(typeof(T), xmlRootAttribute);

            T? importUserDtos = (T?)xmlSerializer.Deserialize(inputStream);

            return importUserDtos;
        }

        public static string Serialize<T>(T objectToSerialize, string rootAttributeName, IDictionary<string, string>? namespaces = null)
        {
            StringBuilder result = new StringBuilder();

            XmlSerializerNamespaces xmlNamespaces = new XmlSerializerNamespaces();
            if (namespaces == null)
            {
                xmlNamespaces.Add(string.Empty, string.Empty);
            }
            else
            {
                foreach (KeyValuePair<string, string> nsKvp in namespaces)
                {
                    xmlNamespaces.Add(nsKvp.Key, nsKvp.Value);
                }
            }

            XmlRootAttribute xmlRootAttribute
                = new XmlRootAttribute(rootAttributeName);
            XmlSerializer xmlSerializer
                = new XmlSerializer(typeof(T), xmlRootAttribute);

            using StringWriter stringWriter = new StringWriter(result);
            xmlSerializer.Serialize(stringWriter, objectToSerialize, xmlNamespaces);

            return result.ToString();
        }

        public static void Serialize<T>(T objectToSerialize, string rootAttributeName,
            Stream serializationStream, IDictionary<string, string>? namespaces = null)
        {
            XmlSerializerNamespaces xmlNamespaces = new XmlSerializerNamespaces();
            if (namespaces == null)
            {
                xmlNamespaces.Add(string.Empty, string.Empty);
            }
            else
            {
                foreach (KeyValuePair<string, string> nsKvp in namespaces)
                {
                    xmlNamespaces.Add(nsKvp.Key, nsKvp.Value);
                }
            }

            XmlRootAttribute xmlRootAttribute
                = new XmlRootAttribute(rootAttributeName);
            XmlSerializer xmlSerializer
                = new XmlSerializer(typeof(T), xmlRootAttribute);

            xmlSerializer.Serialize(serializationStream, objectToSerialize, xmlNamespaces);
        }
    }
}
