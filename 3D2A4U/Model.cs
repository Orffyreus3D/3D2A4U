using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _3D2A4U_Model
{
    [Serializable]
    public class Model
    {
        public Guid Id { get; set; }
        public BarrelLength BarrelLength { get; set; }
        public BarrelPattern BarrelPattern { get; set; }
        public Caliber Caliber { get; set; }
        public CloneOf CloneOf { get; set; }
        public string Description { get; set; }
        public Developer Developer { get; set; }
        public DevTeam DevTeam { get; set; }
        public FileFormat FileFormat { get; set; }
        public FireControlPattern FireControlPattern { get; set; }
        public GripPattern GripPattern { get; set; }
        public MagazinePattern MagazinePattern { get; set; }
        public ModelType ModelType { get; set; }
        public string Name { get; set; }
        public RailType RailType { get; set; }
        public ReceiverPattern ReceiverPattern { get; set; }
        public StockPattern StockPattern { get; set; }
        public string Url { get; set; }

        /// <summary>
        /// Returns collection of LookupValues where they aren't null
        /// </summary>
        public List<LookupValue> LookupValues { 
            get
            {
                List<LookupValue> values = new List<LookupValue>();
                foreach (LookupValue value in typeof(Model).GetProperties().Where(p => p.PropertyType.IsSubclassOf(typeof(LookupValue)) && ((LookupValue)p.GetValue(this)) != null).Select(p => p.GetValue(this)))
                {
                    values.Add(value);
                }

                return values;
            } 
        }

        /// <summary>
        /// Adds a LookupValue when the type is known but we don't want to bother looking for the right property
        /// </summary>
        /// <param name="value"></param>
        public void AddLookupValue(LookupValue value)
        {
            this.GetType().GetProperty(value.GetType().Name)?.SetValue(this, value);
        }

        public Model()
        {
            Id = Guid.Empty;
        }
    }
}
