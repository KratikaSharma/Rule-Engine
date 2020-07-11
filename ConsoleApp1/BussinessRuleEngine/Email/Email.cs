using BussinessRuleEngine.RuleEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.BussinessRuleEngine.Email
{
    public class Email : IEmail
    {
        public string GenerateEmail(string payType)
        {
            if(payType == ProductType.membership)
            {
                return "Membership activation mail sent";
            }
            else if(payType == ProductType.upgrad)
            {
                return "Membership upgarde mail sent";
            }
            else
            {
                return "Invalid Payment Type";
            }
        }
    }
}
