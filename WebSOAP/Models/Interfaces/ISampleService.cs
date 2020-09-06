using System.ServiceModel;

namespace WebSOAP.Models.Interfaces
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string s);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

        [OperationContract]
        MyCustomModel TestCustomModel(MyCustomModel inputModel);
    }
}
