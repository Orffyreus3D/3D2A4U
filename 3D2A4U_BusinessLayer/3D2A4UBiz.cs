using JsonFlatFileDataStore;
using _3D2A4U_Model;
using System.Reflection;
using System.ComponentModel.Design;

namespace _3D2A4U_BusinessLayer
{
    public class _3D2A4UBusinessLayer(string path)
    {
        private readonly DataStore ds = new(path);

        public List<Model> GetModels(Dictionary<string,string> Filters)
        {
            var q = ds.GetCollection<Model>().AsQueryable();
            foreach (var filter in Filters)
            {
                var pi = typeof(Model).GetProperty(filter.Key);
                q = q.Where(i => pi?.GetValue(i)?.ToString() == filter.Value);
            }

            return q.ToList();
        }

        public Model GetModel(Guid id)
        {
            return ds.GetItem(id.ToString());
        }

        public void SaveModel(Model model)
        {
            //Task<bool> result;
            dynamic result;

            if (ds.GetItem(model.Id.ToString()) != null)
                result = ds.InsertItem(model.Id.ToString(), model);
            else
                result = ds.UpdateItem(model.Id.ToString(), model);
                //result = ds.UpdateItemAsync(model.Id.ToString(), model).Result;
        }

        public List<LookupValue> GetLookupValues(string typeName)
        {
           return ds.GetCollection<LookupValue>(typeName).AsQueryable().ToList();
        }

        public void Save(LookupValue value)
        {
            dynamic coll = ds.GetCollection(value.GetType().Name);
            if (value.Id == -1) //take highest ID and add one to it to get new assigned ID
                value.Id = coll.GetNextIdValue(); 
            coll.ReplaceOne(value.Id, value, true);
        }
    }
}
