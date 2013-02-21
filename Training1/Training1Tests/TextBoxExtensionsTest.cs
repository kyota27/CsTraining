using Training1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace Training1Tests
{
    [TestClass()]
    public class TextBoxExtensionsTest
    {
        /// <summary>
        ///ToInt のテスト
        ///</summary>
        [TestMethod()]
        public void ToIntTest()
        {
            TextBox textBox = new TextBox();
            textBox.Text = "100";
            Assert.AreEqual(100, TextBoxExtensions.ToInt(textBox));

            textBox.Text = int.MaxValue.ToString();
            Assert.AreEqual(int.MaxValue, TextBoxExtensions.ToInt(textBox));

            textBox.Text = "0";
            Assert.AreEqual(0, TextBoxExtensions.ToInt(textBox));

            textBox.Text = "";
            Assert.AreEqual(0, TextBoxExtensions.ToInt(textBox));

            bool isOverflow = false;
            try
            {
                textBox.Text = ((double)int.MaxValue + 1d).ToString();
                TextBoxExtensions.ToInt(textBox);
            }
            catch (Exception)
            {
                isOverflow = true;
            }
            finally
            {
                Assert.IsTrue(isOverflow);
            }
        }
    }
}
