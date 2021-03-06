﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin.Animations;
using static System.Windows.Forms.ComboBox;
using System.Linq;
using System.Collections;
using System.Data;
using System.Dynamic;

namespace MaterialSkin.Controls
{
    public partial class MaterialDateRangePicker : Control, IMaterialControl
    {
        //Properties for managing the material design properties
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        private ColorType _colorStyle = ColorType.DEFAULT;
        public ColorType ColorStyle { get => _colorStyle; set => _colorStyle = value; }

        private readonly BaseTextBox _baseTextBox;
        private readonly AnimationManager _animationManager;

        public new object Tag { get { return _baseTextBox.Tag; } set { _baseTextBox.Tag = value; } }

        private string _hint;
        public string Hint
        {
            get
            {
                return _hint;
            }
            set
            {
                _hint = value;
            }
        }

        public void Focus() { _baseTextBox.Focus(); }

        private int _dropDownArrowWidth = 20;
        private MaterialDateRangePickerForm _frmDatePicker = null;

        #region Date PopUp Properties

        public bool ShowTime { get; set; }

        public event DateRangeChangedHandler ValueChanged;

        private int _dropDownWidth = -1;
        public int DropDownWidth { get => _dropDownWidth; set => _dropDownWidth = value; }

        private int _dropDownHeight = 300;
        public int DropDownHeight { get => _dropDownHeight; set => _dropDownHeight = value; }

        private string _dateFormat = "ddd, dd MMM yyyy";
        public string DateFormat { get => _dateFormat; set => _dateFormat = value; }

        private DateTime _startValue = DateTime.Now;
        private DateTime _endValue = DateTime.Now;
        public DateTime StartValue
        {
            set
            {
                _startValue = value;
                string startStr = _startValue.ToString(_dateFormat);
                string endStr = _endValue.ToString(_dateFormat);
                if (ShowTime)
                {
                    startStr += " " + _startValue.ToString("hh:mm tt");
                    endStr += " " + _endValue.ToString("hh:mm tt");
                }

                _baseTextBox.Text = startStr + "  to  " + endStr;
                if (DisplayRangeText && _rangeSelection != DateRangeType.CUSTOM)
                {
                    if (_rangeSelection.ToString().StartsWith("LAST"))
                        _baseTextBox.Text = "Last " + _rangeSelection.ToString().Replace("LAST", "").ToLower();
                    else
                        _baseTextBox.Text = _rangeSelection.ToString().ToUpperFirst();
                }
            }
            get
            {
                return _startValue;
            }
        }

        public DateTime EndValue
        {
            set
            {
                _endValue = value;
                string startStr = _startValue.ToString(_dateFormat);
                string endStr = _endValue.ToString(_dateFormat);
                if (ShowTime)
                {
                    startStr += " " + _startValue.ToString("hh:mm tt");
                    endStr += " " + _endValue.ToString("hh:mm tt");
                }

                _baseTextBox.Text = startStr + " to " + endStr;
                if (DisplayRangeText && _rangeSelection != DateRangeType.CUSTOM)
                {
                    if (_rangeSelection.ToString().StartsWith("LAST"))
                        _baseTextBox.Text = "Last " + _rangeSelection.ToString().Replace("LAST", "").ToLower();
                    else if (_rangeSelection.ToString().StartsWith("THIS"))
                        _baseTextBox.Text = "This " + _rangeSelection.ToString().Replace("THIS", "").ToLower();
                    else
                        _baseTextBox.Text = _rangeSelection.ToString().ToUpperFirst();
                }
            }
            get
            {
                return _endValue;
            }
        }

        private DateRangeType _rangeSelection;
        private DateRangeType RangeSelection
        {
            set
            {
                _rangeSelection = value;
            }
            get
            {
                return _rangeSelection;
            }
        }

        public bool DisplayRangeText { set; get; }

        #endregion

        #region Forwarding events to baseTextBox
        public event EventHandler AcceptsTabChanged
        {
            add
            {
                _baseTextBox.AcceptsTabChanged += value;
            }
            remove
            {
                _baseTextBox.AcceptsTabChanged -= value;
            }
        }

        public new event EventHandler AutoSizeChanged
        {
            add
            {
                _baseTextBox.AutoSizeChanged += value;
            }
            remove
            {
                _baseTextBox.AutoSizeChanged -= value;
            }
        }

        public new event EventHandler BackgroundImageChanged
        {
            add
            {
                _baseTextBox.BackgroundImageChanged += value;
            }
            remove
            {
                _baseTextBox.BackgroundImageChanged -= value;
            }
        }

