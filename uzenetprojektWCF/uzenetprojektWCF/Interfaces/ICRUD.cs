using uzenetprojektWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzenetprojektWCF.Interfaces
{
    public interface ICRUD
    {
        string Create(Tablazat tablazat);

        List<Tablazat> Read();

        string Update(Tablazat tablazat);

        string Delete(int id);
    }
}
