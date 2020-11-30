using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryToutEmbal
{
    public class WoodBoxProduction
    {
        private int numberOfBoxToProduce;
        private int totalNumberOfBoxWithAndWithoutDefault;
        private int numberOfDefault;
        private DateTime dateTimePoductionStart;
        private string boxName;

        //enum declaration
        public enum ProductionState { stoped = 0, started = 1, finished = 2 }
        private ProductionState productionState;
        
        //event declaration
        public delegate void WoodProductionEventDelagate(WoodBoxProduction sender);
        public event WoodProductionEventDelagate WoodBoxProductiontStateChanged;
        public event WoodProductionEventDelagate WoodBoxNumberOfBoxProductedChanged;

        public WoodBoxProduction(int numberOfBoxToProduce, string boxName)
        {
            if (numberOfBoxToProduce > 0)
            {
                this.numberOfBoxToProduce = numberOfBoxToProduce;
            }
            else
            {
                this.numberOfBoxToProduce = 0;
            }
            this.totalNumberOfBoxWithAndWithoutDefault = 0;
            this.productionState = new ProductionState();
            this.productionState = ProductionState.stoped;
            this.boxName = boxName;
        }


        /// <summary>
        /// property of the totalNumberOfBox attribute
        /// </summary>
        public int TotalNumberOfBoxWithAndWithoutDefault
        {
            get => totalNumberOfBoxWithAndWithoutDefault;
            //set => totalNumberOfBox = value; 
        }

        /// <summary>
        /// property of the dateTimePoductionStart attribute
        /// </summary>
        public DateTime DateTimePoductionStart
        {
            get => dateTimePoductionStart;
            set
            {
                if (value < this.dateTimePoductionStart)
                {
                    return;
                }
                this.dateTimePoductionStart = value;
            }
        }

        //property of the numberOfBoxToProduce
        public int NumberOfBoxToProduce
        {
            get => numberOfBoxToProduce;
            //set => numberOfBoxToProduce = value; 
        }

        /// <summary>
        /// return the current state of the production
        /// </summary>
        public ProductionState CurrentProductionState
        {
            get => productionState;
            //set => productionState = value; 
        }

        /// <summary>
        /// return the current box in production
        /// </summary>
        public string BoxName
        {
            get => BoxName;
            //set => currentBoxProduction = value;
        }


        /// <summary>
        ///produce a wood box
        /// </summary>
        public void ProduceBox()
        {
            this.totalNumberOfBoxWithAndWithoutDefault++;
            Random rand = new Random();
            if (rand.Next(0, 1) == 1)
            {
                this.numberOfDefault++;
            }
            if (this.WoodBoxProductiontStateChanged != null && this.totalNumberOfBoxWithAndWithoutDefault == this.numberOfBoxToProduce)
            {
                WoodBoxProductiontStateChanged(this);
            } 
            else if(WoodBoxNumberOfBoxProductedChanged != null)
            {
                WoodBoxNumberOfBoxProductedChanged(this);
            }
        }

        /// <summary>
        /// stop production by users
        /// </summary>
        public bool StopProduction()
        {
            if (this.productionState != ProductionState.started)
            {
                return false;
            }
            this.productionState = ProductionState.stoped;
            return true;
        }

        /// <summary>
        /// restart production by users
        /// </summary>
        public bool RestartProduction()
        {
            if (this.productionState != ProductionState.started)
            {
                return false;
            }
            this.productionState = ProductionState.started;
            return true;
        }

        public float CalculateRateDefaultPerHour()

        {
            System.TimeSpan numberOfHour;
            numberOfHour = this.dateTimePoductionStart - DateTime.Now;
            return ((this.numberOfDefault / numberOfHour.Hours) * 100) / (this.totalNumberOfBoxWithAndWithoutDefault / 60);
        }


        public float CalculateTotalDefaultRate()
        {
            return (this.numberOfDefault * 100) / this.totalNumberOfBoxWithAndWithoutDefault;
        }

        public int CalculateNumberOfGoodBox()
        {
            return this.totalNumberOfBoxWithAndWithoutDefault - this.numberOfDefault;
        }
    }
}
