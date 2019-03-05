using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class MaterialMessageBoxNumericForm : MaterialFormDialog
    {
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        public decimal Value
        {
            get
            {
                decimal val = txtNumber.Text.GetDecimalValue();

                return val;
            }
        }
        private bool _allowNegativeNumber = true;
        private bool _isCalculationMode = false;
        private decimal _prevValue = 0;
        private string _calculationMode = "";
        public string CalculationMode
        {
            set
            {
                _calculationMode = value;
                _isCalculationMode = !string.IsNullOrEmpty(_calculationMode);
                btnAdd.UseFlatStyle = !_isCalculationMode || _calculationMode != btnAdd.Tag.ToString() ;
                btnSubtract.UseFlatStyle = !_isCalculationMode || _calculationMode != btnSubtract.Tag.ToString();
                btnMultiply.UseFlatStyle = !_isCalculationMode || _calculationMode != btnMultiply.Tag.ToString();
                btnDiv.UseFlatStyle = !_isCalculationMode || _calculationMode != btnDiv.Tag.ToString();
            }
            get
            {
                return _calculationMode;
            }
        }

        public MaterialMessageBoxNumericForm(string caption, decimal initialValue, int precision, bool allowNegativeNumber)
        {
            InitializeComponent();
            this.Text = caption;
            //_precision = precision;
            _allowNegativeNumber = allowNegativeNumber;
            btnSign.Visible = _allowNegativeNumber;
            if (!_allowNegativeNumber)
                this.tblMain.SetColumnSpan(this.btn0, 2);
            txtNumber.Hint = caption;
            txtNumber.Text = initialValue.ToString();
            if (initialValue == 0)
                txtNumber.Text = "0";
            btn0.ColorStyle = SkinManager.ColorStyle;
            btn0.BorderColorType = SkinManager.ColorStyle;
            btn1.ColorStyle = SkinManager.ColorStyle;
            btn1.BorderColorType = SkinManager.ColorStyle;
            btn2.ColorStyle = SkinManager.ColorStyle;
            btn2.BorderColorType = SkinManager.ColorStyle;
            btn3.ColorStyle = SkinManager.ColorStyle;
            btn3.BorderColorType = SkinManager.ColorStyle;
            btn4.ColorStyle = SkinManager.ColorStyle;
            btn4.BorderColorType = SkinManager.ColorStyle;
            btn5.ColorStyle = SkinManager.ColorStyle;
            btn5.BorderColorType = SkinManager.ColorStyle;
            btn6.ColorStyle = SkinManager.ColorStyle;
            btn6.BorderColorType = SkinManager.ColorStyle;
            btn7.ColorStyle = SkinManager.ColorStyle;
            btn7.BorderColorType = SkinManager.ColorStyle;
            btn8.ColorStyle = SkinManager.ColorStyle;
            btn8.BorderColorType = SkinManager.ColorStyle;
            btn9.ColorStyle = SkinManager.ColorStyle;
            btn9.BorderColorType = SkinManager.ColorStyle;
            btnBackspace.ColorStyle = SkinManager.ColorStyle;
            btnBackspace.BorderColorType = SkinManager.ColorStyle;
            btnSign.ColorStyle = SkinManager.ColorStyle;
            btnSign.BorderColorType = SkinManager.ColorStyle;
            btnDiv.ColorStyle = SkinManager.ColorStyle;
            btnDiv.BorderColorType = SkinManager.ColorStyle;
            btnMultiply.ColorStyle = SkinManager.ColorStyle;
            btnMultiply.BorderColorType = SkinManager.ColorStyle;
            btnSubtract.ColorStyle = SkinManager.ColorStyle;
            btnSubtract.BorderColorType = SkinManager.ColorStyle;
            btnAdd.ColorStyle = SkinManager.ColorStyle;
            btnAdd.BorderColorType = SkinManager.ColorStyle;
            btnEqual.ColorStyle = SkinManager.ColorStyle;
            btnEqual.BorderColorType = SkinManager.ColorStyle;
            btnDot.ColorStyle = SkinManager.ColorStyle;
            btnDot.BorderColorType = SkinManager.ColorStyle;
        }

        private void btnOKCANCEL_Click(object sender, EventArgs e)
        {
            string tagStr = ((Control)sender).Tag + "";
            var dlgResult = DialogResult.None;
            Enum.TryParse(tagStr, out dlgResult);
            this.DialogResult = dlgResult;
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string currentVal = txtNumber.Text + ((Control)sender).Tag + "";
            txtNumber.Text = currentVal.GetDecimalValue().ToString();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string currentVal = txtNumber.Text;
            txtNumber.Text = (-1 * currentVal.GetDecimalValue()).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _isCalculationMode = false;
            txtNumber.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Contains("."))
                return;
            if (txtNumber.Text.Length == 0)
                return;
            txtNumber.Text = txtNumber.Text + ".";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length == 0)
                return;
            if (txtNumber.Text.Length == 1)
            {
                txtNumber.Text = "0";
                return;
            }

            txtNumber.Text = txtNumber.Text.Substring(0, txtNumber.Text.Length - 1);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalculationMode = ((Control)sender).Tag + "";
            _prevValue = txtNumber.Text.GetDecimalValue();
            txtNumber.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (_calculationMode == "ADD")
                    txtNumber.Text = (_prevValue + txtNumber.Text.GetDecimalValue()).ToString();
                else if (_calculationMode == "SUBTRACT")
                    txtNumber.Text = (_prevValue - txtNumber.Text.GetDecimalValue()).ToString();
                else if (_calculationMode == "MULTIPLY")
                    txtNumber.Text = (_prevValue * txtNumber.Text.GetDecimalValue()).ToString();
                else if (_calculationMode == "DIV")
                    txtNumber.Text = (_prevValue / txtNumber.Text.GetDecimalValue()).ToString();
                CalculationMode = "";
                _prevValue = 0;
            }
            catch (Exception ex)
            {
                txtNumber.Text = "0";
            }
        }
    }
}
