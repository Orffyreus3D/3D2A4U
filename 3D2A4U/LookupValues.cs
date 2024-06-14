using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D2A4U_Model
{
    public abstract class LookupValue
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; }

        public LookupValue() { }

        public LookupValue(string name, int sortOrder)
        {
            Name = name;
            SortOrder = sortOrder;
        }
    }

    //strongly typed to make serialization easier
    public class BarrelLength : LookupValue { }
    public class BarrelPattern : LookupValue { }
    public class Caliber : LookupValue { }
    public class CloneOf : LookupValue { }
    public class Developer : LookupValue { }
    public class DevTeam : LookupValue { }
    public class FileFormat : LookupValue { }
    public class FireControlPattern : LookupValue { }
    public class GripPattern : LookupValue { }
    public class MagPattern : LookupValue { }
    public class ModelType : LookupValue { }
    public class RailType : LookupValue { }
    public class ReceiverPattern : LookupValue { }
    public class StockPattern : LookupValue { }

}
