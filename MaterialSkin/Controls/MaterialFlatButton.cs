using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using MaterialSkin.Animations;

namespace MaterialSkin.Controls
{
    public class MaterialFlatButton : Button, IMaterialControl
    {
        public event MouseEventHandler TouchDown;
        public event MouseEventHandler TouchUp;

        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        public bool Primary { get; set; }

        private ColorType _borderColorType = ColorType.DEFAULT;
        public ColorType BorderColorType
        {
            get => _borderColorType;
            set
            {
                _borderColorType = value;
                Invalidate();
            }
        }

        private ColorType _colorStyle = ColorType.DEFAULT;
        public ColorType ColorStyle
        {
            get => _colorStyle;
            set
            {
                _colorStyle = value;
                Invalidate();
            }
        }

        private readonly AnimationManager _animationManager;
        private readonly AnimationManager _hoverAnimationManager;

        private SizeF _textSize;

        private bool? _isSelected = false;
        public bool? IsSelected
        {
            get
            {
                return _isSelected;
            }
            set
            {
                _isSelected = value;
                //if (_isSelected.HasValue)
                //    IconType = _isSelected.GetValueOrDefault(false) ? IconType.CHECK_BOX : IconType.CHECK_BOX_OUTLINE_BLANK;
                //else
                //    IconType = IconType.NONE;
            }
        }

        private int _iconSize = 24;
        private IconType _iconType = IconType.NONE;
        public IconType IconType
        {
            get { return _iconType; }
            set
            {
                _iconType = value;
                if (_iconType == IconType.NONE)
                    Icon = null;
                else
                    Icon = IconManager.Settings[_iconType];
            }
        }

