using LCorpOptimizerLogic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCorpOptimizerLogic
{
    public class Abnormality
    {
        //might need to add damage value's
        public EnumClass.DamageType damageType { get; set; }

        /// <summary>
        /// Each work type has five levels and each level can have a different work favor
        /// </summary>
        public EnumClass.WorkFavor instinctWork1 { get; set; }
        public EnumClass.WorkFavor instinctWork2 { get; set; }
        public EnumClass.WorkFavor instinctWork3 { get; set; }
        public EnumClass.WorkFavor instinctWork4 { get; set; }
        public EnumClass.WorkFavor instinctWork5 { get; set; }
        public EnumClass.AbnormalityType abnormalityType { get; set; }
        public int RiskLvl { get; set; }
        public string? Name { get; set; }
        public string? SubjectNum { get; set; }
        public string? effects { get; set; }
    }
}
