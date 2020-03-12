using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TweetCool
{
    public class DataManager
    {
        const String FILENAME = "Tweets.xml";

        public void Save(List<Tweet> data)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Tweet>));

            using (TextWriter writerfinal = new StreamWriter(FILENAME))
            {
                writer.Serialize(writerfinal, data);
            }
        }

        public List<Tweet> Import()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Tweet>));
            List<Tweet> i;
            using (FileStream readfile = File.OpenRead(FILENAME))
            {
                i = (List<Tweet>)reader.Deserialize(readfile);
            }
            return i;
        }
    }
}