        public new event EventHandler BackgroundImageLayoutChanged
        {
            add
            {
                _baseTextBox.BackgroundImageLayoutChanged += value;
            }
            remove
            {
                _baseTextBox.BackgroundImageLayoutChanged -= value;
            }
        }

        public new event EventHandler BindingContextChanged
        {
            add
            {
                _baseTextBox.BindingContextChanged += value;
            }
            remove
            {
                _baseTextBox.BindingContextChanged -= value;
            }
        }

        public event EventHandler BorderStyleChanged
        {
            add
            {
                _baseTextBox.BorderStyleChanged += value;
            }
            remove
            {
                _baseTextBox.BorderStyleChanged -= value;
            }
        }

        public new event EventHandler CausesValidationChanged
        {
            add
            {
                _baseTextBox.CausesValidationChanged += value;
            }
            remove
            {
                _baseTextBox.CausesValidationChanged -= value;
            }
        }

        public new event UICuesEventHandler ChangeUICues
        {
            add
            {
                _baseTextBox.ChangeUICues += value;
            }
            remove
            {
                _baseTextBox.ChangeUICues -= value;
            }
        }

        public new event EventHandler Click
        {
            add
            {
                _baseTextBox.Click += value;
            }
            remove
            {
                _baseTextBox.Click -= value;
            }
        }

        public new event EventHandler ClientSizeChanged
        {
            add
            {
                _baseTextBox.ClientSizeChanged += value;
            }
            remove
            {
                _baseTextBox.ClientSizeChanged -= value;
            }
        }

        public new event EventHandler ContextMenuChanged
        {
            add
            {
                _baseTextBox.ContextMenuChanged += value;
            }
            remove
            {
                _baseTextBox.ContextMenuChanged -= value;
            }
        }

        public new event EventHandler ContextMenuStripChanged
        {
            add
            {
                _baseTextBox.ContextMenuStripChanged += value;
            }
            remove
            {
                _baseTextBox.ContextMenuStripChanged -= value;
            }
        }

        public new event ControlEventHandler ControlAdded
        {
            add
            {
                _baseTextBox.ControlAdded += value;
            }
            remove
            {
                _baseTextBox.ControlAdded -= value;
            }
        }

        public new event ControlEventHandler ControlRemoved
        {
            add
            {
                _baseTextBox.ControlRemoved += value;
            }
            remove
            {
                _baseTextBox.ControlRemoved -= value;
            }
        }

        public new event EventHandler CursorChanged
        {
            add
            {
                _baseTextBox.CursorChanged += value;
            }
            remove
            {
                _baseTextBox.CursorChanged -= value;
            }
        }

        public new event EventHandler Disposed
        {
            add
            {
                _baseTextBox.Disposed += value;
            }
            remove
            {
                _baseTextBox.Disposed -= value;
            }
        }

        public new event EventHandler DockChanged
        {
            add
            {
                _baseTextBox.DockChanged += value;
            }
            remove
            {
                _baseTextBox.DockChanged -= value;
            }
        }

        public new event EventHandler DoubleClick
        {
            add
            {
                _baseTextBox.DoubleClick += value;
            }
            remove
            {
                _baseTextBox.DoubleClick -= value;
            }
        }

        public new event DragEventHandler DragDrop
        {
            add
            {
                _baseTextBox.DragDrop += value;
            }
            remove
            {
                _baseTextBox.DragDrop -= value;
            }
        }

        public new event DragEventHandler DragEnter
        {
            add
            {
                _baseTextBox.DragEnter += value;
            }
            remove
            {
                _baseTextBox.DragEnter -= value;
            }
        }

        public new event EventHandler DragLeave
        {
            add
            {
                _baseTextBox.DragLeave += value;
            }
            remove
            {
                _baseTextBox.DragLeave -= value;
            }
        }

        public new event DragEventHandler DragOver
        {
            add
            {
                _baseTextBox.DragOver += value;
            }
            remove
            {
                _baseTextBox.DragOver -= value;
            }
        }

        public new event EventHandler EnabledChanged
        {
            add
            {
                _baseTextBox.EnabledChanged += value;
            }
            remove
            {
                _baseTextBox.EnabledChanged -= value;
            }
        }

        public new event EventHandler Enter
        {
            add
            {
                _baseTextBox.Enter += value;
            }
            remove
            {
                _baseTextBox.Enter -= value;
            }
        }

