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
            BarrelLength = ds.GetCollection<BarrelLength>();
            BarrelPattern = ds.GetCollection<BarrelPattern>();
            Caliber = ds.GetCollection<Caliber>();
            Clone = ds.GetCollection<CloneOf>();
            Developer = ds.GetCollection<Developer>();
            DevTeam = ds.GetCollection<DevTeam>();
            FileFormat = ds.GetCollection<FileFormat>();
            FireControlPattern = ds.GetCollection<FireControlPattern>();
            GripPattern = ds.GetCollection<GripPattern>();
            MagPattern = ds.GetCollection<MagazinePattern>();
            ModelType = ds.GetCollection<ModelType>();
            RailType = ds.GetCollection<RailType>();
            ReceiverPattern = ds.GetCollection<ReceiverPattern>();
            StockPattern = ds.GetCollection<StockPattern>();
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

        public void Save(LookupValue lookupValue )
        {
            dynamic beaf = this.GetType().GetProperty(lookupValue.GetType().Name)?.GetValue(this);
            if (beaf != null)
            {
                //((DocumentCollection)beaf).GetNextIdValue(lookupValue);
            }
        }

        #region IDocumentCollections/Properties
        public IDocumentCollection<BarrelLength> BarrelLength { get; set; }
        public IDocumentCollection<BarrelPattern> BarrelPattern { get; set; }
        public IDocumentCollection<Caliber> Caliber { get; set; }
        public IDocumentCollection<CloneOf> Clone { get; set; }
        public IDocumentCollection<Developer> Developer { get; set; }
        public IDocumentCollection<DevTeam> DevTeam { get; set; }
        public IDocumentCollection<FileFormat> FileFormat { get; set; }
        public IDocumentCollection<FireControlPattern> FireControlPattern { get; set; }
        public IDocumentCollection<GripPattern> GripPattern { get; set; }
        public IDocumentCollection<MagazinePattern> MagPattern { get; set; }
        public IDocumentCollection<ModelType> ModelType { get; set; }
        public IDocumentCollection<RailType> RailType { get; set; }
        public IDocumentCollection<ReceiverPattern> ReceiverPattern { get; set; }
        public IDocumentCollection<StockPattern> StockPattern { get; set; }
        #endregion
    }
}
