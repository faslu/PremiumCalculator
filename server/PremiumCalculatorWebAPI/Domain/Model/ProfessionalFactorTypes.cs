using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculatorWebAPI.Domain.Model
{
    //public enum ProfessionalFactorTypes1
    //{
    //        PROFESSIONAL=1,
    //        WHITECOLLOR=2,
    //        LIGHTMANUAL=3,
    //        HEAVYMANUAL=4,     
    //        DEFAULT =1
    //}

    public static class ProfessionalFactorTypes
    {
        public const double PROFESSIONAL = 1.00d;
        public const double WHITECOLLOR = 1.25d;
        public const double LIGHTMANUAL = 1.50d;
        public const double HEAVYMANUAL = 1.75d;
        public const double DEFAULT = 1.00d;

    }


}
