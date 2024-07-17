using _3D2A4U_Model;
using JsonFlatFileDataStore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static _3D2A4U_Model.Model;

namespace _3D2A4U_BusinessLayer
{
    public class VirtualDatabase
    {
        private DataStore ds; //NOTE: reload me after writing to me somewhere else because cache
        private string FilePath { get; set; }

        public VirtualDatabase(string path) 
        {
            FilePath = path;
            ds = new DataStore(path);
            BarrelLength = GetList<BarrelLength>();
            BarrelPattern = GetList<BarrelPattern>();
            Caliber = GetList<Caliber>();
            CloneOf = GetList<CloneOf>();
            Developer = GetList<Developer>();
            DevTeam = GetList<DevTeam>();
            FileFormat = GetList<FileFormat>();
            FireControlPattern = GetList<FireControlPattern>();
            GripPattern = GetList<GripPattern>();
            MagazinePattern = GetList<MagazinePattern>();
            ModelType = GetList<ModelType>();
            RailType = GetList<RailType>();
            ReceiverPattern = GetList<ReceiverPattern>();
            StockPattern = GetList<StockPattern>();
        }

        /// <summary>
        /// Reload the datastore, so that recent changes will show up
        /// </summary>
        public void BumpDS() { ds = new DataStore(FilePath); }

        /// <summary>
        /// Gets a List of ValueType from the  VirtualDB
        /// </summary>
        /// <param name="ValueType">Collection of LookupValue child class</param>
        /// <returns>A list of the entries of this type</returns>
        public IList GetList(Type ValueType)
        {
            dynamic retval = Activator.CreateInstance(typeof(List<>).MakeGenericType(ValueType));
            dynamic nads = ds.GetCollection(ValueType.Name).AsQueryable().ToList();

            foreach (var item in nads)
            {
                var biff = Activator.CreateInstance(ValueType);
                ((LookupValue)biff).Id = (int)item.id;
                ((LookupValue)biff).Name = item.name;
                ((LookupValue)biff).SortOrder = (int)item.sortOrder;
                ((IList)retval).Add((LookupValue)biff);
            }

            return (IList)retval; //.OrderBy(l=> l.SortOrder).ThenBy(l=>l.Name).ToList();
        }

        public IList<T> GetList<T>() where T : LookupValue
        {
            Type valueType = typeof(T);
            IList<T> retval = new List<T>();
            retval = (IList<T>)GetList(valueType);
            retval = retval.OrderBy(l => (l as LookupValue).SortOrder).ThenBy(l => l.Name).ToList();
            return retval;
        }

        public IList GetList(string ValueTypeName)
        {
            Type type = Assembly.GetAssembly(typeof(Model)).GetType("_3D2A4U_Model." + ValueTypeName);
            Debug.Assert(type != null,"Type " + ValueTypeName + " was not found in the Model's assembly");
            return GetList(type);
        }

        public LookupValue GetLookupValue(string typeName, string valueName)
        {
            //find the list in VDB that will have our value
            //PropertyInfo pi = this.GetType().GetProperties().Where(p=>p.PropertyType.IsSubclassOf(typeof(LookupValue)) && p.Name==typeName).FirstOrDefault();
            PropertyInfo pi = this.GetType().GetProperties().Where(p => p.Name == typeName).FirstOrDefault();
            IList valueCollection = (IList)pi.GetValue(this);
            return (LookupValue)valueCollection.Cast<LookupValue>().Where(v => v.Name == valueName).FirstOrDefault();
        }

        public void Save(LookupValue lookupValue )
        {
            dynamic beaf = this.GetType().GetProperty(lookupValue.GetType().Name)?.GetValue(this);
            if (beaf != null)
            {
                //((DocumentCollection)beaf).GetNextIdValue(lookupValue);
            }
        }

        public List<Model> GetModels()
        {
            return new List<Model>(); 
        }


        public Model GetModelFromWad(ModelWad wad)
        {
            Model getMod = new Model();

            //dynamically map all values to the correct one
            foreach (PropertyInfo pwad in typeof(ModelWad).GetProperties().Where(pi => pi.PropertyType == typeof(LookupValue)))
            {
                PropertyInfo pmod = typeof(Model).GetProperty(pwad.Name);
                dynamic val = pmod.GetValue(wad);
                if (pmod.PropertyType == typeof(LookupValue))
                    val = GetLookupValue(pmod.Name, val.ToString());
                pmod.SetValue(getMod, pmod.GetValue(wad, null), null);
            }

            return getMod;
        }

        #region ILists/Properties
        public IList<BarrelLength> BarrelLength { get; set; }
        public IList<BarrelPattern> BarrelPattern { get; set; }
        public IList<Caliber> Caliber { get; set; }
        public IList<CloneOf> CloneOf { get; set; }
        public IList<Developer> Developer { get; set; }
        public IList<DevTeam> DevTeam { get; set; }
        public IList<FileFormat> FileFormat { get; set; }
        public IList<FireControlPattern> FireControlPattern { get; set; }
        public IList<GripPattern> GripPattern { get; set; }
        public IList<MagazinePattern> MagazinePattern { get; set; }
        public IList<ModelType> ModelType { get; set; }
        public IList<RailType> RailType { get; set; }
        public IList<ReceiverPattern> ReceiverPattern { get; set; }
        public IList<StockPattern> StockPattern { get; set; }
        #endregion
    }
}
