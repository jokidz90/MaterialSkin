using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class MaterialFormGroup : GroupBox, IMaterialControl
    {
        private ColorType _colorStyle = ColorType.DEFAULT;
        public ColorType ColorStyle { get => _colorStyle; set => _colorStyle = value; }

        public MaterialFormGroup()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Padding = new Padding(3, 6, 3, 3);
            ForeColor = SkinManager.GetSecondaryTextColor();
            Font = SkinManager.ROBOTO_BOLD_10;
            BackColor = SkinManager.GetApplicationBackgroundColor();
            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetSecondaryTextColor();
        }

        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            var backBrush = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.DarkPrimaryBrush : ColorScheme.ColorSwatches[_colorStyle].DarkPrimaryBrush;

            this.BackColor = SkinManager.GetApplicationBackgroundColor();
            base.OnPaint(e);
            GroupBoxRenderer.DrawParentBackground(e.Graphics, this.ClientRectangle, this);
            var rect = ClientRectangle;

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            Brush frontBrush = new SolidBrush(ForeColor);
            if (!Enabled)
                frontBrush = SkinManager.GetDisabledOrHintBrush();
            else if (_isEntered)
                frontBrush = backBrush;

            g.DrawString(Text, Font, frontBrush, rect, new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near });
        }

        private bool _isEntered = false;

        protected override void OnEnter(EventArgs e)
        {
            _isEntered = true;
            this.Invalidate();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            _isEntered = false;
            this.Invalidate();
            base.OnLeave(e);
        }
    }
}
