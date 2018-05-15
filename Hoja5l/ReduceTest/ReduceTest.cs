using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reduce;
using System.Linq;

namespace ReduceTest
{
    [TestClass]
    public class ReduceTest
    {
        [TestMethod]
        public void ReduceIntTest()
        {
            
            int[] valores = new int[] { 4, 6, 7 };
            int reduce = Program.ReduceInt(valores, 0, (acc, valor) => acc + valor);

            Assert.AreEqual(reduce, 17);
        }

        [TestMethod]
        public void ReduceGenericTest()
        {
            
            string[] valores = new string[] { "Que", "Tal", "Mi cuate" };
            int reduce = Program.Reduce(valores, 0, (acc, valor) => acc + valor.Where(c => c == 'a').Count());

            Assert.AreEqual(reduce, 5);
        }
    }
}