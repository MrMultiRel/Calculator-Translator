using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project;

namespace TranslatorTests
{
    [TestClass]
    public class Translator
    {
        [TestMethod]
        public void Translate_15_Десятичной_Двоичную_Returned1111()
        {
            Number number = new Number("15", "Десятичной");

            string arg1 = "Двоичную";
            string expected = "1111";

            string result = number.Translate(arg1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Некорректный ввод")]
        public void Translate_12F_Восьмеричной_Десятичную_ArgumentException()
        {
            Number number = new Number("12F", "Восьмеричной");

            string arg1 = "Десятичную";

            string result = number.Translate(arg1);
        }
    }
}
