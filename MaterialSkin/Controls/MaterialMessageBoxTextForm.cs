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
    public partial class MaterialMessageBoxTextForm : MaterialFormDialog
    {
        public string Value
        {
            get
            {
                if(_isMultiline)
                    return txtMultilines.Text;
                else
                    return txtSingleLine.Text;
            }
        }
        private bool _isMultiline = true;

        public MaterialMessageBoxTextForm(string caption, string initialValue, bool isMultiline)
        {
            InitializeComponent();
            _isMultiline = isMultiline;
            this.Text = caption;
            txtSingleLine.Text = initialValue;
            txtMultilines.Text = initialValue;
            txtSingleLine.Visible = !isMultiline;
            txtMultilines.Visible = isMultiline;
            this.Height = isMultiline ? 250 : 150;
        }

        private void btnOKCANCEL_Click(object sender, EventArgs e)
        {
            string tagStr = ((Control)sender).Tag + "";
            var dlgResult = DialogResult.None;
            Enum.TryParse(tagStr, out dlgResult);
            this.DialogResult = dlgResult;
            this.Close();
        }
    }
}