        public new event EventHandler FontChanged
        {
            add
            {
                _baseTextBox.FontChanged += value;
            }
            remove
            {
                _baseTextBox.FontChanged -= value;
            }
        }

        public new event EventHandler ForeColorChanged
        {
            add
            {
                _baseTextBox.ForeColorChanged += value;
            }
            remove
            {
                _baseTextBox.ForeColorChanged -= value;
            }
        }

        public new event GiveFeedbackEventHandler GiveFeedback
        {
            add
            {
                _baseTextBox.GiveFeedback += value;
            }
            remove
            {
                _baseTextBox.GiveFeedback -= value;
            }
        }

        public new event EventHandler GotFocus
        {
            add
            {
                _baseTextBox.GotFocus += value;
            }
            remove
            {
                _baseTextBox.GotFocus -= value;
            }
        }

        public new event EventHandler HandleCreated
        {
            add
            {
                _baseTextBox.HandleCreated += value;
            }
            remove
            {
                _baseTextBox.HandleCreated -= value;
            }
        }

        public new event EventHandler HandleDestroyed
        {
            add
            {
                _baseTextBox.HandleDestroyed += value;
            }
            remove
            {
                _baseTextBox.HandleDestroyed -= value;
            }
        }

        public new event HelpEventHandler HelpRequested
        {
            add
            {
                _baseTextBox.HelpRequested += value;
            }
            remove
            {
                _baseTextBox.HelpRequested -= value;
            }
        }

        public event EventHandler HideSelectionChanged
        {
            add
            {
                _baseTextBox.HideSelectionChanged += value;
            }
            remove
            {
                _baseTextBox.HideSelectionChanged -= value;
            }
        }

        public new event EventHandler ImeModeChanged
        {
            add
            {
                _baseTextBox.ImeModeChanged += value;
            }
            remove
            {
                _baseTextBox.ImeModeChanged -= value;
            }
        }

        public new event InvalidateEventHandler Invalidated
        {
            add
            {
                _baseTextBox.Invalidated += value;
            }
            remove
            {
                _baseTextBox.Invalidated -= value;
            }
        }

        public new event KeyEventHandler KeyDown
        {
            add
            {
                _baseTextBox.KeyDown += value;
            }
            remove
            {
                _baseTextBox.KeyDown -= value;
            }
        }

        public new event KeyPressEventHandler KeyPress
        {
            add
            {
                _baseTextBox.KeyPress += value;
            }
            remove
            {
                _baseTextBox.KeyPress -= value;
            }
        }

        public new event KeyEventHandler KeyUp
        {
            add
            {
                _baseTextBox.KeyUp += value;
            }
            remove
            {
                _baseTextBox.KeyUp -= value;
            }
        }

        public new event LayoutEventHandler Layout
        {
            add
            {
                _baseTextBox.Layout += value;
            }
            remove
            {
                _baseTextBox.Layout -= value;
            }
        }

        public new event EventHandler Leave
        {
            add
            {
                _baseTextBox.Leave += value;
            }
            remove
            {
                _baseTextBox.Leave -= value;
            }
        }

        public new event EventHandler LocationChanged
        {
            add
            {
                _baseTextBox.LocationChanged += value;
            }
            remove
            {
                _baseTextBox.LocationChanged -= value;
            }
        }

        public new event EventHandler LostFocus
        {
            add
            {
                _baseTextBox.LostFocus += value;
            }
            remove
            {
                _baseTextBox.LostFocus -= value;
            }
        }

        public new event EventHandler MarginChanged
        {
            add
            {
                _baseTextBox.MarginChanged += value;
            }
            remove
            {
                _baseTextBox.MarginChanged -= value;
            }
        }

        public event EventHandler ModifiedChanged
        {
            add
            {
                _baseTextBox.ModifiedChanged += value;
            }
            remove
            {
                _baseTextBox.ModifiedChanged -= value;
            }
        }

        public new event EventHandler MouseCaptureChanged
        {
            add
            {
                _baseTextBox.MouseCaptureChanged += value;
            }
            remove
            {
                _baseTextBox.MouseCaptureChanged -= value;
            }
        }

        public new event MouseEventHandler MouseClick
        {
            add
            {
                _baseTextBox.MouseClick += value;
            }
            remove
            {
                _baseTextBox.MouseClick -= value;
            }
        }

        public new event MouseEventHandler MouseDoubleClick
        {
            add
            {
                _baseTextBox.MouseDoubleClick += value;
            }
            remove
            {
                _baseTextBox.MouseDoubleClick -= value;
            }
        }

