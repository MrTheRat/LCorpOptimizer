using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCorpOptimizerLogic.Enums
{
    public class EnumClass
    {
        public enum DamageType
        {
            Red,
            Black,
            White,
            Pale
        }

        public enum AttackSpeed
        {
            VerySlow,
            Slow,
            Normal,
            Fast,
            VeryFast
        }

        public enum Range 
        {
            VeryLong,
            Long,
            Medium,
            Short,
            VeryShort
        }

        public enum AbnormalityType
        {
            Normal,
            SingleUseTool,
            ChannelUseTool,
            HeldTool
        }

        public enum WorkFavor
        {
            VeryLow,
            Low,
            Common,
            High,
            VeryHigh
        }
    }
}
