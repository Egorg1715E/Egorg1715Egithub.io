using MathTaskClassLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            //Исходные данные
            int a = 3;
            int b = 5;
            int expected = 15;

            //Полученные значения с помощью тестируемого
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);

            //Сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
