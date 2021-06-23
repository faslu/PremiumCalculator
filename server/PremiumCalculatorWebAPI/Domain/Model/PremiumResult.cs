using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PremiumCalculatorWebAPI.Domain.Model
{
    public class PremiumResult
    {
        public PremiumResult()
        { 
        }
        public PremiumResult(double? monthlyAmount=default(double?), string errorMessage = default(string))
        {
            MonthlyAmount = monthlyAmount;
        }

       [JsonProperty(PropertyName="monthlyPremiumAmount")]
       public double? MonthlyAmount { get; set; }

        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
    }
}
