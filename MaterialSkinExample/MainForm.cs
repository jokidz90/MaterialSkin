using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public MainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = ColorScheme.ColorSwatches[ColorType.PRIMARY];

            var dataSrc1 = new DataTable();
            var dataSrc2 = new List<object>();

            dataSrc1.Columns.Add("ItemID", typeof(int));
            dataSrc1.Columns.Add("ItemName", typeof(string));
            dataSrc1.Columns.Add("ItemCategory", typeof(string));

            for (int i = 0; i < 10; i++)
            {
                var newRow = dataSrc1.NewRow();
                newRow["ItemID"] = i + 10;
                newRow["ItemName"] = "Item #" + (i + 1);
                newRow["ItemCategory"] = Guid.NewGuid().ToString();
                dataSrc1.Rows.Add(newRow);


                var newObj = new
                {
                    CategoryID = i,
                    CategoryName = "Category #" + (i + 1)
                };
                dataSrc2.Add(newObj);
            }

            dropDown1.DataSource = dataSrc1;
            dropDown2.DataSource = dataSrc2;

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

	    private int colorSchemeIndex;
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
	        colorSchemeIndex++;
	        if (colorSchemeIndex >= ColorScheme.ColorSwatches.Count)
                colorSchemeIndex = 0;
            materialSkinManager.ColorScheme = ColorScheme.ColorSwatches[((ColorType)colorSchemeIndex)];
        }

        private void materialCheckBox7_Click(object sender, EventArgs e)
        {
            grpDisabled.Enabled = !grpDisabled.Enabled;
            grpDisabledDropDown.Enabled = !grpDisabledDropDown.Enabled;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        private void dropDown1_ValueChanged(object sender, ItemSelectArgs e)
        {
            if (e.SelectedValue == null)
                formDropwDown1.Text = "Drop Down";
            else
                formDropwDown1.Text = e.SelectedValue.ToString();
        }

        private void dropDown2_ValueChanged(object sender, ItemSelectArgs e)
        {
            if (e.SelectedValue == null)
                formDropwDown2.Text = "Multi Select Drop Down";
            else
            {
                var selObj = ((List<object>)e.SelectedValue).Select(o => o.ToString()).ToList();
                formDropwDown2.Text = string.Join(",", selObj);
            }
        }
    }
}
