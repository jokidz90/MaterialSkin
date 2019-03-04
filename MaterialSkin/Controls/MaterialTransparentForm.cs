using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class MaterialTransparentForm : Form
    {
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        public MaterialTransparentForm()
        {
            InitializeComponent();
            //this.BackColor = SkinManager.ColorScheme.LightPrimaryColor;
        }
    }
}
