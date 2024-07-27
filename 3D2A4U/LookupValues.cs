using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D2A4U_Model
{
    public abstract class LookupValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public LookupValue() { }

        public LookupValue(string name, int sortOrder)
        {
            Id = -1;
            Name = name;
            SortOrder = sortOrder;
        }

		public override string ToString()
		{
			return Name;
		}

		public abstract dynamic GetAsDocumentCollection();

        public Type GetDocumentCollectionType()
        {
            return GetDocumentCollectionType(this);
        }

        public Type GetDocumentCollectionType<T>() where T : LookupValue
        {
            return typeof(DocumentCollection<T>);
        }

        public Type GetDocumentCollectionType<T>(T lookupValue) where T : LookupValue
        {
            return typeof(DocumentCollection<T>);
        }
    }

    //strongly typed to make serialization easier
    public class BarrelLength : LookupValue { 
        public BarrelLength() : base() { }
        public BarrelLength(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<BarrelLength>); } 
    }
    public class BarrelPattern : LookupValue {
        public BarrelPattern() : base() { }
        public BarrelPattern(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<BarrelPattern>); } 
    }
    public class Caliber : LookupValue {
        public Caliber() : base() { }
        public Caliber(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<Caliber>); }
    }
    public class CloneOf : LookupValue {
        public CloneOf() : base() { }
        public CloneOf(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<CloneOf>); } 
    }
    public class Developer : LookupValue { 
        public Developer() : base() { }
        public Developer(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<Developer>); } 
    }
    public class DevTeam : LookupValue { 
        public DevTeam() : base() { }
        public DevTeam(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<DevTeam>); } 
    }
    public class FileFormat : LookupValue { 
        public FileFormat() : base() { }
        public FileFormat(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<FileFormat>); } 
    }
    public class FireControlPattern : LookupValue { 
        public FireControlPattern() : base() { }
        public FireControlPattern(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<FireControlPattern>); } 
    }
    public class GripPattern : LookupValue { 
        public GripPattern() : base() { }
        public GripPattern(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<GripPattern>); } 
    }
    public class MagazinePattern : LookupValue { 
        public MagazinePattern() : base() { }
        public MagazinePattern(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<MagazinePattern>); } 
    }
    public class ModelType : LookupValue { 
        public ModelType() : base() { }
        public ModelType(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<ModelType>); } 
    }
    public class RailType : LookupValue { 
        public RailType() : base() { }
        public RailType(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<RailType>); } 
    }
    public class ReceiverPattern : LookupValue {
        public ReceiverPattern() : base() { }
        public ReceiverPattern(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<ReceiverPattern>); } 
    }
    public class StockPattern : LookupValue {
        public StockPattern() : base() { }
        public StockPattern(string name, int sortOrder) : base(name, sortOrder) { }
        public override dynamic GetAsDocumentCollection() { return typeof(DocumentCollection<StockPattern>); }
    }

}
