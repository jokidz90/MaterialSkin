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
    public partial class MaterialPanelColored : Panel, IMaterialControl
    {
        private ColorType _colorStyle = ColorType.DEFAULT;
        public ColorType ColorStyle { get => _colorStyle; set => _colorStyle = value; }

        public MaterialPanelColored()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Font = SkinManager.ROBOTO_REGULAR_11;
            ForeColor = SkinManager.GetRaisedButtonTextColor(true);
            BackColor = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.PrimaryColor : ColorScheme.ColorSwatches[_colorStyle].PrimaryColor;
            BackColorChanged += (sender, e) =>
            {
                ForeColor = SkinManager.GetRaisedButtonTextColor(true);
                BackColor = _colorStyle == ColorType.DEFAULT ? SkinManager.ColorScheme.PrimaryColor : ColorScheme.ColorSwatches[_colorStyle].PrimaryColor;
            };
        }

        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
    }
}