        public new event MouseEventHandler MouseDown
        {
            add
            {
                _baseTextBox.MouseDown += value;
            }
            remove
            {
                _baseTextBox.MouseDown -= value;
            }
        }

        public new event EventHandler MouseEnter
        {
            add
            {
                _baseTextBox.MouseEnter += value;
            }
            remove
            {
                _baseTextBox.MouseEnter -= value;
            }
        }

        public new event EventHandler MouseHover
        {
            add
            {
                _baseTextBox.MouseHover += value;
            }
            remove
            {
                _baseTextBox.MouseHover -= value;
            }
        }

        public new event EventHandler MouseLeave
        {
            add
            {
                _baseTextBox.MouseLeave += value;
            }
            remove
            {
                _baseTextBox.MouseLeave -= value;
            }
        }

        public new event MouseEventHandler MouseMove
        {
            add
            {
                _baseTextBox.MouseMove += value;
            }
            remove
            {
                _baseTextBox.MouseMove -= value;
            }
        }

        public new event MouseEventHandler MouseUp
        {
            add
            {
                _baseTextBox.MouseUp += value;
            }
            remove
            {
                _baseTextBox.MouseUp -= value;
            }
        }

        public new event MouseEventHandler MouseWheel
        {
            add
            {
                _baseTextBox.MouseWheel += value;
            }
            remove
            {
                _baseTextBox.MouseWheel -= value;
            }
        }

        public new event EventHandler Move
        {
            add
            {
                _baseTextBox.Move += value;
            }
            remove
            {
                _baseTextBox.Move -= value;
            }
        }

        public event EventHandler MultilineChanged
        {
            add
            {
                _baseTextBox.MultilineChanged += value;
            }
            remove
            {
                _baseTextBox.MultilineChanged -= value;
            }
        }

        public new event EventHandler PaddingChanged
        {
            add
            {
                _baseTextBox.PaddingChanged += value;
            }
            remove
            {
                _baseTextBox.PaddingChanged -= value;
            }
        }

        public new event PaintEventHandler Paint
        {
            add
            {
                _baseTextBox.Paint += value;
            }
            remove
            {
                _baseTextBox.Paint -= value;
            }
        }

        public new event EventHandler ParentChanged
        {
            add
            {
                _baseTextBox.ParentChanged += value;
            }
            remove
            {
                _baseTextBox.ParentChanged -= value;
            }
        }

        public new event PreviewKeyDownEventHandler PreviewKeyDown
        {
            add
            {
                _baseTextBox.PreviewKeyDown += value;
            }
            remove
            {
                _baseTextBox.PreviewKeyDown -= value;
            }
        }

        public new event QueryAccessibilityHelpEventHandler QueryAccessibilityHelp
        {
            add
            {
                _baseTextBox.QueryAccessibilityHelp += value;
            }
            remove
            {
                _baseTextBox.QueryAccessibilityHelp -= value;
            }
        }

        public new event QueryContinueDragEventHandler QueryContinueDrag
        {
            add
            {
                _baseTextBox.QueryContinueDrag += value;
            }
            remove
            {
                _baseTextBox.QueryContinueDrag -= value;
            }
        }

        public event EventHandler ReadOnlyChanged
        {
            add
            {
                _baseTextBox.ReadOnlyChanged += value;
            }
            remove
            {
                _baseTextBox.ReadOnlyChanged -= value;
            }
        }

        public new event EventHandler RegionChanged
        {
            add
            {
                _baseTextBox.RegionChanged += value;
            }
            remove
            {
                _baseTextBox.RegionChanged -= value;
            }
        }

        public new event EventHandler Resize
        {
            add
            {
                _baseTextBox.Resize += value;
            }
            remove
            {
                _baseTextBox.Resize -= value;
            }
        }

        public new event EventHandler RightToLeftChanged
        {
            add
            {
                _baseTextBox.RightToLeftChanged += value;
            }
            remove
            {
                _baseTextBox.RightToLeftChanged -= value;
            }
        }

        public new event EventHandler SizeChanged
        {
            add
            {
                _baseTextBox.SizeChanged += value;
            }
            remove
            {
                _baseTextBox.SizeChanged -= value;
            }
        }

        public new event EventHandler StyleChanged
        {
            add
            {
                _baseTextBox.StyleChanged += value;
            }
            remove
            {
                _baseTextBox.StyleChanged -= value;
            }
        }

