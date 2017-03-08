using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaDeposu
{
    class ConnectionString
    {
        internal static string GetConnectionString()
        {
            //Util-2 Assume failure.  
            string returnValue = "data source= MINE\\SQLEXPRESS;database = eczaDeposu;integrated security = SSPI";

            return returnValue;
        }
    }
    
}
