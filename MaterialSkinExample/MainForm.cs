using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Diagnostics;
using System.Drawing;

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

            for (int i = 0; i < 15; i++)
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
            dropDown3.DataSource = new string[] { "Option 1", "Option 2", "Option 3", "Option 4", "Option 5" };

            dropDown1.SelectedValue = 12;
            dropDown2.SelectedValue = new object[] { 1, 2, 3 };
            dropDown3.SelectedIndex = 111;

            btnSelectable1.DataSource = dataSrc1;
            btnDineInTakeAway.DataSource = new string[] { "DINE IN", "TAKE AWAY", "DELIVERY" };
            btnDineInTakeAway.SetItemColor(0, ColorType.GREEN);
            btnDineInTakeAway.SetItemColor(1, ColorType.SUCCESS);
            foreach (IconType ico in Enum.GetValues(typeof(IconType)))
            {
                var btn = new MaterialButton();
                btn.Name = ico.ToString();
                //btn.Text = ico.ToString();
                btn.IconType = ico;
                flpIcon.Controls.Add(btn);
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("No", typeof(int));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Qty", typeof(int));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("DGCheck", typeof(bool));
            Random rand = new Random();
            int maxRow = rand.Next(10, 100);
            for (int i = 0; i < maxRow; i++)
            {
                var newRow = dt.NewRow();
                newRow["No"] = (i + 1);

                newRow["Product"] = "Product #" + (i + 1);
                if (i % 5 == 0)
                {
                    string productName = "Product #" + (i + 1);
                    productName += Environment.NewLine;
                    productName += "This is sample of multiline product";
                    for (int j = 0; j < (i / 5); j++)
                    {
                        productName += Environment.NewLine;
                        productName += "Line " + (j + 1);
                    }
                    newRow["Product"] = productName;
                }
                
                newRow["Qty"] = rand.Next(1, 10);
                newRow["Price"] = rand.Next(1, 30);
                newRow["Amount"] = ((int)newRow["Qty"]) * ((decimal)newRow["Price"]);
                newRow["DGCheck"] = rand.Next(1, 10) % 3 == 0;
                dt.Rows.Add(newRow);
            }

            gView.DataSource = dt;
            //Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            //int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            //int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            //this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            //this.Size = new Size(w, h);
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private int colorSchemeIndex = 1;
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
            frmDate.Enabled = !frmDate.Enabled;
            frmMultiLine.Enabled = !frmMultiLine.Enabled;
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

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Debug.Write(WindowState);
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void btnDlgMessage_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("This is message");
        }

        private void btnDlgMsgWithHeader_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("This is message","Message");
        }

        private void btnDlgInformation_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("This is information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDlgWarning_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("This is warning", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDlgError_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("This is error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {

        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            //var res = MaterialMessageBox.ShowSelector("Delivery/Take Away", new List<object>{ "Delivery", "Take Away" }, out object selectedValue);
            //materialButton8.Text = selectedValue + "";
            var res = MaterialMessageBox.ShowNumericSelector("ENTER PRICE", materialButton8.Text.GetDecimalValue(), false, out decimal price);
            materialButton8.Text = price + "";
        }

        private void materialSelectableButton2_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            var res = MaterialMessageBox.ShowIntegerSelector("ENTER QTY", materialButton1.Text.GetInt32Value(), false, out int qty);
            materialButton1.Text = qty + "";
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            var res = MaterialMessageBox.ShowTextSelector("ENTER NAME", materialButton9.Text, false, out string name);
            materialButton9.Text = name + "";
        }
    }
}
