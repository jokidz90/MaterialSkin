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
    public partial class MaterialMessageBoxIntegerForm : MaterialFormDialog
    {
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        public int Value
        {
            get
            {
                int val = txtNumber.Text.GetInt32Value();

                return val;
            }
        }

        private bool _allowNegativeNumber = true;

        public MaterialMessageBoxIntegerForm(string caption, int initialValue, bool allowNegativeNumber)
        {
            InitializeComponent();
            this.Text = caption;
            _allowNegativeNumber = allowNegativeNumber;
            btnSign.Visible = _allowNegativeNumber;
            if (!_allowNegativeNumber)
            {
                this.tblMain.SetColumn(this.btn0, 0);
                this.tblMain.SetColumnSpan(this.btn0, 3);
            }
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
            btnOK.ColorStyle = SkinManager.ColorStyle;
            btnCancel.ColorStyle = SkinManager.ColorStyle;
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
            txtNumber.Text = "0";
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
    }
}
