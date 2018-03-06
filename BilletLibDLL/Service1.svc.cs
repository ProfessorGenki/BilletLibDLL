using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLib;

namespace BilletLibDLL
{
    public class Service1 : IService1
    {

        public int PrisBil()
        {
            Bil NyBil = new Bil("1234567", new DateTime(2018, 4, 20), false, false);

            return NyBil.Pris();
        }
    }
}
