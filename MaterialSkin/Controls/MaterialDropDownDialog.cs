using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkin.Controls
{
    public partial class MaterialDropDownDialog : MaterialFormDialog
    {
        public event ItemSelectHandler ItemSelected;

        public int ItemHeight { get => _itemHeight; set => _itemHeight = value; }
        private int _itemHeight = 30;

        public bool IsMultiSelect { set; get; }
        public List<object> Items = new List<object>();

        public string SelectedText { set; get; }
        public object SelectedValue { set; get; }
        public int SelectedIndex { get => _selectedIndex; set => _selectedIndex = value; }
        private int _selectedIndex = -1;

        private readonly MaterialSkinManager materialSkinManager;
        private Guid _id = Guid.Empty;

        public MaterialDropDownDialog()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            _id = Guid.NewGuid();
        }

        private void MaterialComboBoxDialog_Load(object sender, EventArgs e)
        {
            flpMain.Controls.Clear();

            for (int i = Items.Count - 1; i >= 0; i--)
            {
                var item = Items[i];
                MaterialFlatButton ctrl = new MaterialFlatButton();
                ctrl.Name = _id.ToString().ToUpper() + "_" + ((Items.Count - 1) - i);
                ctrl.AutoSize = false;
                ctrl.Width = this.Width - 35;
                ctrl.Height = _itemHeight <= 0 ? 30 : _itemHeight;
                ctrl.Text = item.ToString();
                ctrl.Tag = item;
                ctrl.Alignment = System.Drawing.StringAlignment.Near;
                ctrl.Click += Ctrl_Click;
                flpMain.Controls.Add(ctrl);
                ctrl.Dock = DockStyle.Top;
            }

            if (flpMain.Controls.Count > 0)
            {
                var ctrl = flpMain.Controls[flpMain.Controls.Count - 1];
                ctrl.Select();
            }
        }

        private void Ctrl_Click(object sender, EventArgs e)
        {
            MaterialFlatButton ctrl = (MaterialFlatButton)sender;

            SelectedIndex = Convert.ToInt32(ctrl.Name.Replace(_id.ToString().ToUpper() + "_", ""));
            SelectedValue = ctrl.Tag;
            SelectedText = ctrl.Text;

            if (ItemSelected != null)
            {
                ItemSelected(this, new ItemSelectArgs
                {
                    SelectedIndex = SelectedIndex,
                    SelectedValue = SelectedValue,
                    SelectedText = SelectedText
                });
            }
        }
    }

    public delegate void ItemSelectHandler(object sender, ItemSelectArgs e);

    public class ItemSelectArgs : EventArgs
    {
        public List<object> SelectedItems { set; get; }
        public List<string> SelectedTexts { set; get; }
        public List<object> SelectedValues { set; get; }

        public int SelectedIndex { set; get; }
        public string SelectedText { set; get; }
        public object SelectedValue { set; get; }
    }
}
