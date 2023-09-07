using _7._5Uzduotis_Methods_unitTesting;

namespace Test7._5Methods

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCylinder()
        {
            double radius = 5;
            double height = 2;

            double expected = 157;

            double actual = Program.CalculateCylinderVolume(radius, height);
            Assert.AreEqual(expected, actual);
        }
    }
}