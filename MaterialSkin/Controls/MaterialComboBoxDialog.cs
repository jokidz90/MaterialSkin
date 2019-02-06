using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkin.Controls
{
    public partial class MaterialComboBoxDialog : MaterialFormDialog
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MaterialComboBoxDialog()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }
    }
}
