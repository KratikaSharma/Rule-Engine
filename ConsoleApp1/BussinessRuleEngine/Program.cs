using BussinessRuleEngine.RuleEngine;
using ConsoleApp1.PrimeNum;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Enter Product Type");
                string PaymentType = Console.ReadLine();
                Payment payment = new Payment(PaymentType);
                string _output = payment.ProcessRuleEngine();
                Console.Write(_output);
                Console.ReadLine();
            }
        }
    }
}
