using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class MaterialPanel : Panel, IMaterialControl
    {
        private ColorType _colorStyle = ColorType.DEFAULT;
        public ColorType ColorStyle { get => _colorStyle; set => _colorStyle = value; }

        public MaterialPanel()
        {
            InitializeComponent();
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
