using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomainPersistence
{
    public interface ISuplierPersistence
    {
        /// <summary>
        /// insert a suplier in the table Supliers, return -1 if error
        /// </summary>
        /// <param name="suplier"></param>
        /// <returns></returns>
         int CreateSuplier(SuplierStructure suplierStructure);
        /// <summary>
        /// Read one row of the table Supliers, return -1 if error
        /// </summary>
        /// <param name="suplier"></param>
        /// <returns></returns>
        SuplierStructure ReadOneSuplierById(int idSuplier);
        /// <summary>
        /// Update a row of the table Supliers, return true if success
        /// </summary>
        /// <param name="suplier"></param>
        /// <returns></returns>
        bool UpdateSuplier(SuplierStructure suplier);
        /// <summary>
        /// Delete a specific row of the table Supliers, return true if success
        /// </summary>
        /// <param name="suplier"></param>
        /// <returns></returns>
        bool DeleteSuplierById(int idSuplier);
    }
}
