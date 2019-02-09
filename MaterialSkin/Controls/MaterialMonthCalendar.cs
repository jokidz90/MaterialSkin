
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MaterialSkin.Controls
{
    public partial class MaterialMonthCalendar : MonthCalendar, IMaterialControl
    {
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        static extern Int32 SetWindowTheme(IntPtr hWnd, String textSubAppName, String textSubIdList);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr GetParent(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private ColorType _colorStyle = ColorType.DEFAULT;
        public ColorType ColorStyle { get => _colorStyle; set => _colorStyle = value; }

        public MaterialMonthCalendar()
        {
            InitializeComponent();

            if (Application.RenderWithVisualStyles)
            {
                const int DTM_GETMONTHCAL = 0x1008;

                //Get handle of calendar control - disable theming
                IntPtr hCalendar = SendMessage(this.Handle, DTM_GETMONTHCAL, IntPtr.Zero, IntPtr.Zero);
                if (hCalendar != IntPtr.Zero)
                {
                    SetWindowTheme(hCalendar, "", "");

                    //Get handle of parent popup - resize appropriately
                    IntPtr hParent = GetParent(hCalendar);
                    if (hParent != IntPtr.Zero)
                    {
                        //The size you specify here will depend on the CalendarFont size chosen
                        MoveWindow(hParent, 0, 0, 400, 300, true);
                    }
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            ForeColor = SkinManager.GetPrimaryTextColor();
            Font = SkinManager.ROBOTO_REGULAR_11;
            BackColor = SkinManager.GetApplicationBackgroundColor();
            BackColorChanged += MaterialPanel_BackColorChanged;
        }

        private void MaterialPanel_BackColorChanged(object sender, EventArgs e)
        {
            ForeColor = SkinManager.GetPrimaryTextColor();
            BackColor = SkinManager.GetApplicationBackgroundColor();
        }

        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
    }
}
