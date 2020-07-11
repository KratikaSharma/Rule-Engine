using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessRuleEngine.RuleEngine
{
    public class PhysicalProduct : IPhysicalProduct
    {
        public string GeneratePackagingforShipping()
        {
            return "Pacaging Slip Generated";
        }
    }
}