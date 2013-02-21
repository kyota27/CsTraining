using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Training1
{
    public partial class Form1 : Form
    {
        #region ctor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region event
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void OnTextKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsNumeric(e.KeyChar.ToString()))
                e.Handled = true;
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Calc().ToString());
        }
        #endregion

        #region private method
        private void InitializeForm()
        {
            var operators = OperatorHelper.GetAllOperators();
            foreach (Operators o in operators)
            {
                var sign = o.ToSign();
                if (string.IsNullOrEmpty(sign)) continue;
                this.OperatorComboBox.Items.Add(o.ToSign());
            }
            this.OperatorComboBox.SelectedIndex = 0;
        }
        
        private bool IsNumeric(string value)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                return false;

            var regex = new Regex("^[0-9]+$");
            return regex.IsMatch(value.ToString());
        }

        private int Calc()
        {
            var operators = OperatorHelper.SignToOperators(this.OperatorComboBox.SelectedItem);
            var result = OperatorHelper.Calcuration(operators, this.LeftText.ToInt(), this.RightText.ToInt());
            return result;
        }
        #endregion
    }
}
