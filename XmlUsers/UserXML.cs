using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace XmlUsers
{
    /// <summary>
    /// Класс, предоставляющий сериализацию и десериализацию
    /// класса User
    /// </summary>
    public static class UserXML
    {


        public static void SerializeUsers(List<User> users)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));

            FileStream stream = new FileStream("users.xml", FileMode.OpenOrCreate);

            serializer.Serialize(stream, users);

            stream.Close();

        }

        public static List<User> DeserializeUsers()
        {
            List<User> users;

            XmlSerializer deserializer = new XmlSerializer(typeof(List<User>));

            FileStream stream = new FileStream("users.xml", FileMode.OpenOrCreate);

            users = (List<User>)deserializer.Deserialize(stream);

            stream.Close();

            return users;
        }


    }
}
