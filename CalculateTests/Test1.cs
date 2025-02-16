

using ConsoleCaculate;

namespace CalculateTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test_Sum_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetSumm(-0.5, 1.5);
            double equel = 1;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Multiply_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetMultiply(1.2, 1.2);
            double equel = 1.44;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Difference_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetDifference(1.5, -0.5);
            double equel = 2;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Divide_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetDivide(1.5, -0.5);
            double equel = -3;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Degree_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetDegree(1.5, 2);
            double equel = 2.25;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Root_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetRoot(1.44, 2);
            double equel = 1.2;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Procent_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetProcent(100, 2.25);
            double equel = 2.25;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Log_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetLog(Math.Exp(1), null);
            double equel = 1;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Sin_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetSin(Math.PI / 2);
            double equel = 1;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Ctan_RealNumbers()
        {
            Calculator calc = new Calculator();

            double assets = calc.GetCtan(Math.PI / 4);
            double equel = 1;

            Assert.AreEqual(assets, equel);
        }

        [TestMethod]
        public void Test_Divide_RealNumbers_DevideByZero()
        {
            Calculator calc = new Calculator();
            bool isException = false;

            try
            {
                double assets = calc.GetDivide(1.5, 0);

            }
            catch (Exception ex)
            {
                isException = true;
            }

            Assert.IsTrue(isException);
        }

        [TestMethod]
        public void Test_Divide_RealNumbers_DegreeException()
        {
            Calculator calc = new Calculator();
            bool isException = false;

            try
            {
                double assets = calc.GetDegree(1, 0.5);
            }
            catch (Exception ex)
            {
                isException = true;
            }

            Assert.IsTrue(isException);
        }

        [TestMethod]
        public void Test_Root_RealNumbers_RootOfZero()
        {
            Calculator calc = new Calculator();

            bool isException = false;

            try
            {
                double assets = calc.GetRoot(2, 0);
            }
            catch (Exception ex)
            {
                isException = true;
            }

            Assert.IsTrue(isException);
        }

        [TestMethod]
        public void Test_Log_RealNumbers_LogOfBaseOne()
        {
            Calculator calc = new Calculator();

            bool isException = false;

            try
            {
                double assets = calc.GetLog(5,1);
            }
            catch (Exception ex)
            {
                isException = true;
            }

            Assert.IsTrue(isException);
        }
    }
}