        private Image _icon;
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                if (AutoSize)
                    Size = GetPreferredSize();
                Invalidate();
            }
        }

        private StringAlignment _alignment = StringAlignment.Center;
        public StringAlignment Alignment { get => _alignment; set => _alignment = value; }

        public MaterialFlatButton()
        {
            Primary = false;

            _animationManager = new AnimationManager(false)
            {
                Increment = 0.03,
                AnimationType = AnimationType.EaseOut
            };
            _hoverAnimationManager = new AnimationManager
            {
                Increment = 0.07,
                AnimationType = AnimationType.Linear
            };

            _hoverAnimationManager.OnAnimationProgress += sender => Invalidate();
            _animationManager.OnAnimationProgress += sender => Invalidate();

            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoSize = true;
            Margin = new Padding(4, 6, 4, 6);
            Padding = new Padding(0);
            Cursor = Cursors.Hand;
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                _textSize = CreateGraphics().MeasureString(value.ToUpper(), SkinManager.ROBOTO_MEDIUM_10);
                if (AutoSize)
                    Size = GetPreferredSize();
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var frontBrush = Enabled ? SkinManager.GetPrimaryTextBrush() : SkinManager.GetFlatButtonDisabledTextBrush();
            if (_colorStyle != ColorType.DEFAULT)
                frontBrush = Enabled ? ColorScheme.ColorSwatches[_colorStyle].PrimaryBrush : ColorScheme.ColorSwatches[_colorStyle].LightPrimaryBrush;
            var frontColor = frontBrush.GetColor();

            var g = pevent.Graphics;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            g.Clear(Parent.BackColor);

            if (_borderColorType != ColorType.DEFAULT)
            {
                var pen = new Pen(ColorScheme.ColorSwatches[_borderColorType].PrimaryColor);
                int penW = 2;
                pen.Width = penW;
                pen.LineJoin = LineJoin.Round;
                var newRect = new Rectangle(ClientRectangle.X + penW, ClientRectangle.Y + penW, ClientRectangle.Width - (2 * penW), ClientRectangle.Height - (2 * penW));
                g.DrawRectangle(pen, newRect);
            }

            //Hover
            Color c = SkinManager.GetFlatButtonHoverBackgroundColor();
            using (Brush b = new SolidBrush(Color.FromArgb((int)(_hoverAnimationManager.GetProgress() * c.A), c.RemoveAlpha())))
                g.FillRectangle(b, ClientRectangle);

            //Ripple
            if (_animationManager.IsAnimating())
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                for (var i = 0; i < _animationManager.GetAnimationCount(); i++)
                {
                    var animationValue = _animationManager.GetProgress(i);
                    var animationSource = _animationManager.GetSource(i);

                    using (Brush rippleBrush = new SolidBrush(Color.FromArgb((int)(101 - (animationValue * 100)), Color.Black)))
                    {
                        var rippleSize = (int)(animationValue * Width * 2);
                        g.FillEllipse(rippleBrush, new Rectangle(animationSource.X - rippleSize / 2, animationSource.Y - rippleSize / 2, rippleSize, rippleSize));
                    }
                }
                g.SmoothingMode = SmoothingMode.None;
            }

            //Icon
            var iconY = (this.Height - _iconSize) / 2;
            var iconX = iconY;
            if (string.IsNullOrEmpty(Text))
                iconX = (this.Width - _iconSize) / 2;
            var iconRect = new Rectangle(iconX, iconY, _iconSize, _iconSize);
            if (Icon != null)
                g.DrawImage(Icon.ReplaceColor(Color.Black, frontColor), iconRect);

            //Text
            var textRect = ClientRectangle;

            if (Icon != null)
            {
                //
                // Resize and move Text container
                //

                // First 8: left padding
                // 24: icon width
                // Second 4: space between Icon and Text
                // Third 8: right padding
                textRect.Width -= 8 + _iconSize + 4 + 8;

                // First 8: left padding
                // 24: icon width
                // Second 4: space between Icon and Text
                textRect.X += 8 + _iconSize + 4;
            }

            g.DrawString(
                Text.ToUpper(),
                SkinManager.ROBOTO_MEDIUM_10,
                frontBrush,
                textRect,
                new StringFormat { Alignment = _alignment, LineAlignment = StringAlignment.Center }
                );
        }

        private Size GetPreferredSize()
        {
            return GetPreferredSize(new Size(0, 0));
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            // Provides extra space for proper padding for content
            //var extra = 16;

            //if (Icon != null)
            //    // 24 is for icon size
            //    // 4 is for the space between icon & text
            //    extra += 24 + 4;

            //return new Size((int)Math.Ceiling(_textSize.Width) + extra, 36);
            int defaultHeight = 36;
            int defaultWidth = defaultHeight;
            var extra = 16;

            if (!string.IsNullOrEmpty(Text))
            {
                defaultWidth = (int)Math.Ceiling(_textSize.Width) + extra;
                if (Icon != null)
                {
                    var iconY = (defaultHeight - _iconSize) / 2;
                    defaultWidth = defaultWidth + (iconY) + _iconSize;
                }
            }

            return new Size(defaultWidth, defaultHeight);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (DesignMode) return;

            MouseState = MouseState.OUT;
            MouseEnter += (sender, args) =>
            {
                MouseState = MouseState.HOVER;
                _hoverAnimationManager.StartNewAnimation(AnimationDirection.In);
                Invalidate();
            };
            MouseLeave += (sender, args) =>
            {
                MouseState = MouseState.OUT;
                _hoverAnimationManager.StartNewAnimation(AnimationDirection.Out);
                Invalidate();
            };
            MouseDown += (sender, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    MouseState = MouseState.DOWN;

                    _animationManager.StartNewAnimation(AnimationDirection.In, args.Location);
                    Invalidate();
                }
            };
            TouchDown += (sender, args) => { OnMouseDown(args); };

            MouseUp += (sender, args) =>
            {
                MouseState = MouseState.HOVER;

                Invalidate();
            };
            TouchUp += (sender, args) => { OnMouseUp(args); };
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case Win32.WM_POINTERDOWN:
                case Win32.WM_POINTERUP:
                case Win32.WM_POINTERUPDATE:
                case Win32.WM_POINTERCAPTURECHANGED:
                    break;

                default:
                    base.WndProc(ref m);
                    return;
            }
            int pointerID = Win32.GET_POINTER_ID(m.WParam);
            Win32.POINTER_INFO pi = new Win32.POINTER_INFO();
            if (!Win32.GetPointerInfo(pointerID, ref pi))
            {
                Win32.CheckLastError();
            }
            Point pt = PointToClient(pi.PtPixelLocation.ToPoint());
            MouseEventArgs me = new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 1, pt.X, pt.Y, 0);
            switch (m.Msg)
            {
                case Win32.WM_POINTERDOWN:
                    Debug.WriteLine("TOUCH DOWN" + pt);
                    if (TouchDown != null) TouchDown(this, me);
                    break;

                case Win32.WM_POINTERUP:
                    Debug.WriteLine("TOUCH UP");
                    if (TouchUp != null) TouchUp(this, me);
                    break;

                case Win32.WM_POINTERUPDATE:
                    //Console.WriteLine("UPDATE");
                    break;
            }
        }
    }
}
