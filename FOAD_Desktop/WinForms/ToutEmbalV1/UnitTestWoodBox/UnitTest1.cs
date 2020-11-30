using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryToutEmbal;

namespace UnitTestWoodBox
{
    [TestClass]
    public class UnitTestWoodBox
    {
        private bool isWoodBoxProductiontStateChanged;
        private bool isWoodBoxNumberOfBoxProductedChanged;

        public UnitTestWoodBox()
        {
            this.isWoodBoxProductiontStateChanged = false;
            this.isWoodBoxNumberOfBoxProductedChanged = false;
        }

        private void WoodBoxProductionterminated1(object sender)
        {
            this.isWoodBoxProductiontStateChanged = true;
        }

        private void WoodBoxProductionNewDefault1(object sender)
        {
            this.isWoodBoxNumberOfBoxProductedChanged = true;
        }

        [TestMethod]
        public void TestConstructor()
        {
            WoodBoxProduction woodBox = new WoodBoxProduction(10500, "A");
            Assert.AreEqual(10500, woodBox.NumberOfBoxToProduce);
            Assert.AreEqual("A", woodBox.BoxName);
        }

        [TestMethod]
        public void TestProduceBox()
        {
            WoodBoxProduction woodBox2 = new WoodBoxProduction(20, "A");
            woodBox2.WoodBoxProductiontStateChanged += WoodBoxProductionterminated1;
            woodBox2.WoodBoxNumberOfBoxProductedChanged += WoodBoxProductionNewDefault1;

            for (int i = 0;  i < 20; i++)
            {
                woodBox2.ProduceBox();
            }

            Assert.AreEqual(20, woodBox2.TotalNumberOfBoxWithAndWithoutDefault);
            Assert.AreEqual(true, this.isWoodBoxProductiontStateChanged);
            //Assert.AreEqual(true, this.isWoodBoxProductionNewDefault);
        }
    }
}
