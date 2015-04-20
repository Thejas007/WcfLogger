using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldService
{
    [WcfMessageLogger]
   public class HelloWorld:IHelloWorld
    {
        #region Implementation of IHelloWorld
      
        public string Hello(string name)
        {
            return "Hello " + name;
        }

        #endregion
    }
}
