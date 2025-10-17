using Tyuiu.KoryakinaAE.Sprint2.Task5.V5.Lib;

namespace Tyuiu.KoryakinaAE.Sprint2.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 11;
            string wait = "валет";
            string res = ds.FindCardValue(value);
            Assert.AreEqual(wait, res);

        }
    }
}
