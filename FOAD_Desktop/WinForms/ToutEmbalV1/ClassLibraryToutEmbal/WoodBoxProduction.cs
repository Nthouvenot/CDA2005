using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ClassLibraryToutEmbal
{
    public class WoodBoxProduction
    {
        private int numberOfBoxToProduce;
        private int productionRate;
        private int totalNumberOfBoxWithAndWithoutDefault;
        public int numberOfDefault;
        private DateTime dateTimePoductionStart;
        private string boxName;

        //enum declaration
        public enum ProductionState { stoped = 0, started = 1, finished = 2 }
        private ProductionState productionState;

        //event declaration
        public delegate void WoodProductionEventDelagateWithArgs(WoodBoxProduction sender, ProductionState state);
        public delegate void WoodProductionEventDelagateWithoutArgs(WoodBoxProduction sender);
        public event WoodProductionEventDelagateWithArgs WoodBoxProductiontStateChanged;
        public event WoodProductionEventDelagateWithoutArgs WoodBoxNumberOfBoxProductedChanged;

        //thread declaration
        private Thread threadProduction;

        public WoodBoxProduction(int numberOfBoxToProduce, int productionRate, string boxName)
        {
            if (numberOfBoxToProduce > 0)
            {
                this.numberOfBoxToProduce = numberOfBoxToProduce;
            }
            else
            {
                this.numberOfBoxToProduce = 0;
            }
            if (productionRate > 0)
            {
                this.productionRate = productionRate;
            }
            else
            {
                this.numberOfBoxToProduce = 0;
            }
            this.totalNumberOfBoxWithAndWithoutDefault = 0;
            this.productionState = new ProductionState();
            this.productionState = ProductionState.stoped;
            this.boxName = boxName;
            this.threadProduction = new Thread(new ThreadStart(this.ProduceBoxes));

        }

        /// <summary>
        /// when the object is destroyed we check if the thread is running and kill him if yes
        /// </summary>
        ~WoodBoxProduction()
        {
            if (this.threadProduction.IsAlive)
            {
                this.threadProduction.Abort();
            }
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
            get => boxName;
            //set => currentBoxProduction = value;
        }


        /// <summary>
        ///produce a wood box
        /// </summary>
        private void ProduceBoxes()
        {
            Random rand = new Random(0);
            int numberOfBoxProductedInSession = 0;
            int productionDefault = 0;
            while (this.productionState != ProductionState.finished)
            {
                if (this.productionState != ProductionState.stoped)
                {
                    numberOfBoxProductedInSession++;
                    this.totalNumberOfBoxWithAndWithoutDefault++;
                    productionDefault = (int)Math.Round((double)rand.Next(0, 10) / 10);
                    if (productionDefault == 1)
                    {
                        this.numberOfDefault++;
                    }
                    if (WoodBoxNumberOfBoxProductedChanged != null)
                    {
                        WoodBoxNumberOfBoxProductedChanged(this);
                    }
                    if (numberOfBoxProductedInSession == this.numberOfBoxToProduce)
                    {
                        this.productionState = ProductionState.finished;
                        if (this.WoodBoxProductiontStateChanged != null)
                        {
                            WoodBoxProductiontStateChanged(this, this.productionState);
                        }
                    }
                    Thread.Sleep(productionRate);
                }
            }
        }

        /// <summary>
        /// start the production by the user
        /// </summary>
        /// <returns></returns>
        public bool StartProduction()
        {
            if (this.productionState == ProductionState.started)
            {
                return false;
            }
            if (!this.threadProduction.IsAlive)
            {
                this.DateTimePoductionStart = DateTime.Now;
                this.threadProduction.Start();
            }
            this.productionState = ProductionState.started;
            if(this.WoodBoxProductiontStateChanged != null)
            {
                this.WoodBoxProductiontStateChanged(this, productionState);
            }
            return true;
        }

        /// <summary>
        /// pause production by users
        /// </summary>
        public bool BreakProduction()
        {
            if (this.productionState == ProductionState.stoped)
            {
                return false;
            }
            this.productionState = ProductionState.stoped;
            if (this.WoodBoxProductiontStateChanged != null)
            {
                this.WoodBoxProductiontStateChanged(this, productionState);
            }
            return true;
        }

        /// <summary>
        /// restart production by users
        /// </summary>
        public bool ResumeProduction()
        {
            if (this.productionState != ProductionState.stoped)
            {
                return false;
            }
            this.productionState = ProductionState.started;
            if (this.WoodBoxProductiontStateChanged != null)
            {
                this.WoodBoxProductiontStateChanged(this, productionState);
            }
            return true;
        }

        public bool CancelProduction()
        {
            if(this.productionState != ProductionState.finished)
            {
                this.productionState = ProductionState.finished;
                return true;
            }
            return false;
        }

        public float CalculateRateDefaultPerHour()

        {
            System.TimeSpan numberOfHour;
            numberOfHour = this.dateTimePoductionStart - DateTime.Now;
            if (this.TotalNumberOfBoxWithAndWithoutDefault != 0 && numberOfHour.Hours != 0 && this.numberOfDefault != 0)
            {
                return ((this.numberOfDefault / numberOfHour.Hours) * 100) / (this.totalNumberOfBoxWithAndWithoutDefault / 60);
            }
            else
            {
                return 0;
            }

        }


        public float CalculateTotalDefaultRate()
        {
            return (this.numberOfDefault * 100) / this.totalNumberOfBoxWithAndWithoutDefault;
        }

        public int CalculateNumberOfGoodBox()
        {
            return this.totalNumberOfBoxWithAndWithoutDefault - this.numberOfDefault;
        }

        public int CalculatePercentageOfProductionBox()
        {
            return (this.totalNumberOfBoxWithAndWithoutDefault * 100) / this.NumberOfBoxToProduce;
        }
    }
}
