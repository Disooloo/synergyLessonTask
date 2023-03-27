using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace yearUnitTest
{

    // Атрибут TestClass указывает, что этот класс содержит юнит-тесты.
    [TestClass]
    public class UnitTest1
    {
        // Атрибут TestMethod указывает, что это метод является тестом.
        [TestMethod]
        public void TestMethod1()
        {
            // Этот тест проверяет, что метод GetCounterYear() класса Year возвращает текущий год.
            Assert.AreEqual(DateTime.Now.Year, synergyLessonTask.Task2.Year.GetCounterYear());
        }
    }
}
