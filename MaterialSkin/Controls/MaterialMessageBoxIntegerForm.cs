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
