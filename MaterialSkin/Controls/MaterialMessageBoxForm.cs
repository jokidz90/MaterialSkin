﻿using System;
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
            return Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.None, ControlSize.NORMAL);
        }

        public static DialogResult Show(string text, string caption)
        {
            return Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, ControlSize.NORMAL);
        }

        public static DialogResult Show(string text, string caption, MessageBoxIcon icon)
        {
            return Show(text, caption, MessageBoxButtons.OK, icon, ControlSize.NORMAL);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return Show(text, caption, buttons, MessageBoxIcon.None, ControlSize.NORMAL);
        }

        public static DialogResult Show(string text, string caption, ControlSize size)
        {
            return Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.None, size);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return Show(text, caption, buttons, icon, ControlSize.NORMAL);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, ControlSize size)
        {
            MaterialMessageBoxForm frm = new MaterialMessageBoxForm(text, caption, buttons, icon, size);
            return frm.ShowFormDialog();
        }

        public static DialogResult ShowSelector(string caption, List<object> items, out object selectedValue)
        {
            return ShowSelector(caption, items, "", "", false, false, ControlSize.NORMAL, false, out selectedValue);
        }

        public static DialogResult ShowSelector(string caption, List<object> items, ControlSize itemSize, out object selectedValue)
        {
            return ShowSelector(caption, items, "", "", false, false, itemSize, false, out selectedValue);
        }

        public static DialogResult ShowSelector(string caption, List<object> items, string valueMember, string displayMember, out object selectedValue)
        {
            return ShowSelector(caption, items, valueMember, displayMember, false, false, ControlSize.NORMAL, false, out selectedValue);
        }

        public static DialogResult ShowSelector(string caption, List<object> items, string valueMember, string displayMember, bool isMultiSelect, bool hideEmptyValue, ControlSize itemSize, bool useFlatStyle, out object selectedValue)
        {
            selectedValue = null;
            var frm = new MaterialSelectableButtonForm();
            frm.HideEmptyValue = hideEmptyValue;
            frm.Caption = caption;
            frm.ItemSize = itemSize;
            frm.ValueMember = valueMember;
            frm.DisplayMember = displayMember;
            frm.Items = items;
            frm.IsMultiSelect = isMultiSelect;
            frm.UseFlatStyle = useFlatStyle;
            frm.Size = MaterialSelectableButton.CalculatePopUpSize(itemSize, items.Count, isMultiSelect, hideEmptyValue, string.IsNullOrWhiteSpace(caption), out int itemHeight, out int itemWidth);
            frm.ItemHeight = itemHeight;
            frm.ItemWidth = itemWidth;
            var res = frm.ShowFormDialog();
            if (res == DialogResult.OK)
            {
                var selIndices = frm.SelectedIndices;

                List<object> selecteds = new List<object>();
                for (int i = 0; i < items.Count; i++)
                {
                    if (!selIndices.Contains(i))
                        continue;

                    selecteds.Add(items[i].GetProperty(valueMember));
                }

                selectedValue = selecteds;
                if (!isMultiSelect)
                    selectedValue = selecteds.FirstOrDefault();
            }
            return res;
        }
    }
}
