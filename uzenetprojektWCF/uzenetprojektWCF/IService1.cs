using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using uzenetprojektWCF.Models;


namespace uzenetprojektWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]

        List<Uzenet> GetAllUzenet();

        [OperationContract]

        string CreateUzenet(Uzenet uzenet);

        [OperationContract]

        string UpdateUzenet(Uzenet uzenet );

        [OperationContract]

        string DeleteUzenet(int id);

    }
}
