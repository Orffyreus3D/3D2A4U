using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _3D2A4U_Model
{
    [Serializable]
    public class Model
    {
        public delegate LookupValue GetLookupValue(int id);

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
        public List<LookupValue> LookupValues
        {
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

        public ModelWad AsModelWad()
        {
            return new ModelWad(this); 
        }

        public void LoadModelWad(ModelWad modelWad, GetLookupValue loadMethod)
        {
            //TODO: refactor this to use a loop with reflection and activator
            BarrelLength = (BarrelLength)loadMethod.DynamicInvoke(modelWad.BarrelLength);
            BarrelPattern = (BarrelPattern)loadMethod.DynamicInvoke(modelWad.BarrelPattern);
            Caliber = (Caliber)loadMethod.DynamicInvoke(modelWad.Caliber);
            CloneOf = (CloneOf)loadMethod.DynamicInvoke(modelWad.CloneOf);
            Description = modelWad.Description;
            Developer = (Developer)loadMethod.DynamicInvoke(modelWad.Developer);
            DevTeam = (DevTeam)loadMethod.DynamicInvoke(modelWad.DevTeam);
            FileFormat = (FileFormat)loadMethod.DynamicInvoke(modelWad.FileFormat);
            FireControlPattern = (FireControlPattern)loadMethod.DynamicInvoke(modelWad.FireControlPattern);
            GripPattern = (GripPattern)loadMethod.DynamicInvoke(modelWad.GripPattern);
            MagazinePattern = (MagazinePattern)loadMethod.DynamicInvoke(modelWad.MagazinePattern); 
            ModelType = (ModelType)loadMethod.DynamicInvoke(modelWad.ModelType);
            Name = modelWad.Name;
            RailType = (RailType)loadMethod.DynamicInvoke(modelWad.RailType);
            ReceiverPattern = (ReceiverPattern)loadMethod.DynamicInvoke(modelWad.ReceiverPattern);
            StockPattern = (StockPattern)loadMethod.DynamicInvoke(modelWad.StockPattern);
            Url = modelWad.Url;
        }

        [Serializable]
        public class ModelWad
        {
            public Guid Id { get; set; }
            public int? BarrelLength { get; set; }
            public int? BarrelPattern { get; set; }
            public int? Caliber { get; set; }
            public int? CloneOf { get; set; }
            public string Description { get; set; }
            public int? Developer { get; set; }
            public int? DevTeam { get; set; }
            public int? FileFormat { get; set; }
            public int? FireControlPattern { get; set; }
            public int? GripPattern { get; set; }
            public int? MagazinePattern { get; set; }
            public int? ModelType { get; set; }
            public string Name { get; set; }
            public int? RailType { get; set; }
            public int? ReceiverPattern { get; set; }
            public int? StockPattern { get; set; }
            public string Url { get; set; }

            public ModelWad() { }
            public ModelWad(Model model)
            {
                this.Id = model.Id;
                //TODO: iterate thru all properties of type LookupValue to do this more scalably
                this.BarrelPattern = model.BarrelPattern?.Id;
                this.BarrelLength = model.BarrelLength?.Id;
                this.Caliber = model.Caliber?.Id;
                this.CloneOf = model.CloneOf?.Id;
                this.Description = model.Description;
                this.Developer = model.Developer?.Id;
                this.DevTeam = model.DevTeam?.Id;
                this.FileFormat = model.FileFormat?.Id;
                this.FireControlPattern = model.FireControlPattern?.Id;
                this.GripPattern = model.GripPattern?.Id;
                this.MagazinePattern = model.MagazinePattern?.Id;
                this.ModelType = model.ModelType?.Id;
                this.Name = model.Name;
                this.RailType = model.RailType?.Id;
                this.ReceiverPattern = model.ReceiverPattern?.Id;
                this.StockPattern = model.StockPattern?.Id;
                this.Url = model.Url;
            }
        }
    }
}
