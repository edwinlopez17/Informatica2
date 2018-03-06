using System;
using Xunit;


namespace GenericosTest
{
    public class GenericosTest
    {
        [Fact]
        public void HeadTest()
        {
            int[] arreglo = { 1, 2, 3 };
            GenericosTest genericos = new GenericosTest();
            int valor = genericos.Head<int>(arreglo);
            Assert.AreEqual(valor, arreglo[0]);
        }

        [Fact]
        public void TailTest()
        {
            int[] ArregloBase = { 10, 20, 30, 40 };
            GenericosTest genericos = new GenericosTest();
            int[] NuevoArreglo = genericos.Tail<int>(ArregloBase);
            Assert.AreEqual(ArregloBase[0], NuevoArreglo[0]);
        }

        [Fact]
        public void TestZip()
        {
            GenericosTest genericos = new GenericosTest();
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 1, 2, 3, 4 };

            Tupla<int, int>[] arreglo = genericos.Zip<int, int>(a, b);

            for (int i = 0; i < arreglo.Length; i++)
            {
                Assert.AreEqual(a[i], arreglo[i].primero);
                Assert.AreEqual(b[i], arreglo[i].segundo);
            }
        }
    }
}