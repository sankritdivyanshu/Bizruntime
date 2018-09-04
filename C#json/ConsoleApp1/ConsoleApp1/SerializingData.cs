using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    class SerializingData
    {
        Stream stream = null;
        BinaryFormatter bformatter = null;
        string textFilename = "";
        public SerializingData(string filename)
        {
            textFilename = filename;
            stream = File.Open(textFilename, FileMode.Create);
            bformatter = new BinaryFormatter();
        }
        public void SerializeObject(object objecttoSerialize)
        {
            bformatter.Serialize(stream, objecttoSerialize);
        }
        public void Deserializeobjects()
        {
            object objectToDeserialize = null;
            stream = File.Open(textFilename, FileMode.Open);
        }
        public void closeStream()
        {
            stream.Close();
        }
       
   }
}