//using System;
//using System.IO;
//using System.Text;
//using System.Xml;
//using System.Xml.Serialization;

//namespace TssCargoVision.Serialization
//{
//    public class XmlStreamSerializer
//    {
//        public string Serialize<T>(T content)
//        {
//            if (content == null)
//                throw new ArgumentNullException(nameof(content));

//            var serializer = new XmlSerializer(typeof(T));

//            var sb = new StringBuilder();
//            using var sw = new StringWriter(sb);

//            serializer.Serialize(sw, content);

//            return sb.ToString();
//        }

//        public T Deserialize<T>(string value)
//        {
//            if (value == null)
//                throw new ArgumentNullException(nameof(value));

//            var serializer = new XmlSerializer(typeof(T));
//            return (T)serializer.Deserialize(new StringReader(value));
//        }
//    }
//}
