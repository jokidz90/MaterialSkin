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
    public partial class MaterialSelectableButtonForm : MaterialFormDialog
    {
        public string Caption
        {
            set
            {
                this.Text = value;
            }
            get
            {
                return this.Text;
            }
        }
        public bool HideEmptyValue { set; get; }
        public ControlSize ItemSize { set; get; }
        public bool UseFlatStyle { set; get; }
        public string ValueMember { get; set; }
        public string DisplayMember { get; set; }

        public int ItemHeight { get; set; }
        public int ItemWidth { get; set; }
        public Dictionary<int, ColorType> ItemsColor { get; set; }

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

        public MaterialSelectableButtonForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            _id = Guid.NewGuid();
        }

        private void MaterialSelectableButtonForm_Load(object sender, EventArgs e)
        {
            pnlOk.Visible = IsMultiSelect;
            if (pnlOk.Visible)
            {
                pnlOk.Width = Convert.ToInt32(pnlFooter.Width * 0.5m);
                pnlCancel.Width = Convert.ToInt32(pnlFooter.Width * 0.5m);
            }
            PopulateItemList();
        }

        private void PopulateItemList()
        {
            flpMain.Controls.Clear();
            if (IsMultiSelect)
            {
                var ctrlSelectAll = InitButton(-1, "SELECT ALL", "SELECT ALL");
                ctrlSelectAll.UseFlatStyle = true;
                ctrlSelectAll.IsSelected = null;
                ctrlSelectAll.IconType = IconType.DONE_ALL;
                ctrlSelectAll.Alignment = System.Drawing.StringAlignment.Center;
                flpMain.Controls.Add(ctrlSelectAll);
                ctrlSelectAll.Dock = DockStyle.Top;
                ctrlSelectAll.BringToFront();

                var ctrlSelectNone = InitButton(-2, "CLEAR SELECTION", "CLEAR SELECTION");
                ctrlSelectNone.UseFlatStyle = true;
                ctrlSelectNone.Alignment = System.Drawing.StringAlignment.Center;
                ctrlSelectNone.IsSelected = null;
                ctrlSelectNone.IconType = IconType.REMOVE;
                flpMain.Controls.Add(ctrlSelectNone);
                ctrlSelectNone.Dock = DockStyle.Top;
                ctrlSelectNone.BringToFront();
            }
            else
            {
                if (!HideEmptyValue)
                {
                    var ctrlSelectNone = InitButton(-2, "NONE", "");
                    ctrlSelectNone.UseFlatStyle = true;
                    ctrlSelectNone.Alignment = System.Drawing.StringAlignment.Center;
                    flpMain.Controls.Add(ctrlSelectNone);
                    ctrlSelectNone.Dock = DockStyle.Top;
                    ctrlSelectNone.BringToFront();
                }
            }

            Control selectedCtrl = null;
            for (int i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                string itemText = item.GetProperty(DisplayMember).ToString();
                object itemValue = item.GetProperty(ValueMember);

                MaterialButton ctrl = InitButton(i, itemText, itemValue);
                flpMain.Controls.Add(ctrl);
                //ctrl.Dock = DockStyle.Top;
                //ctrl.BringToFront();

                if (ctrl.IsSelected.GetValueOrDefault(false))
                    selectedCtrl = ctrl;
                if (ItemsColor != null && ItemsColor.ContainsKey(i))
                    ctrl.ColorStyle = ItemsColor[i];
            }
            SetItemIcon();
            if (selectedCtrl == null && flpMain.Controls.Count > 0)
                selectedCtrl = flpMain.Controls[flpMain.Controls.Count - 1];
            if (selectedCtrl != null)
                selectedCtrl.Select();
        }

        private MaterialButton InitButton(int index, string text, object value)
        {
            MaterialButton ctrl = new MaterialButton();
            ctrl.Name = _id.ToString().ToUpper() + "_" + index;
            ctrl.IsSelected = _selectedIndices.Contains(index);
            ctrl.ControlSize = ItemSize;
            ctrl.AutoSize = false;
            ctrl.Width = ItemWidth;
            ctrl.Height = ItemHeight;
            ctrl.Text = text;
            ctrl.Tag = value;
            ctrl.UseFlatStyle = UseFlatStyle;
            ctrl.Margin = new Padding(5, 5, 0, 0);
            ctrl.Alignment = System.Drawing.StringAlignment.Center;
            ctrl.Click += Ctrl_Click;
            ctrl.Dock = DockStyle.Top;
            ctrl.BringToFront();

            return ctrl;
        }

        private void Ctrl_Click(object sender, EventArgs e)
        {
            MaterialButton ctrl = (MaterialButton)sender;
            int index = Convert.ToInt32(ctrl.Name.Replace(_id.ToString().ToUpper() + "_", ""));
            if (index == -1)
            {
                _selectedIndices = new List<int>();
                for (int i = 0; i < flpMain.Controls.Count; i++)
                {
                    var btn = (MaterialButton)flpMain.Controls[i];
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
                    var btn = (MaterialButton)flpMain.Controls[i];
                    int ctrlIndex = Convert.ToInt32(btn.Name.Replace(_id.ToString().ToUpper() + "_", ""));
                    if (ctrlIndex < 0)
                        continue;
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
                        var btn = (MaterialButton)flpMain.Controls[i];
                        int ctrlIndex = Convert.ToInt32(btn.Name.Replace(_id.ToString().ToUpper() + "_", ""));
                        if (ctrlIndex < 0)
                            continue;
                        btn.IsSelected = false;
                    }
                }
                ctrl.IsSelected = !ctrl.IsSelected;
                if (ctrl.IsSelected.GetValueOrDefault(false))
                    SelectedIndex = index;
                else
                    _selectedIndices.RemoveAll(o => o == index);
            }
            SetItemIcon();

            if (!IsMultiSelect)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SetItemIcon()
        {
            for (int i = 0; i < flpMain.Controls.Count; i++)
            {
                var btn = (MaterialButton)flpMain.Controls[i];
                int ctrlIndex = Convert.ToInt32(btn.Name.Replace(_id.ToString().ToUpper() + "_", ""));
                if (ctrlIndex < 0)
                    continue;
                if (IsMultiSelect)
                    btn.IconType = btn.IsSelected.GetValueOrDefault(false) ? IconType.CHECK_BOX : IconType.CHECK_BOX_OUTLINE_BLANK;
                else
                    btn.IconType = btn.IsSelected.GetValueOrDefault(false) ? IconType.CHECK_BOX : IconType.NONE;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
