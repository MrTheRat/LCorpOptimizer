using LCorpOptimizerLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCorpOptimizerLogic.EmployeeEquipment
{
    public class Weapon
    {
        //might need to add damage value's
        public EnumClass.DamageType damageType { get; set; }
        public EnumClass.AttackSpeed attackSpeed { get; set; }
        public EnumClass.Range range { get; set; }
        public bool FriendlyFire { get; set; }
        public int WeaponID { get; set; }
        public string? WeaponName { get; set; }
        public int WeaponEffect { get; set; }
    }
}
