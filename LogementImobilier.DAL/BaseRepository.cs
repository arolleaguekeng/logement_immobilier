using LogementImobilier.BO;
using LibraryGenericSerialiser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogementImobilier.DAL
{
    public class BaseRepository<T> where T : BaseModel 
    {
        protected List<T> datas;
        private readonly string PATH;
        private Serializer<List<T>> serializer;
        public BaseRepository()
        {
            PATH = $"Data/{typeof(T).Name}.json";
            datas = new List<T>();
            FileInfo fi = new FileInfo(PATH);
            if (!fi.Directory.Exists)
                fi.Directory.Create();
            serializer = new Serializer<List<T>>(Mode.JSON, PATH);
            restore();
        }
        public void Add(T obj)
        {
            foreach (var data in datas)
                if (data.Equals(obj))
                    throw new DuplicateWaitObjectException($"{typeof(T)} already exits ! ");
            datas.Add(obj);
            Save();
        }


        public void Set(T oldObj, T newObj)
        {
            var oldIndex = -1;
            for (int i = 0; i < datas.Count; i++)
                //  if (datas[i].Equals(oldObj))
                oldIndex = i;
            if (oldIndex < 0)
                throw new KeyNotFoundException($"{typeof(T).Name} not found");
            var newIndex = -1;
            for (int i = 0; i < datas.Count; i++)
                if (datas[i].Equals(oldObj))
                    newIndex = i;
            if (newIndex >= 0 && newIndex != oldIndex)
                throw new KeyNotFoundException($"{typeof(T).Name} not Found");
            datas[oldIndex] = newObj;
            Save();
        }

        public void Delete(T obj)
        {
            var index = -1;

            for (int i = 0; i < datas.Count; i++)
                if (datas[i].Equals(obj))
                    index = i;
            if (index >= 0)
                datas.RemoveAt(index);
            Save();
        }
        public void Save()
        {
            serializer.Serialize(datas);
        }
        public void restore()
        {

            FileInfo fi = new FileInfo(PATH);
            if (fi.Exists && fi.Length > 0)
                datas = serializer.Deserialize();
        }

        public List<T> GetAll()
        {
            T[] copy = new T[datas.Count];
            datas.CopyTo(copy);
            return copy.ToList();
        }
    }
}
