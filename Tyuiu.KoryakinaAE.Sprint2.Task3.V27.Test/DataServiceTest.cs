using Tyuiu.KoryakinaAE.Sprint2.Task3.V27.Lib;

namespace Tyuiu.KoryakinaAE.Sprint2.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-10);
            Assert.AreEqual(1.020, res);
        }
    }
}