        public new event EventHandler SystemColorsChanged
        {
            add
            {
                _baseTextBox.SystemColorsChanged += value;
            }
            remove
            {
                _baseTextBox.SystemColorsChanged -= value;
            }
        }

        public new event EventHandler TabIndexChanged
        {
            add
            {
                _baseTextBox.TabIndexChanged += value;
            }
            remove
            {
                _baseTextBox.TabIndexChanged -= value;
            }
        }

        public new event EventHandler TabStopChanged
        {
            add
            {
                _baseTextBox.TabStopChanged += value;
            }
            remove
            {
                _baseTextBox.TabStopChanged -= value;
            }
        }

        public event EventHandler TextAlignChanged
        {
            add
            {
                _baseTextBox.TextAlignChanged += value;
            }
            remove
            {
                _baseTextBox.TextAlignChanged -= value;
            }
        }

        public new event EventHandler TextChanged
        {
            add
            {
                _baseTextBox.TextChanged += value;
            }
            remove
            {
                _baseTextBox.TextChanged -= value;
            }
        }

        public new event EventHandler Validated
        {
            add
            {
                _baseTextBox.Validated += value;
            }
            remove
            {
                _baseTextBox.Validated -= value;
            }
        }

        public new event CancelEventHandler Validating
        {
            add
            {
                _baseTextBox.Validating += value;
            }
            remove
            {
                _baseTextBox.Validating -= value;
            }
        }

        public new event EventHandler VisibleChanged
        {
            add
            {
                _baseTextBox.VisibleChanged += value;
            }
            remove
            {
                _baseTextBox.VisibleChanged -= value;
            }
        }
        #endregion

        public MaterialDateRangePicker()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer, true);

            _animationManager = new AnimationManager
            {
                Increment = 0.06,
                AnimationType = AnimationType.EaseInOut,
                InterruptAnimation = false
            };
            _animationManager.OnAnimationProgress += sender => Invalidate();

            _baseTextBox = new BaseTextBox
            {
                BorderStyle = BorderStyle.None,
                Font = SkinManager.ROBOTO_REGULAR_11,
                ForeColor = SkinManager.GetHintColor(),
                Location = new Point(0, 0),
                Width = Width - _dropDownArrowWidth,
                Height = Height - 5
            };

            if (!Controls.Contains(_baseTextBox) && !DesignMode)
                Controls.Add(_baseTextBox);

            _baseTextBox.GotFocus += (sender, args) => _animationManager.StartNewAnimation(AnimationDirection.In);
            _baseTextBox.LostFocus += (sender, args) => _animationManager.StartNewAnimation(AnimationDirection.Out);
            BackColorChanged += (sender, args) =>
            {
                _baseTextBox.BackColor = BackColor;
                _baseTextBox.ForeColor = !Enabled ? SkinManager.GetDisabledOrHintColor() : SkinManager.GetPrimaryTextColor();
            };
            //Fix for tabstop
            this.Cursor = Cursors.Hand;
            this.TabStop = false;

            _baseTextBox.TabStop = true;
            _baseTextBox.ReadOnly = true;
            _baseTextBox.Cursor = Cursors.Hand;
            _baseTextBox.Click += (sender, args) => { ShowDateSelector(); };
            _baseTextBox.GotFocus += (sender, args) => { ShowDateSelector(); };
            _baseTextBox.Enter += (sender, args) => { ShowDateSelector(); };
            _baseTextBox.Leave += (sender, args) => { HideDateSelector(); };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var backColorColored = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.PrimaryColor : ColorScheme.ColorSwatches[_colorStyle].PrimaryColor;
            var backColorNormal = Enabled ? SkinManager.GetHintColor() : SkinManager.GetDisabledOrHintColor().AddAlpha(50);

            var backBrushColored = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.PrimaryBrush : ColorScheme.ColorSwatches[_colorStyle].PrimaryBrush;
            var backBrushNormal = Enabled ? SkinManager.GetDividersBrush() : new SolidBrush(SkinManager.GetDisabledOrHintColor().AddAlpha(50));
            var g = pevent.Graphics;
            g.Clear(Parent.BackColor);

            var lineY = _baseTextBox.Bottom + 2;
            var lineHeightFocused = 3f;
            var lineHeightNormal = 2f;
            bool isFocused = _baseTextBox.Focused || _isSelectorShown;

