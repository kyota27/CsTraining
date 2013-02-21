using Training1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Training1Tests
{
    [TestClass()]
    public class OperatorExtensionTest
    {
        /// <summary>
        ///ToSign のテスト
        ///</summary>
        [TestMethod()]
        public void ToSignTest()
        {
            Assert.AreEqual("＋", OperatorExtension.ToSign(Operators.Plus));
            Assert.AreEqual("－", OperatorExtension.ToSign(Operators.Minus));
            Assert.AreEqual("×", OperatorExtension.ToSign(Operators.Multiply));
            Assert.AreEqual("÷", OperatorExtension.ToSign(Operators.Divide));
            Assert.AreEqual("", OperatorExtension.ToSign(Operators.None));
        }
    }
}
