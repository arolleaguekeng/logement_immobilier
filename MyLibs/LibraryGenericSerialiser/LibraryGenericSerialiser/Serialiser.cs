using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace LibraryGenericSerialiser
{
    public enum Mode
    {
        JSON,
        XML,
        BIN
    }
    public class Serializer<T>
    {


        private Mode _mode;
        private static string _path;
        private Dictionary<Mode, Action<T>> serializes;
        private Dictionary<Mode, Func<T>> dserializes;




        #region Serialisation
        public Serializer(Mode mode, string path)
        {
            _mode = mode;
            _path = path;
            serializes = new Dictionary<Mode, Action<T>>();
            serializes.Add(Mode.BIN, SerialiseBinary);
            serializes = new Dictionary<Mode, Action<T>>();
            serializes.Add(Mode.JSON, SerialisationJson);


            dserializes = new Dictionary<Mode, Func<T>>();
            dserializes.Add(Mode.BIN, DeserialisationBinary);
            dserializes = new Dictionary<Mode, Func<T>>();
            dserializes.Add(Mode.JSON, DeserialisationJson);

        }

        public void Serialize(T data)
        {
            serializes[_mode](data);
        }

        private static void SerialiseBinary(T data)
        {
            using (StreamWriter file = new StreamWriter(_path, true))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file.BaseStream, data);
            }
        }

        private static void SerialisationJson(T data)
        {
            using (StreamWriter stream = new StreamWriter(_path))
            {
                JsonTextWriter json = new JsonTextWriter(stream);
                stream.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
                Console.WriteLine("Done");
            }
        }
        #endregion




        #region Deserialisation
        public T Deserialize()
        {
            return dserializes[_mode]();
        }

        private static T DeserialisationBinary()
        {
            using (StreamReader file = new StreamReader(_path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (T)bf.Deserialize(file.BaseStream);
            }
        }
        private static T DeserialisationJson()
        {
            using (StreamReader tes = new StreamReader(_path))
            {
                string sjson = File.ReadAllText(_path);
                return JsonConvert.DeserializeObject<T>(sjson);
            }
        }
        #endregion
    }


}