            g.DrawImage((Image)Properties.Resources.ACTION_DATE_RANGE.ReplaceColor(Color.Black, (isFocused ? backColorColored : backColorNormal)), _baseTextBox.Width, _baseTextBox.Top, _dropDownArrowWidth, _dropDownArrowWidth);
            if (!_animationManager.IsAnimating())
            {
                //No animation
                g.FillRectangle(isFocused ? backBrushColored : backBrushNormal, _baseTextBox.Location.X, lineY, this.Width, _baseTextBox.Focused ? lineHeightFocused : lineHeightNormal);
            }
            else
            {
                //Animate
                int animationWidth = (int)(this.Width * _animationManager.GetProgress());
                int halfAnimationWidth = animationWidth / 2;
                int animationStart = _baseTextBox.Location.X + this.Width / 2;

                //Unfocused background
                g.FillRectangle(backBrushNormal, _baseTextBox.Location.X, lineY, this.Width, lineHeightNormal);

                //Animated focus transition
                g.FillRectangle(backBrushColored, animationStart - halfAnimationWidth, lineY, animationWidth, lineHeightFocused);
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            ForeColor = Enabled ? SkinManager.GetPrimaryTextColor() : SkinManager.GetDisabledOrHintColor();
            _baseTextBox.ForeColor = !Enabled ? SkinManager.GetDisabledOrHintColor() : SkinManager.GetPrimaryTextColor();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            _baseTextBox.Location = new Point(0, 0);
            _baseTextBox.Width = Width- _dropDownArrowWidth;

            Height = _baseTextBox.Height + 5;
        }

        protected override void OnClick(EventArgs e)
        {
            ShowDateSelector();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            ShowDateSelector();
        }

        protected override void OnEnter(EventArgs e)
        {
            ShowDateSelector();
        }

        protected override void OnLeave(EventArgs e)
        {
            HideDateSelector();
        }


        private bool _isSelectorShown = false;
        private void ShowDateSelector()
        {
            if (_isClosing)
                return;
            if (_isSelectorShown)
            {
                HideDateSelectorHelper();
                return;
            }
            _isSelectorShown = true;

            InitDateSelector();
            _frmDatePicker.Show();
            _frmDatePicker.BringToFront();
        }

        private bool _isClosing = false;
        private void HideDateSelector()
        {
            _isClosing = true;
            HideDateSelectorHelper();
            _isClosing = false;
        }

        private void HideDateSelectorHelper()
        {
            if (!_isSelectorShown)
                return;
            _isSelectorShown = false;
            if (_frmDatePicker == null || _frmDatePicker.IsDisposed)
                return;

            _frmDatePicker.Close();
        }

        protected void InitDateSelector()
        {
            if (_frmDatePicker != null && !_frmDatePicker.IsDisposed)
                return;
            var startPoint = this.PointToScreen(Point.Empty);
            startPoint.Y = startPoint.Y;// + this.Height;
            var frmWidth = _dropDownWidth <= 0 ? this.Width : _dropDownWidth;
            var frmHeight = _dropDownHeight <= 0 ? 300 : _dropDownHeight;
            //frmHeight += 15;

            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;

            int yDiff = area.Height - (startPoint.Y + frmHeight);
            if (yDiff < 0)
                startPoint.Y = startPoint.Y + yDiff;

            _frmDatePicker = new MaterialDateRangePickerForm();
            _frmDatePicker.StartValue = StartValue;
            _frmDatePicker.EndValue = EndValue;
            _frmDatePicker.RangeSelection = _rangeSelection;
            _frmDatePicker.DateFormat = DateFormat;
            _frmDatePicker.ShowTime = ShowTime;
            _frmDatePicker.StartPosition = FormStartPosition.Manual;
            _frmDatePicker.Location = startPoint;
            _frmDatePicker.Width = frmWidth;
            _frmDatePicker.Height = frmHeight;
            _frmDatePicker.Leave += (sender, e) => { HideDateSelector(); };
            _frmDatePicker.ValueChanged += (sender, start, end, range) =>
              {
                  HideDateSelector();
                  this.RangeSelection = range;
                  this.StartValue = start;
                  this.EndValue = end;
                  if (ValueChanged != null)
                      ValueChanged(this, StartValue, EndValue, RangeSelection);
              };
        }

        private class BaseTextBox : TextBox
        {
            public new void SelectAll()
            {
                BeginInvoke((MethodInvoker)delegate ()
                {
                    base.Focus();
                    base.SelectAll();
                });
            }

            public new void Focus()
            {
                BeginInvoke((MethodInvoker)delegate ()
                {
                    base.Focus();
                });
            }

            public BaseTextBox()
            {

            }
        }
    }
}
