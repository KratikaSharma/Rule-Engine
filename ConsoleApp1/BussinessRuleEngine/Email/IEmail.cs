using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.BussinessRuleEngine.Email
{
    interface IEmail
    {
        string GenerateEmail(string payType);
    }
}
