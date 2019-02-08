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

        public int SelectedIndex
        {
            get
            {
                if (_selectedIndices.Count == 0)
                    return -1;
                else
                    return _selectedIndices[_selectedIndices.Count - 1];
            }
            set
            {
                if (!IsMultiSelect)
                    _selectedIndices = new List<int>();
                int sel = value;
                if (value < 0)
                    sel = -1;

                if (sel >= 0 && !_selectedIndices.Contains(sel))
                    _selectedIndices.Add(sel);
            }
        }

        public List<int> SelectedIndices { get => _selectedIndices; set => _selectedIndices = value; }
        private List<int> _selectedIndices = new List<int>();

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
            if (IsMultiSelect)
            {
                var ctrlSelectAll = InitButton(-1, "SELECT ALL", "SELECT ALL");
                flpMain.Controls.Add(ctrlSelectAll);
                ctrlSelectAll.Dock = DockStyle.Top;
                ctrlSelectAll.BringToFront();

                var ctrlSelectNone = InitButton(-2, "CLEAR SELECTION", "CLEAR SELECTION");
                flpMain.Controls.Add(ctrlSelectNone);
                ctrlSelectNone.Dock = DockStyle.Top;
                ctrlSelectNone.BringToFront();
            }

            Control selectedCtrl = null;
            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                MaterialFlatButtonSelectable ctrl = InitButton(i, item.ToString(), item);
                flpMain.Controls.Add(ctrl);
                ctrl.Dock = DockStyle.Top;
                ctrl.BringToFront();

                if (ctrl.IsSelected)
                    selectedCtrl = ctrl;
            }

            if(selectedCtrl == null && flpMain.Controls.Count > 0)
                selectedCtrl = flpMain.Controls[flpMain.Controls.Count - 1];
            if (selectedCtrl != null)
                selectedCtrl.Select();
        }

        private MaterialFlatButtonSelectable InitButton(int index, string text, object value)
        {
            MaterialFlatButtonSelectable ctrl = new MaterialFlatButtonSelectable();
            ctrl.Name = _id.ToString().ToUpper() + "_" + index;
            ctrl.IsSelected = _selectedIndices.Contains(index);
            ctrl.AutoSize = false;
            ctrl.Width = this.Width - 35;
            ctrl.Height = _itemHeight <= 0 ? 30 : _itemHeight;
            ctrl.Text = text;
            ctrl.Tag = value;
            ctrl.Alignment = System.Drawing.StringAlignment.Near;
            ctrl.Click += Ctrl_Click;
            ctrl.Dock = DockStyle.Top;
            ctrl.BringToFront();

            return ctrl;
        }

        private void Ctrl_Click(object sender, EventArgs e)
        {
            MaterialFlatButtonSelectable ctrl = (MaterialFlatButtonSelectable)sender;
            int index = Convert.ToInt32(ctrl.Name.Replace(_id.ToString().ToUpper() + "_", ""));
            if (index == -1)
            {
                _selectedIndices = new List<int>();
                for (int i = 0; i < flpMain.Controls.Count; i++)
                {
                    var btn = (MaterialFlatButtonSelectable)flpMain.Controls[i];
                    int ctrlIndex = Convert.ToInt32(btn.Name.Replace(_id.ToString().ToUpper() + "_", ""));
                    if (ctrlIndex < 0)
                        continue;
                    btn.IsSelected = true;
                    _selectedIndices.Add(i);
                }
            }
            else if (index == -2)
            {
                for (int i = 0; i < flpMain.Controls.Count; i++)
                {
                    var btn = (MaterialFlatButtonSelectable)flpMain.Controls[i];
                    btn.IsSelected = false;
                }
                _selectedIndices = new List<int>();
            }
            else
            {
                if (!IsMultiSelect)
                {
                    for (int i = 0; i < flpMain.Controls.Count; i++)
                    {
                        var btn = (MaterialFlatButtonSelectable)flpMain.Controls[i];
                        btn.IsSelected = false;
                    }
                }
                ctrl.IsSelected = !ctrl.IsSelected;
                if (ctrl.IsSelected)
                    SelectedIndex = index;
                else
                    _selectedIndices.RemoveAll(o => o == index);
            }

            if (ItemSelected != null)
            {
                ItemSelected(this, new ItemSelectArgs
                {
                    SelectedIndex = SelectedIndex,
                    SelectedIndices = SelectedIndices
                });
            }
        }
    }

    public delegate void ItemSelectHandler(object sender, ItemSelectArgs e);

    public class ItemSelectArgs : EventArgs
    {
        public int SelectedIndex { set; get; }
        public List<int> SelectedIndices { set; get; }
        public string SelectedText { set; get; }
        public object SelectedValue { set; get; }
    }
}
