﻿using System;
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
        public MagazinePattern MagPattern { get; set; }
        public ModelType ModelType { get; set; }
        public string Name { get; set; }
        public RailType RailType { get; set; }
        public ReceiverPattern ReceiverPattern { get; set; }
        public StockPattern StockPattern { get; set; }
        public Url Url { get; set; }

        public Model()
        {
            Id = Guid.NewGuid();
        }
    }
}
