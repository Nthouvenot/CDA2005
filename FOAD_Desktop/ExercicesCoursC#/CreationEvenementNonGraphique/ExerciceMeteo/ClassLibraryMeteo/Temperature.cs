using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTemp
{
    public class Temperature
    {
        private float temperatureCourante;
        private float[] temperatureDAlertes;

        //Declaration des delegates
        public delegate void DelegateGel(Temperature sender);
        public delegate void DelegateFievre(Temperature sender);
        public delegate void DelegateAlerte(Temperature sender);

        //Declaration des evenements
        public event DelegateGel Gel;
        public event DelegateFievre Fievre;
        public event DelegateAlerte Alerte;

        /// <summary>
        /// On initialise la température au zero absolu
        /// </summary>
        public Temperature()
        {
            this.temperatureCourante = -273.15f;
        }

        public float TemperatureCourante
        {
            get => temperatureCourante;
            //set => temperature = value;
        }

        /// <summary>
        /// evenement qui se produit qd risque de gel 0 --- Gel
        /// evenement qui se produit qd on a de la fievre 38--- Fievre
        /// 
        /// 
        /// Cerise sur le gateau:
        /// 
        /// evenement preconfigurable...evenement declenche pour une temperature specifique
        /// </summary>



        /// <summary>
        /// Augmente la température courante si elle n'est pas au dessous dessu de la temperature de la surface du soleil
        /// </summary>
        /// <param name="temperature"></param>
        public void Monter(float temperature)
        {
            if (temperature > 5526f && temperature > this.temperatureCourante)
            {
                return;
            }
            this.temperatureCourante = temperature;
            if (temperature >= 38 && Fievre != null)
            {
                this.Fievre(this);
            }
            //else if (temperatureDAlertes.Contains(temperature) && Alerte != null)
            //{
            //    this.Alerte(this);
            //}
        }

        /// <summary>
        /// Diminue la température courante si elle n'est pas en dessous du zero absolu
        /// </summary>
        /// <param name="_temperature"></param>
        public void Diminuer(float temperature)
        {
            if (temperature < -273.15f && temperature < this.TemperatureCourante)
            {
                return;
            }
            this.temperatureCourante = temperature;
            if (temperature == 0 && Gel != null)
            {
                this.Gel(this);
            }
            //else if (temperatureDAlertes.Contains(temperature) && Alerte != null)
            //{
            //    this.Alerte(this);
            //}
        }
    }
}
