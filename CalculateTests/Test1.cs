

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

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Calculator calc = new Calculator();


        //    Assert.
        //}

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Calculator calc = new Calculator();


        //    Assert.
        //}


        //Деление на 0
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Calculator calc = new Calculator();


        //    Assert.
        //}

        //вызов эксешона при возведении в степень
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Calculator calc = new Calculator();


        //    Assert.
        //}

        //вызов эксешона при получнеии корня числа
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Calculator calc = new Calculator();


        //    Assert.
        //}

        //вызов исключения при попытке получения процента у разных знаков
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Calculator calc = new Calculator();


        //    Assert.
        //}
    }
}
