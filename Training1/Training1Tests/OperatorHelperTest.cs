using Training1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Training1Tests
{
    [TestClass()]
    public class OperatorHelperTest
    {
        /// <summary>
        ///Calcuration のテスト
        ///</summary>
        [TestMethod()]
        public void CalcurationTest()
        {
            Assert.AreEqual(10, OperatorHelper.Calcuration(Operators.Plus, 5, 5));
            Assert.AreEqual(0, OperatorHelper.Calcuration(Operators.Minus, 5, 5));
            Assert.AreEqual(25, OperatorHelper.Calcuration(Operators.Multiply, 5, 5));
            Assert.AreEqual(1, OperatorHelper.Calcuration(Operators.Divide, 5, 5));

            bool isDivideZero = false;
            try
            {
                OperatorHelper.Calcuration(Operators.Divide, 5, 0);
            }
            catch (DivideByZeroException)
            {
                isDivideZero = true;
            }
            finally
            {
                Assert.IsTrue(isDivideZero);
            }
        }

        /// <summary>
        ///GetAllOperators のテスト
        ///</summary>
        [TestMethod()]
        public void GetAllOperatorsTest()
        {
            Array actual = OperatorHelper.GetAllOperators();
            Assert.AreEqual(5, actual.Length);
        }

        /// <summary>
        ///SignToOperators のテスト
        ///</summary>
        [TestMethod()]
        public void SignToOperatorsTest()
        {
            Assert.AreEqual(Operators.Plus, OperatorHelper.SignToOperators("＋"));
            Assert.AreEqual(Operators.Minus, OperatorHelper.SignToOperators("－"));
            Assert.AreEqual(Operators.Multiply, OperatorHelper.SignToOperators("×"));
            Assert.AreEqual(Operators.Divide, OperatorHelper.SignToOperators("÷"));
            Assert.AreEqual(Operators.None, OperatorHelper.SignToOperators(""));
            Assert.AreEqual(Operators.None, OperatorHelper.SignToOperators("+"));
            Assert.AreEqual(Operators.None, OperatorHelper.SignToOperators(null));
        }
    }
}
