using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCorpOptimizerLogic.EmployeeEquipment;

namespace LCorpOptimizerLogic
{
    public class Employee
    {
        public int FortitudeLvl { get; set; }
        public int PrudenceLvl { get; set; }
        public int TemperanceLvl { get; set; }
        public int JudgementLvl { get; set; }
        public Weapon? weapon { get; set; }
        public Armor? armor { get; set; }
        public Gift? gift { get; set; }
    }
}
