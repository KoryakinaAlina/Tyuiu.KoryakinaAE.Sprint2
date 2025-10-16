using Tyuiu.KoryakinaAE.Sprint2.Task4.V18.Lib;

namespace Tyuiu.Koryakina.AE.Sprint2.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1, 0);
            Assert.AreEqual(0, res); 
             
        } 
    }
}
