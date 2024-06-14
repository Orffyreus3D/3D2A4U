using JsonFlatFileDataStore;
using _3D2A4U_Model;
using System.Reflection;
using System.ComponentModel.Design;

namespace _3D2A4U_BusinessLayer
{
    public class _3D2A4UBusinessLayer
    {
        private DataStore ds;

        public _3D2A4UBusinessLayer(string path) 
        {
            ds = new DataStore(path);
        }
        
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
            Task<bool> result;

            if (ds.GetItem(model.Id.ToString()) != null)
                result = ds.InsertItemAsync(model.Id.ToString(), model);
            else
                result = ds.UpdateItemAsync(model.Id.ToString(), model);
        }

        public List<LookupValue> GetLookupValues(string typeName)
        {
           return ds.GetCollection<LookupValue>(typeName).AsQueryable().ToList();
        }

        public void Save(LookupValue value)
        {
            if (value.Id == -1)
            {
                //take highest ID and add one to it to get new assigned ID
                value.Id = ds.GetCollection(value.GetType().Name).AsQueryable().OrderByDescending(lv => lv.Id).Select(lv => lv.Id).FirstOrDefault(0) + 1;
                ds.ReplaceItem(value.Id.ToString(), value, true);
                //ds.InsertItem(value.Id.ToString(), value);
            }
            else
                ds.UpdateItem(value.Id.ToString(), value);
        }
    }
}
