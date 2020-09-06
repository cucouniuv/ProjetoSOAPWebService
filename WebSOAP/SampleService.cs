using System;
using System.Xml.Linq;
using WebSOAP.Models;
using WebSOAP.Models.Interfaces;

namespace WebSOAP
{
    public class SampleService : ISampleService
    {
        public string Test(string s)
        {
            Console.WriteLine("Test Method Executed!");
            return s + " (Passou por SampleService - método Test)";
        }

        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }

        public MyCustomModel TestCustomModel(MyCustomModel customModel)
        {
            return customModel;
        }
    }
}




