using Training1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Training1Tests
{
    [TestClass()]
    public class Form1Test
    {
        /// <summary>
        ///InitializeForm のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Training1.exe")]
        public void InitializeFormTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 適切な値に初期化してください
            target.InitializeForm();
            Assert.AreEqual(4, target.OperatorComboBox.Items.Count);
        }

        /// <summary>
        ///IsNumeric のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Training1.exe")]
        public void IsNumericTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 適切な値に初期化してください
            Assert.AreEqual(true, target.IsNumeric("1"));
            Assert.AreEqual(true, target.IsNumeric("9"));
            Assert.AreEqual(false, target.IsNumeric("-"));
            Assert.AreEqual(false, target.IsNumeric("."));
            Assert.AreEqual(false, target.IsNumeric("a"));
            Assert.AreEqual(false, target.IsNumeric("あ"));
        }

        /// <summary>
        ///Calc のテスト
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Training1.exe")]
        public void CalcTest()
        {
            Form1_Accessor target = new Form1_Accessor(); // TODO: 適切な値に初期化してください
            target.InitializeForm();
            target.LeftText.Text = "10";
            target.RightText.Text = "10";

            target.OperatorComboBox.SelectedItem = Operators.Plus.ToSign();
            Assert.AreEqual(20, target.Calc());

            target.OperatorComboBox.SelectedItem = Operators.Minus.ToSign();
            Assert.AreEqual(0, target.Calc());

            target.OperatorComboBox.SelectedItem = Operators.Multiply.ToSign();
            Assert.AreEqual(100, target.Calc());

            target.OperatorComboBox.SelectedItem = Operators.Divide.ToSign();
            Assert.AreEqual(1, target.Calc());
        }
    }
}
