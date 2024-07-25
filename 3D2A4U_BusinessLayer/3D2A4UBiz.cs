using JsonFlatFileDataStore;
using _3D2A4U_Model;
using System.Reflection;
using System.ComponentModel.Design;
using System.ComponentModel;

namespace _3D2A4U_BusinessLayer
{
    public class _3D2A4UBusinessLayer(string path)
    {
        private readonly DataStore ds = new(path);

        public List<Model> GetModels(Dictionary<string,string> Filters)
        {
            VirtualDatabase vdb = new VirtualDatabase(path);

            //build out the query to fetch our stuff
            var q = ds.GetCollection<Model.ModelWad>().AsQueryable();
            List<Model> models = new List<Model>();
            foreach (var filter in Filters)
            {
                var pi = typeof(Model.ModelWad).GetProperty(filter.Key);
                q = q.Where(i => pi?.GetValue(i)?.ToString() == filter.Value);
            }

            //convert each result into a model from modelwad
            foreach (Model.ModelWad wad in q.ToList())
            { 
                Model model = new Model();
                model.LoadModelWad(wad, vdb.GetLookupValue);
            }
                
                //models.Add(vdb.GetModelFromWad(wad));
            

            return models;
        }

        public Model GetModel(Guid id)
        {
            return ds.GetItem(id.ToString());
        }

        /// <summary>
        /// Perform an upsert into the file: if the given model's guid exists, it will be overwritten
        /// </summary>
        /// <param name="model"></param>
        public void SaveModel(Model.ModelWad model)
        {
            dynamic result;

            //if (ds.GetItem<Model.ModelWad>(model.Id.ToString()) != null)
            //if (!ds.GetCollection<Model.ModelWad>().AsQueryable().Any(m => m?.Id.ToString() == model?.Id.ToString()))
                //result = ds.InsertItem<Model.ModelWad>("modelWad", model);
                result = ds.GetCollection("modelWad").ReplaceOne((mw => mw.id == model.Id.ToString()),model,true);
            //else
            //    result = ds.UpdateItem(model.Id.ToString(), model);
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
