using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;


namespace MaterialSkin.Controls
{
    public class MaterialGridView : DataGridView, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        private ColorType _colorStyle = ColorType.DEFAULT;
        public ColorType ColorStyle { get => _colorStyle; set => _colorStyle = value; }

        public MaterialGridView()
        {
            SetGridProperties();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetGridColors();
            BackColorChanged += (sender, e) => { SetGridColors(); };
        }

        private int _paddingAll = 10;
        private void SetGridProperties()
        {
            this.Font = SkinManager.ROBOTO_REGULAR_11;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.EnableHeadersVisualStyles = false;
            this.AutoGenerateColumns = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;

            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.RowHeadersVisible = false;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersDefaultCellStyle.Padding = new Padding(_paddingAll);
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.DefaultCellStyle.Padding = new Padding(_paddingAll, _paddingAll / 2, _paddingAll, _paddingAll / 2);
        }

        public void SetGridColors()
        {
            var headerColor = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.DarkPrimaryColor : ColorScheme.ColorSwatches[_colorStyle].DarkPrimaryColor;
            var selectionColor = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.LightPrimaryColor : ColorScheme.ColorSwatches[_colorStyle].LightPrimaryColor;
            var headerTextColor = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.TextColor : ColorScheme.ColorSwatches[_colorStyle].TextColor;

            this.ForeColor = SkinManager.GetPrimaryTextColor();
            this.BackgroundColor = this.BackColor;
            this.GridColor = this.BackColor;
            this.DefaultCellStyle.BackColor = this.BackColor;

            this.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            this.ColumnHeadersDefaultCellStyle.ForeColor = headerTextColor;

            this.RowHeadersDefaultCellStyle.BackColor = headerColor;
            this.RowHeadersDefaultCellStyle.ForeColor = headerTextColor;

            this.DefaultCellStyle.SelectionBackColor = selectionColor;
            this.DefaultCellStyle.SelectionForeColor = this.BackColor;

            this.DefaultCellStyle.SelectionBackColor = selectionColor;
            this.DefaultCellStyle.SelectionForeColor = this.BackColor;

            this.RowHeadersDefaultCellStyle.SelectionBackColor = selectionColor;
            this.RowHeadersDefaultCellStyle.SelectionForeColor = this.BackColor;

            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = selectionColor;
            this.ColumnHeadersDefaultCellStyle.SelectionForeColor = this.BackColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            //var lineBrush = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.DarkPrimaryBrush : ColorScheme.ColorSwatches[_colorStyle].DarkPrimaryBrush;
            //var g = pevent.Graphics;
            //int lineWeight = 2;
            //int pad = lineWeight;
            //var lineY1 = 0;
            //var lineY2 = Height - lineY1 - pad;

            //var lineX1 = 0;
            //var lineX2 = Width - lineX1;

            ////No animation
            ////top
            //g.FillRectangle(lineBrush, lineX1, lineY1, lineX2, lineWeight);

            ////bottom
            //g.FillRectangle(lineBrush, lineX1, lineY2, lineX2, lineWeight);

            ////left
            //g.FillRectangle(lineBrush, lineX1, lineY1 + lineWeight, lineWeight, lineY2 - lineWeight);

            ////right
            //g.FillRectangle(lineBrush, lineX2 - lineWeight, lineY1 + lineWeight, lineWeight, lineY2 - lineWeight);
        }
    }


}
