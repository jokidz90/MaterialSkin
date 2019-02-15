using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;

namespace MaterialSkin.Controls
{
    public class MaterialRichText : Control, IMaterialControl
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

        private readonly BaseRichTextBox _baseTextBox;
        private readonly AnimationManager _animationManager;

        public override string Text { get { return _baseTextBox.Text; } set { _baseTextBox.Text = value; } }
        public new object Tag { get { return _baseTextBox.Tag; } set { _baseTextBox.Tag = value; } }
        public new int MaxLength { get { return _baseTextBox.MaxLength; } set { _baseTextBox.MaxLength = value; } }

        public string SelectedText { get { return _baseTextBox.SelectedText; } set { _baseTextBox.SelectedText = value; } }
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
                _baseTextBox.Hint = value;
            }
        }

        public int SelectionStart { get { return _baseTextBox.SelectionStart; } set { _baseTextBox.SelectionStart = value; } }
        public int SelectionLength { get { return _baseTextBox.SelectionLength; } set { _baseTextBox.SelectionLength = value; } }
        public int TextLength => _baseTextBox.TextLength;

        public void SelectAll() { _baseTextBox.SelectAll(); }
        public void Clear() { _baseTextBox.Clear(); }
        public void Focus() { _baseTextBox.Focus(); }


        # region Forwarding events to baseTextBox
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

        private const int TEXTPAD = 5;
        public MaterialRichText()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.DoubleBuffer, true);
            Height = 100;
            _animationManager = new AnimationManager
            {
                Increment = 0.06,
                AnimationType = AnimationType.EaseInOut,
                InterruptAnimation = false
            };
            _animationManager.OnAnimationProgress += sender => Invalidate();

            _baseTextBox = new BaseRichTextBox
            {
                BorderStyle = BorderStyle.None,
                Font = SkinManager.ROBOTO_REGULAR_11,
                ForeColor = SkinManager.GetPrimaryTextColor(),
                Location = new Point(TEXTPAD, TEXTPAD),
                Width = Width - (2 * TEXTPAD),
                Height = Height - (2 * TEXTPAD)
            };

            if (!Controls.Contains(_baseTextBox) && !DesignMode)
            {
                Controls.Add(_baseTextBox);
            }

            _baseTextBox.GotFocus += (sender, args) => _animationManager.StartNewAnimation(AnimationDirection.In);
            _baseTextBox.LostFocus += (sender, args) => _animationManager.StartNewAnimation(AnimationDirection.Out);
            BackColorChanged += (sender, args) =>
            {
                _baseTextBox.BackColor = BackColor;
                _baseTextBox.ForeColor = Enabled ? SkinManager.GetPrimaryTextColor() : SkinManager.GetDisabledOrHintColor();
            };

            //Fix for tabstop
            _baseTextBox.TabStop = true;
            this.TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            var backBrushColored = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.PrimaryBrush : ColorScheme.ColorSwatches[_colorStyle].PrimaryBrush;
            var backBrushNormal = Enabled ? SkinManager.GetDividersBrush() : new SolidBrush(SkinManager.GetDisabledOrHintColor().AddAlpha(50));
            var g = pevent.Graphics;
            g.Clear(Parent.BackColor);

            var lineHeightFocused = 3f;
            var lineHeightNormal = 2f;

            if (!_animationManager.IsAnimating())
            {
                var lineBrush = _baseTextBox.Focused ? backBrushColored : backBrushNormal;
                var lineWeight = _baseTextBox.Focused ? lineHeightFocused : lineHeightNormal;
                int pad = Convert.ToInt32(lineWeight);
                var lineY1 = 0;
                var lineY2 = Height - lineY1 - pad;

                var lineX1 = 0;
                var lineX2 = Width - lineX1;

                //No animation
                //top
                g.FillRectangle(lineBrush, lineX1, lineY1, lineX2, lineWeight);

                //bottom
                g.FillRectangle(lineBrush, lineX1, lineY2, lineX2, lineWeight);

                //left
                g.FillRectangle(lineBrush, lineX1, lineY1 + lineWeight, lineWeight, lineY2 - lineWeight);

                //right
                g.FillRectangle(lineBrush, lineX2 - lineWeight, lineY1 + lineWeight, lineWeight, lineY2 - lineWeight);
            }
            else
            {
                var lineY1 = 0;
                var lineY2 = Height - lineY1;

                var lineX1 = 0;
                var lineX2 = Width - lineX1;

                //top
                g.FillRectangle(backBrushNormal, lineX1, lineY1, lineX2, lineHeightNormal);

                //bottom
                g.FillRectangle(backBrushNormal, lineX1, lineY2 - lineHeightNormal, lineX2, lineHeightNormal);

                //left
                g.FillRectangle(backBrushNormal, lineX1, lineY1 + lineHeightNormal, lineHeightNormal, lineY2 - (lineHeightNormal * 2));

                //right
                g.FillRectangle(backBrushNormal, lineX2 - lineHeightNormal, lineY1 + lineHeightNormal, lineHeightNormal, lineY2 - (lineHeightNormal * 2));

                int animationWidth = (int)(lineX2 * _animationManager.GetProgress());
                int halfAnimationWidth = animationWidth / 2;
                int animationStartX = lineX1 + (lineX2 / 2);

                //top
                g.FillRectangle(backBrushColored, animationStartX - halfAnimationWidth, lineY1, animationWidth, lineHeightFocused);

                //bottom
                g.FillRectangle(backBrushColored, animationStartX - halfAnimationWidth, lineY2 - lineHeightFocused, animationWidth, lineHeightFocused);
            }
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (!Enabled)
            {
                _baseTextBox.Hint = "";
                if (Text == _hint || string.IsNullOrEmpty(Text))
                    Text = _hint;
            }
            else
            {
                _baseTextBox.Hint = _hint;
                if (Text == _hint)
                    Text = "";
            }

            ForeColor = Enabled ? SkinManager.GetPrimaryTextColor() : SkinManager.GetDisabledOrHintColor();
            _baseTextBox.ForeColor = Enabled ? SkinManager.GetPrimaryTextColor() : SkinManager.GetDisabledOrHintColor();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_baseTextBox == null)
                return;
            _baseTextBox.Location = new Point(TEXTPAD, TEXTPAD);
            _baseTextBox.Width = Width - (2 * TEXTPAD);
            _baseTextBox.Height = Height - (2 * TEXTPAD);
            //Height = _baseTextBox.Height + 5;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            _baseTextBox.BackColor = Parent.BackColor;
            _baseTextBox.ForeColor = Enabled ? SkinManager.GetPrimaryTextColor() : SkinManager.GetDisabledOrHintColor();
        }

        private class BaseRichTextBox : RichTextBox
        {
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

            private const int EM_SETCUEBANNER = 0x1501;
            private const char EmptyChar = (char)0;
            private const char VisualStylePasswordChar = '\u25CF';
            private const char NonVisualStylePasswordChar = '\u002A';

            private bool inhibitPaint = false;
            public bool InhibitPaint
            {
                set { inhibitPaint = value; }
                get { return inhibitPaint; }
            }

            private string hint = string.Empty;
            public string Hint
            {
                get { return hint; }
                set
                {
                    hint = value;
                    SendMessage(Handle, EM_SETCUEBANNER, (int)IntPtr.Zero, Hint);
                }
            }

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

            public BaseRichTextBox()
            {
                MaterialContextMenuStrip cms = new TextBoxContextMenuStrip();
                cms.Opening += ContextMenuStripOnOpening;
                cms.OnItemClickStart += ContextMenuStripOnItemClickStart;

                ContextMenuStrip = cms;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                //var g = e.Graphics;
                //float y = 0;
                //var lineHeight = g.MeasureString("X", this.Font).Height;
                //var color = ForeColor.AddAlpha(50);
                //var pen = new Pen(color);
                //while (y < this.Height)
                //{
                //    y += lineHeight;
                //    g.DrawLine(pen, 0f, y, (float)this.Width, y);
                //}
            }


            private const int WM_PAINT = 15;
            protected override void WndProc(ref System.Windows.Forms.Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_PAINT && !inhibitPaint)
                {
                    //Invalidate();
                    // raise the paint event
                    using (Graphics graphic = base.CreateGraphics())
                        OnPaint(new PaintEventArgs(graphic, base.ClientRectangle));
                }

            }


            private void ContextMenuStripOnItemClickStart(object sender, ToolStripItemClickedEventArgs toolStripItemClickedEventArgs)
            {
                switch (toolStripItemClickedEventArgs.ClickedItem.Text)
                {
                    case "Undo":
                        Undo();
                        break;
                    case "Cut":
                        Cut();
                        break;
                    case "Copy":
                        Copy();
                        break;
                    case "Paste":
                        Paste();
                        break;
                    case "Delete":
                        SelectedText = string.Empty;
                        break;
                    case "Select All":
                        SelectAll();
                        break;
                }
            }

            private void ContextMenuStripOnOpening(object sender, CancelEventArgs cancelEventArgs)
            {
                var strip = sender as TextBoxContextMenuStrip;
                if (strip != null)
                {
                    strip.Undo.Enabled = CanUndo;
                    strip.Cut.Enabled = !string.IsNullOrEmpty(SelectedText);
                    strip.Copy.Enabled = !string.IsNullOrEmpty(SelectedText);
                    strip.Paste.Enabled = Clipboard.ContainsText();
                    strip.Delete.Enabled = !string.IsNullOrEmpty(SelectedText);
                    strip.SelectAll.Enabled = !string.IsNullOrEmpty(Text);
                }
            }
        }

        private class TextBoxContextMenuStrip : MaterialContextMenuStrip
        {
            public readonly ToolStripItem Undo = new MaterialToolStripMenuItem { Text = "Undo" };
            public readonly ToolStripItem Seperator1 = new ToolStripSeparator();
            public readonly ToolStripItem Cut = new MaterialToolStripMenuItem { Text = "Cut" };
            public readonly ToolStripItem Copy = new MaterialToolStripMenuItem { Text = "Copy" };
            public readonly ToolStripItem Paste = new MaterialToolStripMenuItem { Text = "Paste" };
            public readonly ToolStripItem Delete = new MaterialToolStripMenuItem { Text = "Delete" };
            public readonly ToolStripItem Seperator2 = new ToolStripSeparator();
            public readonly ToolStripItem SelectAll = new MaterialToolStripMenuItem { Text = "Select All" };

            public TextBoxContextMenuStrip()
            {
                Items.AddRange(new[]
                {
                    Undo,
                    Seperator1,
                    Cut,
                    Copy,
                    Paste,
                    Delete,
                    Seperator2,
                    SelectAll
                });
            }
        }
    }
}
