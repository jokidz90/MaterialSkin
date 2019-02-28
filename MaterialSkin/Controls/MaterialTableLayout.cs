using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialTableLayout : TableLayoutPanel, IMaterialControl
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.CacheText, true);

            ForeColor = SkinManager.GetPrimaryTextColor();
            Font = SkinManager.ROBOTO_REGULAR_11;
            BackColor = SkinManager.GetApplicationBackgroundColor();
            BackColorChanged += MaterialTableLayout_BackColorChanged;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= NativeMethods.WS_EX_COMPOSITED;
                return cp;
            }
        }

        private void MaterialTableLayout_BackColorChanged(object sender, EventArgs e)
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

        public void BeginUpdate()
        {
            NativeMethods.SendMessage(this.Handle, NativeMethods.WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
        }

        public void EndUpdate()
        {
            NativeMethods.SendMessage(this.Handle, NativeMethods.WM_SETREDRAW, new IntPtr(1), IntPtr.Zero);
            Parent.Invalidate(true);
        }
    }

    public static class NativeMethods
    {
        public static int WM_SETREDRAW = 0x000B; //uint WM_SETREDRAW
        public static int WS_EX_COMPOSITED = 0x02000000;


        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam); //UInt32 Msg
    }
}
