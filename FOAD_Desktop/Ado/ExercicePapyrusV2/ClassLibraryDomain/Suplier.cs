using ClassLibraryDataPersistence;
using ClassLibraryDomainPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDomain
{
    public class Suplier
    {
        private ISuplierPersistence suplierPersistence;
        private Object connectionToDb;
        private int id;
        private string name;
        private int streetNumber;
        private string streetName;
        private int zipCode;
        private string cityName;
        private string contact;
        private int satisfaction;

        Suplier()
        {
            
        }

        Suplier(SuplierStructure suplierStructure)
        {
            this.id = suplierStructure.id;
            this.name = suplierStructure.name;
            this.streetNumber = suplierStructure.streetNumber;
            this.streetName = suplierStructure.streetName;
            this.zipCode = suplierStructure.zipCode;
            this.cityName = suplierStructure.cityName;
            this.contact = suplierStructure.contact;
            this.satisfaction = suplierStructure.satisfaction;
        }

        /// <summary>
        /// property for define the connection to the database
        /// </summary>
        public object ConnectionToDb { get => connectionToDb; set => connectionToDb = value; }

        SuplierStructure GetStruct()
        {
            SuplierStructure suplierStructure = new SuplierStructure();
            suplierStructure.id = this.id;
            suplierStructure.name = this.name;
            suplierStructure.streetNumber = this.streetNumber;
            suplierStructure.streetName = this.streetName;
            suplierStructure.zipCode = this.zipCode;
            suplierStructure.cityName = this.cityName;
            suplierStructure.contact = this.contact;
            suplierStructure.satisfaction = this.satisfaction;
            return suplierStructure;
        }

    }
}
