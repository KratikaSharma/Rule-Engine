using ConsoleApp1.BussinessRuleEngine.Book;
using ConsoleApp1.BussinessRuleEngine.Email;
using ConsoleApp1.BussinessRuleEngine.Membership;
using ConsoleApp1.BussinessRuleEngine.Upgrad;
using ConsoleApp1.BussinessRuleEngine.Video;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BussinessRuleEngine.RuleEngine
{
    public class Payment 
    {
        string _productType;
       public Payment(string productType)
        {
            _productType = productType;
        }
        public string ProcessRuleEngine()
        {
            string _output = "Please choose a valid product type";
            if(_productType == ProductType.physicalProduct)
            {
                _output = ProcessPhysicalProduct();
            }
            if (_productType == ProductType.book)
            {
                _output = ProcessBook();
            }
            if (_productType == ProductType.membership)
            {
                _output = ProcessMembership();
            }
            if (_productType == ProductType.upgrad)
            {
                _output = ProcessUpgrad();
            }
            if (_productType == ProductType.video)
            {
                _output = ProcessVideo();
            }
            return _output;
        }

        private static string ProcessVideo()
        {
            string _output;
            IVideo video = new Video();
            _output = video.AddFirstAddVideoToPackaginSlip();
            return _output;
        }

        private string ProcessUpgrad()
        {
            string _output;
            IUpgrad upgrad = new Upgrad();
            _output = upgrad.ApplyUpgrad();
            IEmail email = new Email();
            _output += "," + email.GenerateEmail(_productType);
            return _output;
        }

        private string ProcessMembership()
        {
            string _output;
            IMembership membership = new Membership();
            _output = membership.ActivateMembership();
            IEmail email = new Email();
            _output += "," + email.GenerateEmail(_productType);
            return _output;
        }

        private static string ProcessBook()
        {
            string _output;
            IBook book = new Book();
            _output = book.CreateDuplicatePacageSlip();
            return _output;
        }

        private static string ProcessPhysicalProduct()
        {
            string _output;
            PhysicalProductExtension physicalProductEx = new PhysicalProductExtension();
            _output = physicalProductEx.GeneratePackagingforShipping();
            _output += "," + physicalProductEx.GenerateCommsionPayment();
            return _output;
        }
    }
}