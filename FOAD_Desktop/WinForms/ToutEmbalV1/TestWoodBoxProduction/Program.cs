using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibraryToutEmbal;

namespace TestWoodBoxProduction
{
    class Program
    {
        static WoodBoxProduction production;

        static void Main(string[] args)

        {
             production = new WoodBoxProduction(5000, 50, "B");
             production.WoodBoxNumberOfBoxProductedChanged += Production_WoodBoxNumberOfBoxProductedChanged;
             production.WoodBoxProductiontStateChanged += Production_WoodBoxProductiontStateChanged;
             production.StartProduction();
             
             Console.ReadLine();
        }

        private static void Production_WoodBoxProductiontStateChanged(WoodBoxProduction sender, WoodBoxProduction.ProductionState state)
        {
            Console.WriteLine("état de la production : " + state);
        }

        private static void Production_WoodBoxNumberOfBoxProductedChanged(WoodBoxProduction sender)
        {
            Console.WriteLine(production.numberOfDefault.ToString());
            Console.WriteLine(production.TotalNumberOfBoxWithAndWithoutDefault.ToString());
        }
    }
}
