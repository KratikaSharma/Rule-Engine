using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessRuleEngine.RuleEngine
{
    public class PhysicalProductExtension : PhysicalProduct
    {
        public string GenerateCommsionPayment()
        {
            return "Comission Payment Generated";
        }
    }
}