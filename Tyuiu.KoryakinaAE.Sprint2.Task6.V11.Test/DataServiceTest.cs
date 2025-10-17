using Tyuiu.KoryakinaAE.Sprint2.Task6.V11.Lib;

namespace Tyuiu.KoryakinaAE.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 10;
            int m = 1;
            int g = 2007;
            string wait = "11.01.2007";
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(res, wait);
        }
    }
    
}
