using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialLabel : Label, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        private Font _font = null;
        private ControlSize _controlSize = ControlSize.NORMAL;
        public ControlSize ControlSize
        {
            set
            {
                _controlSize = value;
                if (_controlSize == ControlSize.SMALL)
                    _font = SkinManager.ROBOTO_MEDIUM_8;
                else if (_controlSize == ControlSize.LARGE)
                    _font = SkinManager.ROBOTO_MEDIUM_16;
                else
                    _font = SkinManager.ROBOTO_MEDIUM_11;
            }
            get
            {
                return _controlSize;
            }
        }

        public MaterialLabel()
        {
            ControlSize = ControlSize.NORMAL;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Font = _font;
            ForeColor = SkinManager.GetPrimaryTextColor();
            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
        }
    }
}
