using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using uzenetprojektWCF.Models;
using uzenetprojektWCF.Services;
using uzenetprojektWCF.Interfaces;

namespace uzenetprojektWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public string CreateUzenet(Uzenet uzenet)
        {
            return new UzenetServices().Create(uzenet);
        }

        public List<Uzenet> GetAllUzenet()
        {
            List<Tablazat> tablazatok = new UzenetServices().Read();
            List<Uzenet> uzenetList = new List<Uzenet>();

            foreach (Tablazat elem in tablazatok)
            {
                uzenetList.Add(elem as Uzenet);
            }
            return uzenetList;
        }


        public string UpdateUzenet(Uzenet uzenet)
        {
            return new UzenetServices().Update(uzenet);
        }

        public string DeleteUzenet(int id)
        {
            return new UzenetServices().Delete(id);
        }

    }
}
