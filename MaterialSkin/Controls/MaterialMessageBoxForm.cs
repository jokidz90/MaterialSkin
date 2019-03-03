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
    public partial class MaterialMessageBoxForm : MaterialFormDialog
    {
        private ControlSize _controlSize = ControlSize.NORMAL;
        private MessageBoxButtons _buttons = MessageBoxButtons.OK;

        public MaterialMessageBoxForm(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, ControlSize size)
        {
            InitializeComponent();

            _buttons = buttons;
            _controlSize = size;
            this.Text = caption;
            lblMessage.Text = text;

            pnlAbort.Visible = false;
            pnlCancel.Visible = false;
            pnlIgnore.Visible = false;
            pnlNo.Visible = false;
            pnlOk.Visible = false;
            pnlRetry.Visible = false;
            pnlYes.Visible = false;

            if (buttons == MessageBoxButtons.AbortRetryIgnore)
            {
                pnlAbort.Visible = true;
                pnlRetry.Visible = true;
                pnlIgnore.Visible = true;
            }
            else if (buttons == MessageBoxButtons.OK)
            {
                pnlOk.Visible = true;
            }
            else if (buttons == MessageBoxButtons.OKCancel)
            {
                pnlCancel.Visible = true;
                pnlOk.Visible = true;
            }
            else if (buttons == MessageBoxButtons.RetryCancel)
            {
                pnlCancel.Visible = true;
                pnlRetry.Visible = true;
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                pnlYes.Visible = true;
                pnlNo.Visible = true;
            }
            else if (buttons == MessageBoxButtons.YesNoCancel)
            {
                pnlYes.Visible = true;
                pnlNo.Visible = true;
                pnlCancel.Visible = true;
            }

            if (icon == MessageBoxIcon.Error)
            {
                this.ColorStyle = ColorType.DANGER;
                this.IconType = IconType.ERROR;
            }
            else if (icon == MessageBoxIcon.Information)
            {
                this.ColorStyle = ColorType.INFO;
                this.IconType = IconType.INFO;
            }
            else if (icon == MessageBoxIcon.Warning)
            {
                this.ColorStyle = ColorType.WARNING;
                this.IconType = IconType.WARNING;
            }
            else
            {
                this.ColorStyle = ColorType.DEFAULT;
                this.IconType = IconType.INFO_OUTLINE;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string tagStr = ((Control)sender).Tag + "";
            var dlgResult = DialogResult.None;
            Enum.TryParse(tagStr, out dlgResult);
            this.DialogResult = dlgResult;
            this.Close();
        }

        private void MaterialMessageBoxForm_Load(object sender, EventArgs e)
        {
            int width = pnlAbort.Width +
                        pnlCancel.Width +
                        pnlIgnore.Width +
                        pnlNo.Width +
                        pnlOk.Width +
                        pnlYes.Width +
                        pnlRetry.Width;
            width = Convert.ToInt32(Math.Round(width / 7m));

            if (_controlSize == ControlSize.LARGE)
                width = (width * 3) + width;
            else if (_controlSize == ControlSize.SMALL)
                width = (width * 3) + 10;
            else
                width = (width * 3) + (width / 2);
            this.Width = width;
            this.Height = Convert.ToInt32(Math.Round(width / 2m));
        }
    }

    public class MaterialMessageBox
    {
        public static DialogResult Show(string text)
        {
            MaterialMessageBoxForm frm = new MaterialMessageBoxForm(text, "", MessageBoxButtons.OK, MessageBoxIcon.Information, ControlSize.NORMAL);
            return frm.ShowFormDialog();
        }

        public static DialogResult Show(string text, string caption)
        {
            MaterialMessageBoxForm frm = new MaterialMessageBoxForm(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, ControlSize.NORMAL);
            return frm.ShowFormDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxIcon icon)
        {
            MaterialMessageBoxForm frm = new MaterialMessageBoxForm(text, caption, MessageBoxButtons.OK, icon, ControlSize.NORMAL);
            return frm.ShowFormDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            MaterialMessageBoxForm frm = new MaterialMessageBoxForm(text, caption, buttons, MessageBoxIcon.Information, ControlSize.NORMAL);
            return frm.ShowFormDialog();
        }

        public static DialogResult Show(string text, string caption, ControlSize size)
        {
            MaterialMessageBoxForm frm = new MaterialMessageBoxForm(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, size);
            return frm.ShowFormDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MaterialMessageBoxForm frm = new MaterialMessageBoxForm(text, caption, buttons, icon, ControlSize.NORMAL);
            return frm.ShowFormDialog();
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, ControlSize size)
        {
            MaterialMessageBoxForm frm = new MaterialMessageBoxForm(text, caption, buttons, icon, size);
            return frm.ShowFormDialog();
        }
    }
}
