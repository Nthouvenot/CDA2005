using ClassLibraryPersistance;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnexion
{
    class Program
    {
        static void Main(string[] args)
        {
            PersistanceTrouveUnEmploi pc = new PersistanceTrouveUnEmploi();
            //SqlConnection  sql = pc.CommentRecupererConnexion();
        }
    }
}
