using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StorebaeltLibrary;

namespace UnitTestwkndRabat
{
    [TestClass]
    public class BilTests
    {
        /// <summary>
        /// Denne test fratrækker 20% Weekend rabat og 5% Brobizz rabat.
        /// Regnestykket:
        /// 240 - 0.20 * 240
        /// 192 - 0.05 * 192
        /// == 182.4
        /// </summary>
        [TestMethod]
        public void BilRabatWeekendBrobizz()
        {
            //Assign
            Bil bilOne = new Bil("GH123KL", new DateTime(2018, 09, 22), true);

            //Act
            WeekendRabat.weekendRabat(bilOne);
           

            //Assert
            Assert.AreEqual(new decimal(182.4), bilOne.Pris);
        }

        /// <summary>
        /// Denne test fratrækker kun 20% weekend rabat.
        /// </summary>
        [TestMethod]
        public void BilRabatWeekend()
        {
            //Assign
            Bil bilOne = new Bil("GH123KL", new DateTime(2018, 09, 22), false);

            //Act
            WeekendRabat.weekendRabat(bilOne);


            //Assert
            Assert.AreEqual(new decimal(192), bilOne.Pris);
        }

        /// <summary>
        /// Denne test ser om der bliver trukket weekend rabat fra MC'er. Hvilket den ikke skal, da det kun er biler den skal gives til. Der skal dog trækkes 5%
        /// BroBizz rabat af.
        /// Regstykke:
        /// 125 - 0.05 * 125
        /// == 118.75
        /// </summary>
        [TestMethod]
        public void MCRabatWeekendBroBizz()
        {
            //Assign
            MC MCOne = new MC("GH123KL", new DateTime(2018, 09, 22), true);

            //Act
            WeekendRabat.weekendRabat(MCOne);


            //Assert
            Assert.AreEqual(new decimal(118.75), MCOne.Pris);
        }

        /// <summary>
        /// Denne test ser om der bliver trukket weekend rabat fra MC'er. Hvilket den ikke skal, da det kun er biler den skal gives til. Uden Brobizz.
        /// </summary>
        [TestMethod]
        public void MCRabatWeekendBro()
        {
            //Assign
            MC MCOne = new MC("GH123KL", new DateTime(2018, 09, 22), false);

            //Act
            WeekendRabat.weekendRabat(MCOne);


            //Assert
            Assert.AreEqual(new decimal(125), MCOne.Pris);
        }
    }
}
