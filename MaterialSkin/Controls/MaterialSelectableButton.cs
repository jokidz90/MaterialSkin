using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialSelectableButton : MaterialButton
    {
        public ButtonSelectorMode SelectorMode { set; get; }
        public bool HideEmptyValue { set; get; }
        public bool HideCaption { set; get; }
        public ControlSize ItemSize { set; get; }

        public event ItemSelectHandler ValueChanged;

        private bool _isMultiSelect = false;
        public bool IsMultiSelect { get => _isMultiSelect; set => _isMultiSelect = value; }

        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public List<object> Items { get => _items; set => _items = value; }
        private List<object> _items = new List<object>();

        public string ValueMember { get; set; }
        public string DisplayMember { get; set; }

        public object DataSource
        {
            set
            {
                try
                {
                    if (value.GetType().GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
                        _items = ((IEnumerable<object>)value).ToList();
                    else if (value is DataTable || value is DataSet)
                    {
                        DataTable dt = null;
                        if (value is DataTable)
                            dt = (DataTable)value;
                        else
                            dt = ((DataSet)value).Tables[0];

                        _items = new List<object>();
                        var dynamicList = new List<dynamic>();

                        foreach (DataRow dr in dt.Rows)
                        {
                            dynamic myObj = new ExpandoObject();
                            var newListItem = myObj as IDictionary<string, object>;
                            for (int i = 0; i < dt.Columns.Count; i++)
                                newListItem[dr.Table.Columns[i].ColumnName] = dr[i];
                            _items.Add(newListItem);
                        }
                    }
                    else
                        _items = new List<object>();


                }
                catch (Exception ex)
                {
                    _items = new List<object>();
                }
            }
            get
            {
                return _items;
            }
        }

        private string _caption = "";
        public string Caption
        {
            get { return _caption; }
            set
            {
                _caption = value;
                if (_selectedIndices.Count == 0)
                    Text = _caption;
                TextSize = CreateGraphics().MeasureString(_caption.ToUpper(), SkinManager.ROBOTO_MEDIUM_11);
                if (AutoSize)
                    Size = GetPreferredSize();
            }
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                TextSize = CreateGraphics().MeasureString(_caption.ToUpper(), SkinManager.ROBOTO_MEDIUM_11);
                if (AutoSize)
                    Size = GetPreferredSize();
                Invalidate();
            }
        }

        public object SelectedValue
        {
            get
            {
                List<object> selecteds = new List<object>();
                for (int i = 0; i < _items.Count; i++)
                {
                    if (!_selectedIndices.Contains(i))
                        continue;

                    selecteds.Add(_items[i].GetProperty(ValueMember));
                }

                object obj = selecteds;
                if (!_isMultiSelect)
                    obj = selecteds.FirstOrDefault();

                return obj;
            }
            set
            {
                if (value == null)
                {
                    SelectedIndices = new List<int>();
                    return;
                }

                List<object> selValues = value.ConvertToList();
                if (selValues == null)
                {
                    selValues = new List<object>();
                    selValues.Add(value);
                }

                var selIndices = new List<int>();
                for (int i = 0; i < _items.Count; i++)
                {
                    foreach (var obj in selValues)
                    {
                        if (obj.ToString() != _items[i].GetProperty(ValueMember).ToString())
                            continue;

                        if (selIndices.Contains(i))
                            continue;

                        selIndices.Add(i);
                    }
                }

                if (IsMultiSelect)
                    SelectedIndices = selIndices;
                else
                {
                    int selIndex = -1;
                    if (selIndices.Count > 0)
                        selIndex = selIndices[selIndices.Count - 1];
                    SelectedIndex = selIndex;
                }
            }
        }

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
                int sel = value;
                if (value < 0 || value >= _items.Count)
                    sel = -1;

                if (!IsMultiSelect)
                    _selectedIndices.Clear();
                if (sel >= 0 && !_selectedIndices.Contains(sel))
                    _selectedIndices.Add(sel);
                SelectedIndices = _selectedIndices;
            }
        }

        private List<int> _selectedIndices = new List<int>();
        public List<int> SelectedIndices
        {
            get => _selectedIndices;
            set
            {
                _selectedIndices = value;
                if (_selectedIndices.Count == 0)
                    Text = Caption;
                else
                {
                    List<string> selecteds = new List<string>();
                    for (int i = 0; i < _items.Count; i++)
                    {
                        if (!_selectedIndices.Contains(i))
                            continue;

                        selecteds.Add(_items[i].GetProperty(DisplayMember).ToString());
                    }

                    Text = string.Join(",", selecteds);
                }
                if (ValueChanged != null)
                {
                    ValueChanged(this, new ItemSelectArgs
                    {
                        SelectedIndex = SelectedIndex,
                        SelectedIndices = SelectedIndices,
                        Text = Text,
                        SelectedValue = SelectedValue
                    });
                }
            }
        }

        private Dictionary<int, ColorType> _itemsColor = new Dictionary<int, ColorType>();
        public void SetItemColor(int index, ColorType type)
        {
            if (_itemsColor.ContainsKey(index))
                _itemsColor[index] = type;
            else
                _itemsColor.Add(index, type);
        }

        public MaterialSelectableButton()
        {
            SelectorMode = ButtonSelectorMode.POPUP;
            ItemSize = ControlSize.NORMAL;
            Click += MaterialSelectableButton_Click;
        }

        private void MaterialSelectableButton_Click(object sender, EventArgs e)
        {
            if (SelectorMode == ButtonSelectorMode.POPUP)
            {
                var frm = new MaterialSelectableButtonForm();
                frm.HideEmptyValue = HideEmptyValue;
                frm.Caption = HideCaption ? "" : _caption;
                frm.ItemSize = ItemSize;
                frm.ValueMember = ValueMember;
                frm.DisplayMember = DisplayMember;
                frm.Items = _items;
                frm.IsMultiSelect = IsMultiSelect;
                frm.SelectedIndices = SelectedIndices;
                frm.UseFlatStyle = UseFlatStyle;
                frm.Size = MaterialSelectableButton.CalculatePopUpSize(ItemSize, _items.Count, IsMultiSelect, HideEmptyValue, HideCaption, out int itemHeight, out int itemWidth);
                frm.ItemHeight = itemHeight;
                frm.ItemWidth = itemWidth;
                frm.ItemsColor = _itemsColor;
                var res = frm.ShowFormDialog();
                if (res == DialogResult.OK)
                    SelectedIndices = frm.SelectedIndices;
            }
            else
            {
                int selIndex = -1;
                if (_selectedIndices != null && _selectedIndices.Count > 0)
                    selIndex = _selectedIndices[_selectedIndices.Count - 1];
                selIndex++;
                if (selIndex >= _items.Count)
                    selIndex = HideEmptyValue ? 0 : -1;
                SelectedIndex = selIndex;
            }

        }

        public static Size CalculatePopUpSize(ControlSize itemSize, int itemCount, bool isMultiSelect, bool hideEmptyValue, bool hideCaption, out int btnItemHeight, out int btnItemWidth)
        {
            int maxRow = 5;
            int maxCol = 4;
            Size size = new Size(0, 0);

            btnItemHeight = 40;
            if (itemSize == ControlSize.SMALL)
                btnItemHeight = 34;
            else if (itemSize == ControlSize.LARGE)
                btnItemHeight = 72;
            btnItemWidth = btnItemHeight * 4;

            int itemWidth = btnItemWidth + 5; //add left margin
            int itemHeight = btnItemHeight + 5; //add top margin

            if (isMultiSelect)
                itemCount += 2;//add select all & select none
            else if (!hideEmptyValue)
                itemCount += 1; //add select none

            if (itemCount < maxCol)
            {
                size.Width = itemWidth + 10;//add right margin
                size.Height = (itemHeight * itemCount);
            }
            else
            {
                size.Width = (itemWidth * maxCol) + 10;

                int rowNo = Convert.ToInt32(Math.Ceiling((Convert.ToDecimal(itemCount) / Convert.ToDecimal(maxCol))));

                if (rowNo > maxRow)
                {
                    size.Height = (itemHeight * maxRow);//add bottom margin
                    size.Width = size.Width + 15;//add scroll width
                }
                else
                    size.Height = (itemHeight * rowNo);//add bottom margin
            }

            size.Height = size.Height + 55;//add footer
            if (!hideCaption)
                size.Height = size.Height + 45;//add header

            return size;
        }
    }


    public enum ButtonSelectorMode
    {
        POPUP,
        ROTARY
    }
}
