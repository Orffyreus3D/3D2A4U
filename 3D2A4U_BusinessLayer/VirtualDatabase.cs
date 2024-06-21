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
            BarrelLength = (IList<dynamic>)GetList(typeof(BarrelLength).Name);
            BarrelPattern = (IList<BarrelPattern>)GetList(typeof(BarrelPattern).Name);
            Caliber = (IList<Caliber>)GetList(typeof(Caliber).Name);
            Clone = (IList<CloneOf>)GetList(typeof(CloneOf).Name);
            Developer = (IList<Developer>)GetList(typeof(Developer).Name);
            DevTeam = (IList<DevTeam>)GetList(typeof(DevTeam).Name);
            FileFormat = (IList<FileFormat>)GetList(typeof(FileFormat).Name);
            FireControlPattern = (IList<FireControlPattern>)GetList(typeof(FireControlPattern).Name);
            GripPattern = (IList<GripPattern>)GetList(typeof(GripPattern).Name);
            MagPattern = (IList<MagazinePattern>)GetList(typeof(MagazinePattern).Name);
            ModelType = (IList<ModelType>)GetList(typeof(ModelType).Name);
            RailType = (IList<RailType>)GetList(typeof(RailType).Name);
            ReceiverPattern = (IList<ReceiverPattern>)GetList(typeof(ReceiverPattern).Name);
            StockPattern = (IList<StockPattern>)GetList(typeof(StockPattern).Name);
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
            List<dynamic> retval = [];
            dynamic nads = ds.GetCollection(ValueType.Name).AsQueryable().ToList();

            foreach (var item in nads)
            {
                var biff = Activator.CreateInstance(ValueType);
                ((LookupValue)biff).Id = (int)item.id;
                ((LookupValue)biff).Name = item.name;
                ((LookupValue)biff).SortOrder = (int)item.sortOrder;
                retval.Add(biff);
            }

            return retval.OrderBy(l=> l.SortOrder).ThenBy(l=>l.Name).ToList();
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
            PropertyInfo pi = this.GetType().GetProperties().Where(p=>p.PropertyType.IsSubclassOf(typeof(LookupValue)) && p.Name==typeName).FirstOrDefault();
            return (LookupValue)pi.GetValue(this);
        }

        public void Save(LookupValue lookupValue )
        {
            dynamic beaf = this.GetType().GetProperty(lookupValue.GetType().Name)?.GetValue(this);
            if (beaf != null)
            {
                //((DocumentCollection)beaf).GetNextIdValue(lookupValue);
            }
        }

        #region ILists/Properties
        public IList<BarrelLength> BarrelLength { get; set; }
        public IList<BarrelPattern> BarrelPattern { get; set; }
        public IList<Caliber> Caliber { get; set; }
        public IList<CloneOf> Clone { get; set; }
        public IList<Developer> Developer { get; set; }
        public IList<DevTeam> DevTeam { get; set; }
        public IList<FileFormat> FileFormat { get; set; }
        public IList<FireControlPattern> FireControlPattern { get; set; }
        public IList<GripPattern> GripPattern { get; set; }
        public IList<MagazinePattern> MagPattern { get; set; }
        public IList<ModelType> ModelType { get; set; }
        public IList<RailType> RailType { get; set; }
        public IList<ReceiverPattern> ReceiverPattern { get; set; }
        public IList<StockPattern> StockPattern { get; set; }
        #endregion
    }
}
