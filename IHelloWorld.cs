using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
[ServiceContract]
    public interface IHelloWorld
    {
    [OperationContract]    
    string Hello(string name);
   }
}
