using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkinExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tpControls = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFormGroup7 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialDateRangePicker2 = new MaterialSkin.Controls.MaterialDateRangePicker();
            this.materialFormGroup3 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialDateRangePicker1 = new MaterialSkin.Controls.MaterialDateRangePicker();
            this.materialFormGroup6 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialDatePicker2 = new MaterialSkin.Controls.MaterialDatePicker();
            this.frmDate = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialDatePicker1 = new MaterialSkin.Controls.MaterialDatePicker();
            this.formDropwDown2 = new MaterialSkin.Controls.MaterialFormGroup();
            this.dropDown2 = new MaterialSkin.Controls.MaterialDropDown();
            this.grpDisabledDropDown = new MaterialSkin.Controls.MaterialFormGroup();
            this.dropDown3 = new MaterialSkin.Controls.MaterialDropDown();
            this.formDropwDown1 = new MaterialSkin.Controls.MaterialFormGroup();
            this.dropDown1 = new MaterialSkin.Controls.MaterialDropDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frmMultiLine = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialRichText1 = new MaterialSkin.Controls.MaterialRichText();
            this.materialFormGroup5 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialRadioButton7 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton6 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialFormGroup4 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialCheckBox8 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFormGroup2 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialCheckBox7 = new MaterialSkin.Controls.MaterialCheckBox();
            this.grpDisabled = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFormGroup1 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpIcon = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gView = new MaterialSkin.Controls.MaterialGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialPanel3 = new MaterialSkin.Controls.MaterialPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialPanel2 = new MaterialSkin.Controls.MaterialPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton8 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton10 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton11 = new MaterialSkin.Controls.MaterialButton();
            this.materialRaisedButton12 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.item1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem1ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.subItem2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.disabledItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.item2ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.item3ToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.materialPanel1 = new MaterialSkin.Controls.MaterialPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialTabControl1.SuspendLayout();
            this.tpControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.materialFormGroup7.SuspendLayout();
            this.materialFormGroup3.SuspendLayout();
            this.materialFormGroup6.SuspendLayout();
            this.frmDate.SuspendLayout();
            this.formDropwDown2.SuspendLayout();
            this.grpDisabledDropDown.SuspendLayout();
            this.formDropwDown1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.frmMultiLine.SuspendLayout();
            this.materialFormGroup5.SuspendLayout();
            this.materialFormGroup4.SuspendLayout();
            this.materialFormGroup2.SuspendLayout();
            this.grpDisabled.SuspendLayout();
            this.materialFormGroup1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.materialPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.materialPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.materialContextMenuStrip1.SuspendLayout();
            this.materialPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(0, 0);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2160, 2);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialButton1
            // 
            this.materialButton1.Alignment = System.Drawing.StringAlignment.Center;
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = true;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.Maroon;
            this.materialButton1.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialButton1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialButton1.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.IconType = MaterialSkin.IconType.ACCOUNT_CIRCLE;
            this.materialButton1.IsSelected = false;
            this.materialButton1.Location = new System.Drawing.Point(1646, 10);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Primary = true;
            this.materialButton1.Size = new System.Drawing.Size(225, 40);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Change Theme";
            this.materialButton1.UseFlatStyle = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(2160, 79);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tpControls);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 143);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(2160, 1137);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tpControls
            // 
            this.tpControls.Controls.Add(this.tableLayoutPanel1);
            this.tpControls.Location = new System.Drawing.Point(4, 29);
            this.tpControls.Margin = new System.Windows.Forms.Padding(0);
            this.tpControls.Name = "tpControls";
            this.tpControls.Size = new System.Drawing.Size(2152, 1104);
            this.tpControls.TabIndex = 5;
            this.tpControls.Text = "Form Controls";
            this.tpControls.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2152, 1104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialFormGroup7);
            this.panel2.Controls.Add(this.materialFormGroup3);
            this.panel2.Controls.Add(this.materialFormGroup6);
            this.panel2.Controls.Add(this.frmDate);
            this.panel2.Controls.Add(this.formDropwDown2);
            this.panel2.Controls.Add(this.grpDisabledDropDown);
            this.panel2.Controls.Add(this.formDropwDown1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1076, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 1104);
            this.panel2.TabIndex = 1;
            // 
            // materialFormGroup7
            // 
            this.materialFormGroup7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup7.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup7.Controls.Add(this.materialDateRangePicker2);
            this.materialFormGroup7.Depth = 0;
            this.materialFormGroup7.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup7.IsSelected = false;
            this.materialFormGroup7.Location = new System.Drawing.Point(0, 600);
            this.materialFormGroup7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialFormGroup7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup7.Name = "materialFormGroup7";
            this.materialFormGroup7.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup7.Size = new System.Drawing.Size(1076, 100);
            this.materialFormGroup7.TabIndex = 8;
            this.materialFormGroup7.TabStop = false;
            this.materialFormGroup7.Text = "Date Range Picker With Time";
            // 
            // materialDateRangePicker2
            // 
            this.materialDateRangePicker2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialDateRangePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialDateRangePicker2.DateFormat = "ddd, dd MMM yyyy";
            this.materialDateRangePicker2.Depth = 0;
            this.materialDateRangePicker2.DisplayRangeText = false;
            this.materialDateRangePicker2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDateRangePicker2.DropDownHeight = 300;
            this.materialDateRangePicker2.DropDownWidth = -1;
            this.materialDateRangePicker2.EndValue = new System.DateTime(2019, 2, 15, 16, 11, 11, 911);
            this.materialDateRangePicker2.Hint = null;
            this.materialDateRangePicker2.Location = new System.Drawing.Point(3, 31);
            this.materialDateRangePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialDateRangePicker2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDateRangePicker2.Name = "materialDateRangePicker2";
            this.materialDateRangePicker2.ShowTime = true;
            this.materialDateRangePicker2.Size = new System.Drawing.Size(1070, 32);
            this.materialDateRangePicker2.StartValue = new System.DateTime(2019, 2, 15, 16, 11, 11, 911);
            this.materialDateRangePicker2.TabIndex = 0;
            this.materialDateRangePicker2.TabStop = false;
            this.materialDateRangePicker2.Text = "materialDateRangePicker2";
            // 
            // materialFormGroup3
            // 
            this.materialFormGroup3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup3.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup3.Controls.Add(this.materialDateRangePicker1);
            this.materialFormGroup3.Depth = 0;
            this.materialFormGroup3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup3.IsSelected = false;
            this.materialFormGroup3.Location = new System.Drawing.Point(0, 500);
            this.materialFormGroup3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialFormGroup3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup3.Name = "materialFormGroup3";
            this.materialFormGroup3.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup3.Size = new System.Drawing.Size(1076, 100);
            this.materialFormGroup3.TabIndex = 7;
            this.materialFormGroup3.TabStop = false;
            this.materialFormGroup3.Text = "Date Range Picker";
            // 
            // materialDateRangePicker1
            // 
            this.materialDateRangePicker1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialDateRangePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialDateRangePicker1.DateFormat = "ddd, dd MMM yyyy";
            this.materialDateRangePicker1.Depth = 0;
            this.materialDateRangePicker1.DisplayRangeText = false;
            this.materialDateRangePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDateRangePicker1.DropDownHeight = 300;
            this.materialDateRangePicker1.DropDownWidth = -1;
            this.materialDateRangePicker1.EndValue = new System.DateTime(2019, 2, 15, 16, 11, 11, 911);
            this.materialDateRangePicker1.Hint = null;
            this.materialDateRangePicker1.Location = new System.Drawing.Point(3, 31);
            this.materialDateRangePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialDateRangePicker1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDateRangePicker1.Name = "materialDateRangePicker1";
            this.materialDateRangePicker1.ShowTime = false;
            this.materialDateRangePicker1.Size = new System.Drawing.Size(1070, 32);
            this.materialDateRangePicker1.StartValue = new System.DateTime(2019, 2, 15, 16, 11, 11, 911);
            this.materialDateRangePicker1.TabIndex = 0;
            this.materialDateRangePicker1.TabStop = false;
            this.materialDateRangePicker1.Text = "materialDateRangePicker1";
            // 
            // materialFormGroup6
            // 
            this.materialFormGroup6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup6.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup6.Controls.Add(this.materialDatePicker2);
            this.materialFormGroup6.Depth = 0;
            this.materialFormGroup6.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup6.IsSelected = false;
            this.materialFormGroup6.Location = new System.Drawing.Point(0, 400);
            this.materialFormGroup6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialFormGroup6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup6.Name = "materialFormGroup6";
            this.materialFormGroup6.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup6.Size = new System.Drawing.Size(1076, 100);
            this.materialFormGroup6.TabIndex = 6;
            this.materialFormGroup6.TabStop = false;
            this.materialFormGroup6.Text = "Date & Time Picker";
            // 
            // materialDatePicker2
            // 
            this.materialDatePicker2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialDatePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialDatePicker2.DateFormat = "ddd, dd MMM yyyy";
            this.materialDatePicker2.Depth = 0;
            this.materialDatePicker2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDatePicker2.DropDownHeight = 300;
            this.materialDatePicker2.DropDownWidth = -1;
            this.materialDatePicker2.Hint = null;
            this.materialDatePicker2.Location = new System.Drawing.Point(3, 31);
            this.materialDatePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialDatePicker2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDatePicker2.Name = "materialDatePicker2";
            this.materialDatePicker2.ShowTime = true;
            this.materialDatePicker2.Size = new System.Drawing.Size(1070, 32);
            this.materialDatePicker2.TabIndex = 0;
            this.materialDatePicker2.TabStop = false;
            this.materialDatePicker2.Text = "materialDatePicker2";
            this.materialDatePicker2.Value = new System.DateTime(2019, 2, 10, 14, 33, 19, 160);
            // 
            // frmDate
            // 
            this.frmDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmDate.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.frmDate.Controls.Add(this.materialDatePicker1);
            this.frmDate.Depth = 0;
            this.frmDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmDate.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.frmDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.frmDate.IsSelected = false;
            this.frmDate.Location = new System.Drawing.Point(0, 300);
            this.frmDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.frmDate.Name = "frmDate";
            this.frmDate.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.frmDate.Size = new System.Drawing.Size(1076, 100);
            this.frmDate.TabIndex = 5;
            this.frmDate.TabStop = false;
            this.frmDate.Text = "Date Picker";
            // 
            // materialDatePicker1
            // 
            this.materialDatePicker1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialDatePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialDatePicker1.DateFormat = "ddd, dd MMM yyyy";
            this.materialDatePicker1.Depth = 0;
            this.materialDatePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDatePicker1.DropDownHeight = 300;
            this.materialDatePicker1.DropDownWidth = -1;
            this.materialDatePicker1.Hint = null;
            this.materialDatePicker1.Location = new System.Drawing.Point(3, 31);
            this.materialDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialDatePicker1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDatePicker1.Name = "materialDatePicker1";
            this.materialDatePicker1.ShowTime = false;
            this.materialDatePicker1.Size = new System.Drawing.Size(1070, 32);
            this.materialDatePicker1.TabIndex = 0;
            this.materialDatePicker1.TabStop = false;
            this.materialDatePicker1.Text = "materialDatePicker1";
            this.materialDatePicker1.Value = new System.DateTime(2019, 2, 10, 14, 33, 19, 160);
            // 
            // formDropwDown2
            // 
            this.formDropwDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.formDropwDown2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.formDropwDown2.Controls.Add(this.dropDown2);
            this.formDropwDown2.Depth = 0;
            this.formDropwDown2.Dock = System.Windows.Forms.DockStyle.Top;
            this.formDropwDown2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.formDropwDown2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.formDropwDown2.IsSelected = false;
            this.formDropwDown2.Location = new System.Drawing.Point(0, 200);
            this.formDropwDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formDropwDown2.MouseState = MaterialSkin.MouseState.HOVER;
            this.formDropwDown2.Name = "formDropwDown2";
            this.formDropwDown2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.formDropwDown2.Size = new System.Drawing.Size(1076, 100);
            this.formDropwDown2.TabIndex = 3;
            this.formDropwDown2.TabStop = false;
            this.formDropwDown2.Text = "Multi Select Drop Down";
            // 
            // dropDown2
            // 
            this.dropDown2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.dropDown2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDown2.DataSource = ((object)(resources.GetObject("dropDown2.DataSource")));
            this.dropDown2.Depth = 0;
            this.dropDown2.DisplayMember = "CategoryName";
            this.dropDown2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDown2.DropDownHeight = 200;
            this.dropDown2.DropDownItemHeight = 30;
            this.dropDown2.DropDownWidth = -1;
            this.dropDown2.HideEmptyValue = false;
            this.dropDown2.Hint = "Multi Select Drop Down";
            this.dropDown2.IsMultiSelect = true;
            this.dropDown2.Items = ((System.Collections.Generic.List<object>)(resources.GetObject("dropDown2.Items")));
            this.dropDown2.Location = new System.Drawing.Point(3, 31);
            this.dropDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dropDown2.MouseState = MaterialSkin.MouseState.HOVER;
            this.dropDown2.Name = "dropDown2";
            this.dropDown2.SelectedIndex = -1;
            this.dropDown2.SelectedIndices = ((System.Collections.Generic.List<int>)(resources.GetObject("dropDown2.SelectedIndices")));
            this.dropDown2.SelectedValue = ((object)(resources.GetObject("dropDown2.SelectedValue")));
            this.dropDown2.Size = new System.Drawing.Size(1070, 32);
            this.dropDown2.TabIndex = 1;
            this.dropDown2.TabStop = false;
            this.dropDown2.ValueMember = "CategoryID";
            this.dropDown2.ValueChanged += new MaterialSkin.Controls.ItemSelectHandler(this.dropDown2_ValueChanged);
            // 
            // grpDisabledDropDown
            // 
            this.grpDisabledDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpDisabledDropDown.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.grpDisabledDropDown.Controls.Add(this.dropDown3);
            this.grpDisabledDropDown.Depth = 0;
            this.grpDisabledDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDisabledDropDown.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.grpDisabledDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.grpDisabledDropDown.IsSelected = false;
            this.grpDisabledDropDown.Location = new System.Drawing.Point(0, 100);
            this.grpDisabledDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDisabledDropDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.grpDisabledDropDown.Name = "grpDisabledDropDown";
            this.grpDisabledDropDown.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.grpDisabledDropDown.Size = new System.Drawing.Size(1076, 100);
            this.grpDisabledDropDown.TabIndex = 4;
            this.grpDisabledDropDown.TabStop = false;
            this.grpDisabledDropDown.Text = "Drop Down Disabled";
            // 
            // dropDown3
            // 
            this.dropDown3.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.dropDown3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDown3.DataSource = ((object)(resources.GetObject("dropDown3.DataSource")));
            this.dropDown3.Depth = 0;
            this.dropDown3.DisplayMember = "";
            this.dropDown3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDown3.DropDownHeight = 200;
            this.dropDown3.DropDownItemHeight = 30;
            this.dropDown3.DropDownWidth = -1;
            this.dropDown3.HideEmptyValue = false;
            this.dropDown3.Hint = "Drop Down";
            this.dropDown3.IsMultiSelect = false;
            this.dropDown3.Items = ((System.Collections.Generic.List<object>)(resources.GetObject("dropDown3.Items")));
            this.dropDown3.Location = new System.Drawing.Point(3, 31);
            this.dropDown3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dropDown3.MouseState = MaterialSkin.MouseState.HOVER;
            this.dropDown3.Name = "dropDown3";
            this.dropDown3.SelectedIndex = -1;
            this.dropDown3.SelectedIndices = ((System.Collections.Generic.List<int>)(resources.GetObject("dropDown3.SelectedIndices")));
            this.dropDown3.SelectedValue = null;
            this.dropDown3.Size = new System.Drawing.Size(1070, 32);
            this.dropDown3.TabIndex = 1;
            this.dropDown3.TabStop = false;
            this.dropDown3.ValueMember = "";
            // 
            // formDropwDown1
            // 
            this.formDropwDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.formDropwDown1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.formDropwDown1.Controls.Add(this.dropDown1);
            this.formDropwDown1.Depth = 0;
            this.formDropwDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.formDropwDown1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.formDropwDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.formDropwDown1.IsSelected = false;
            this.formDropwDown1.Location = new System.Drawing.Point(0, 0);
            this.formDropwDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formDropwDown1.MouseState = MaterialSkin.MouseState.HOVER;
            this.formDropwDown1.Name = "formDropwDown1";
            this.formDropwDown1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.formDropwDown1.Size = new System.Drawing.Size(1076, 100);
            this.formDropwDown1.TabIndex = 1;
            this.formDropwDown1.TabStop = false;
            this.formDropwDown1.Text = "Drop Down";
            // 
            // dropDown1
            // 
            this.dropDown1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.dropDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDown1.DataSource = ((object)(resources.GetObject("dropDown1.DataSource")));
            this.dropDown1.Depth = 0;
            this.dropDown1.DisplayMember = "ItemName";
            this.dropDown1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDown1.DropDownHeight = 200;
            this.dropDown1.DropDownItemHeight = 30;
            this.dropDown1.DropDownWidth = -1;
            this.dropDown1.HideEmptyValue = false;
            this.dropDown1.Hint = "Drop Down";
            this.dropDown1.IsMultiSelect = false;
            this.dropDown1.Items = ((System.Collections.Generic.List<object>)(resources.GetObject("dropDown1.Items")));
            this.dropDown1.Location = new System.Drawing.Point(3, 31);
            this.dropDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dropDown1.MouseState = MaterialSkin.MouseState.HOVER;
            this.dropDown1.Name = "dropDown1";
            this.dropDown1.SelectedIndex = -1;
            this.dropDown1.SelectedIndices = ((System.Collections.Generic.List<int>)(resources.GetObject("dropDown1.SelectedIndices")));
            this.dropDown1.SelectedValue = null;
            this.dropDown1.Size = new System.Drawing.Size(1070, 32);
            this.dropDown1.TabIndex = 1;
            this.dropDown1.TabStop = false;
            this.dropDown1.ValueMember = "ItemID";
            this.dropDown1.ValueChanged += new MaterialSkin.Controls.ItemSelectHandler(this.dropDown1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.frmMultiLine);
            this.panel1.Controls.Add(this.materialFormGroup5);
            this.panel1.Controls.Add(this.materialFormGroup4);
            this.panel1.Controls.Add(this.materialFormGroup2);
            this.panel1.Controls.Add(this.grpDisabled);
            this.panel1.Controls.Add(this.materialFormGroup1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 1104);
            this.panel1.TabIndex = 0;
            // 
            // frmMultiLine
            // 
            this.frmMultiLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.frmMultiLine.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.frmMultiLine.Controls.Add(this.materialRichText1);
            this.frmMultiLine.Depth = 0;
            this.frmMultiLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmMultiLine.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.frmMultiLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.frmMultiLine.IsSelected = false;
            this.frmMultiLine.Location = new System.Drawing.Point(0, 543);
            this.frmMultiLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmMultiLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.frmMultiLine.Name = "frmMultiLine";
            this.frmMultiLine.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.frmMultiLine.Size = new System.Drawing.Size(1076, 208);
            this.frmMultiLine.TabIndex = 9;
            this.frmMultiLine.TabStop = false;
            this.frmMultiLine.Text = "Multi Line Text";
            // 
            // materialRichText1
            // 
            this.materialRichText1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialRichText1.Depth = 0;
            this.materialRichText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialRichText1.Hint = "Multi Line Text";
            this.materialRichText1.Location = new System.Drawing.Point(3, 31);
            this.materialRichText1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRichText1.MaxLength = 2147483647;
            this.materialRichText1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRichText1.Name = "materialRichText1";
            this.materialRichText1.SelectedText = "";
            this.materialRichText1.SelectionLength = 0;
            this.materialRichText1.SelectionStart = 0;
            this.materialRichText1.Size = new System.Drawing.Size(1070, 174);
            this.materialRichText1.TabIndex = 0;
            this.materialRichText1.TabStop = false;
            // 
            // materialFormGroup5
            // 
            this.materialFormGroup5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup5.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup5.Controls.Add(this.materialRadioButton7);
            this.materialFormGroup5.Controls.Add(this.materialRadioButton6);
            this.materialFormGroup5.Depth = 0;
            this.materialFormGroup5.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup5.IsSelected = false;
            this.materialFormGroup5.Location = new System.Drawing.Point(0, 400);
            this.materialFormGroup5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialFormGroup5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup5.Name = "materialFormGroup5";
            this.materialFormGroup5.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup5.Size = new System.Drawing.Size(1076, 143);
            this.materialFormGroup5.TabIndex = 5;
            this.materialFormGroup5.TabStop = false;
            this.materialFormGroup5.Text = "Radio Button";
            // 
            // materialRadioButton7
            // 
            this.materialRadioButton7.AutoSize = true;
            this.materialRadioButton7.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton7.Depth = 0;
            this.materialRadioButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialRadioButton7.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton7.Location = new System.Drawing.Point(3, 61);
            this.materialRadioButton7.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton7.Name = "materialRadioButton7";
            this.materialRadioButton7.Ripple = true;
            this.materialRadioButton7.Size = new System.Drawing.Size(1070, 30);
            this.materialRadioButton7.TabIndex = 13;
            this.materialRadioButton7.Text = "Selection 3";
            this.materialRadioButton7.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton6
            // 
            this.materialRadioButton6.AutoSize = true;
            this.materialRadioButton6.Checked = true;
            this.materialRadioButton6.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton6.Depth = 0;
            this.materialRadioButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialRadioButton6.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton6.Location = new System.Drawing.Point(3, 31);
            this.materialRadioButton6.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton6.Name = "materialRadioButton6";
            this.materialRadioButton6.Ripple = true;
            this.materialRadioButton6.Size = new System.Drawing.Size(1070, 30);
            this.materialRadioButton6.TabIndex = 12;
            this.materialRadioButton6.TabStop = true;
            this.materialRadioButton6.Text = "Selection 1";
            this.materialRadioButton6.UseVisualStyleBackColor = true;
            // 
            // materialFormGroup4
            // 
            this.materialFormGroup4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup4.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup4.Controls.Add(this.materialCheckBox8);
            this.materialFormGroup4.Depth = 0;
            this.materialFormGroup4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup4.Enabled = false;
            this.materialFormGroup4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup4.IsSelected = false;
            this.materialFormGroup4.Location = new System.Drawing.Point(0, 300);
            this.materialFormGroup4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialFormGroup4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup4.Name = "materialFormGroup4";
            this.materialFormGroup4.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup4.Size = new System.Drawing.Size(1076, 100);
            this.materialFormGroup4.TabIndex = 4;
            this.materialFormGroup4.TabStop = false;
            this.materialFormGroup4.Text = "Disabled Check Box";
            // 
            // materialCheckBox8
            // 
            this.materialCheckBox8.AutoSize = true;
            this.materialCheckBox8.Checked = true;
            this.materialCheckBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckBox8.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialCheckBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCheckBox8.Depth = 0;
            this.materialCheckBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCheckBox8.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox8.Location = new System.Drawing.Point(3, 31);
            this.materialCheckBox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox8.Name = "materialCheckBox8";
            this.materialCheckBox8.Ripple = true;
            this.materialCheckBox8.Size = new System.Drawing.Size(1070, 30);
            this.materialCheckBox8.TabIndex = 5;
            this.materialCheckBox8.Text = "Check Box";
            this.materialCheckBox8.UseVisualStyleBackColor = true;
            // 
            // materialFormGroup2
            // 
            this.materialFormGroup2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup2.Controls.Add(this.materialCheckBox7);
            this.materialFormGroup2.Depth = 0;
            this.materialFormGroup2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup2.IsSelected = false;
            this.materialFormGroup2.Location = new System.Drawing.Point(0, 200);
            this.materialFormGroup2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialFormGroup2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup2.Name = "materialFormGroup2";
            this.materialFormGroup2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup2.Size = new System.Drawing.Size(1076, 100);
            this.materialFormGroup2.TabIndex = 3;
            this.materialFormGroup2.TabStop = false;
            this.materialFormGroup2.Text = "Check Box";
            // 
            // materialCheckBox7
            // 
            this.materialCheckBox7.AutoSize = true;
            this.materialCheckBox7.Checked = true;
            this.materialCheckBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckBox7.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialCheckBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialCheckBox7.Depth = 0;
            this.materialCheckBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialCheckBox7.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox7.Location = new System.Drawing.Point(3, 31);
            this.materialCheckBox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox7.Name = "materialCheckBox7";
            this.materialCheckBox7.Ripple = true;
            this.materialCheckBox7.Size = new System.Drawing.Size(1070, 30);
            this.materialCheckBox7.TabIndex = 5;
            this.materialCheckBox7.Text = "Check Box";
            this.materialCheckBox7.UseVisualStyleBackColor = true;
            this.materialCheckBox7.Click += new System.EventHandler(this.materialCheckBox7_Click);
            // 
            // grpDisabled
            // 
            this.grpDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpDisabled.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.grpDisabled.Controls.Add(this.materialSingleLineTextField1);
            this.grpDisabled.Depth = 0;
            this.grpDisabled.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDisabled.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.grpDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.grpDisabled.IsSelected = false;
            this.grpDisabled.Location = new System.Drawing.Point(0, 100);
            this.grpDisabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDisabled.MouseState = MaterialSkin.MouseState.HOVER;
            this.grpDisabled.Name = "grpDisabled";
            this.grpDisabled.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.grpDisabled.Size = new System.Drawing.Size(1076, 100);
            this.grpDisabled.TabIndex = 2;
            this.grpDisabled.TabStop = false;
            this.grpDisabled.Text = "Disabled Text Box";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialSingleLineTextField1.ForeColor = System.Drawing.Color.Gray;
            this.materialSingleLineTextField1.Hint = "Disabled Text Box";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(3, 31);
            this.materialSingleLineTextField1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(1070, 32);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialFormGroup1
            // 
            this.materialFormGroup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup1.Controls.Add(this.materialSingleLineTextField4);
            this.materialFormGroup1.Depth = 0;
            this.materialFormGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup1.IsSelected = false;
            this.materialFormGroup1.Location = new System.Drawing.Point(0, 0);
            this.materialFormGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialFormGroup1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup1.Name = "materialFormGroup1";
            this.materialFormGroup1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup1.Size = new System.Drawing.Size(1076, 100);
            this.materialFormGroup1.TabIndex = 0;
            this.materialFormGroup1.TabStop = false;
            this.materialFormGroup1.Text = "Text Box";
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialSingleLineTextField4.ForeColor = System.Drawing.Color.Gray;
            this.materialSingleLineTextField4.Hint = "Normal Text Box";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(3, 31);
            this.materialSingleLineTextField4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(1070, 32);
            this.materialSingleLineTextField4.TabIndex = 0;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpIcon);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(2152, 1104);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Icons List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flpIcon
            // 
            this.flpIcon.AutoScroll = true;
            this.flpIcon.AutoSize = true;
            this.flpIcon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpIcon.Location = new System.Drawing.Point(0, 0);
            this.flpIcon.Margin = new System.Windows.Forms.Padding(0);
            this.flpIcon.Name = "flpIcon";
            this.flpIcon.Size = new System.Drawing.Size(2152, 1104);
            this.flpIcon.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gView);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(2152, 1104);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "Grid View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gView
            // 
            this.gView.AllowUserToAddRows = false;
            this.gView.AllowUserToDeleteRows = false;
            this.gView.AllowUserToResizeRows = false;
            this.gView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gView.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.gView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Product,
            this.Qty,
            this.Price,
            this.Amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gView.DefaultCellStyle = dataGridViewCellStyle2;
            this.gView.Depth = 0;
            this.gView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gView.EnableHeadersVisualStyles = false;
            this.gView.Font = new System.Drawing.Font("Roboto", 11F);
            this.gView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
            this.gView.Location = new System.Drawing.Point(0, 0);
            this.gView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gView.MouseState = MaterialSkin.MouseState.HOVER;
            this.gView.Name = "gView";
            this.gView.ReadOnly = true;
            this.gView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gView.RowHeadersVisible = false;
            this.gView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gView.Size = new System.Drawing.Size(2152, 1104);
            this.gView.TabIndex = 0;
            // 
            // No
            // 
            this.No.DataPropertyName = "No";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(2152, 1104);
            this.tabPage3.TabIndex = 8;
            this.tabPage3.Text = "Button";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.materialPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialPanel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(2152, 1104);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // materialPanel3
            // 
            this.materialPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanel3.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanel3.Controls.Add(this.flowLayoutPanel3);
            this.materialPanel3.Controls.Add(this.materialLabel2);
            this.materialPanel3.Depth = 0;
            this.materialPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialPanel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialPanel3.Location = new System.Drawing.Point(1076, 0);
            this.materialPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.materialPanel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel3.Name = "materialPanel3";
            this.materialPanel3.Size = new System.Drawing.Size(1076, 1104);
            this.materialPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.materialFlatButton1);
            this.flowLayoutPanel3.Controls.Add(this.materialFlatButton2);
            this.flowLayoutPanel3.Controls.Add(this.materialFlatButton3);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1076, 1077);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Alignment = System.Drawing.StringAlignment.Center;
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialFlatButton1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFlatButton1.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.IconType = MaterialSkin.IconType.NONE;
            this.materialFlatButton1.IsSelected = false;
            this.materialFlatButton1.Location = new System.Drawing.Point(6, 9);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = true;
            this.materialFlatButton1.Size = new System.Drawing.Size(124, 40);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "DEFAULT";
            this.materialFlatButton1.UseFlatStyle = true;
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Alignment = System.Drawing.StringAlignment.Center;
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialFlatButton2.ColorStyle = MaterialSkin.ColorType.PRIMARY;
            this.materialFlatButton2.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.IconType = MaterialSkin.IconType.NONE;
            this.materialFlatButton2.IsSelected = false;
            this.materialFlatButton2.Location = new System.Drawing.Point(142, 9);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = true;
            this.materialFlatButton2.Size = new System.Drawing.Size(125, 40);
            this.materialFlatButton2.TabIndex = 1;
            this.materialFlatButton2.Text = "PRIMARY";
            this.materialFlatButton2.UseFlatStyle = true;
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.Alignment = System.Drawing.StringAlignment.Center;
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialFlatButton3.ColorStyle = MaterialSkin.ColorType.SUCCESS;
            this.materialFlatButton3.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.IconType = MaterialSkin.IconType.NONE;
            this.materialFlatButton3.IsSelected = false;
            this.materialFlatButton3.Location = new System.Drawing.Point(279, 9);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = true;
            this.materialFlatButton3.Size = new System.Drawing.Size(126, 40);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "SUCCESS";
            this.materialFlatButton3.UseFlatStyle = false;
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialLabel2.Location = new System.Drawing.Point(0, 0);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(118, 27);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Flat Button";
            // 
            // materialPanel2
            // 
            this.materialPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanel2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanel2.Controls.Add(this.flowLayoutPanel4);
            this.materialPanel2.Controls.Add(this.flowLayoutPanel2);
            this.materialPanel2.Controls.Add(this.materialLabel1);
            this.materialPanel2.Depth = 0;
            this.materialPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialPanel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialPanel2.Location = new System.Drawing.Point(0, 0);
            this.materialPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.materialPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel2.Name = "materialPanel2";
            this.materialPanel2.Size = new System.Drawing.Size(1076, 1104);
            this.materialPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.materialButton2);
            this.flowLayoutPanel4.Controls.Add(this.materialButton3);
            this.flowLayoutPanel4.Controls.Add(this.materialButton4);
            this.flowLayoutPanel4.Controls.Add(this.materialButton5);
            this.flowLayoutPanel4.Controls.Add(this.materialButton6);
            this.flowLayoutPanel4.Controls.Add(this.materialButton7);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 223);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1076, 881);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // materialButton2
            // 
            this.materialButton2.Alignment = System.Drawing.StringAlignment.Center;
            this.materialButton2.AutoSize = true;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialButton2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialButton2.ControlSize = MaterialSkin.ControlSize.SMALL;
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.Depth = 0;
            this.materialButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton2.Icon")));
            this.materialButton2.IconType = MaterialSkin.IconType.APPS;
            this.materialButton2.IsSelected = false;
            this.materialButton2.Location = new System.Drawing.Point(4, 5);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Primary = true;
            this.materialButton2.Size = new System.Drawing.Size(144, 24);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "SMALL SIZE";
            this.materialButton2.UseFlatStyle = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.Alignment = System.Drawing.StringAlignment.Center;
            this.materialButton3.AutoSize = true;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialButton3.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialButton3.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton3.Depth = 0;
            this.materialButton3.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton3.Icon")));
            this.materialButton3.IconType = MaterialSkin.IconType.APPS;
            this.materialButton3.IsSelected = false;
            this.materialButton3.Location = new System.Drawing.Point(4, 39);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Primary = true;
            this.materialButton3.Size = new System.Drawing.Size(200, 40);
            this.materialButton3.TabIndex = 2;
            this.materialButton3.Text = "NORMAL SIZE";
            this.materialButton3.UseFlatStyle = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton4
            // 
            this.materialButton4.Alignment = System.Drawing.StringAlignment.Center;
            this.materialButton4.AutoSize = true;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialButton4.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialButton4.ControlSize = MaterialSkin.ControlSize.LARGE;
            this.materialButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton4.Depth = 0;
            this.materialButton4.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton4.Icon")));
            this.materialButton4.IconType = MaterialSkin.IconType.APPS;
            this.materialButton4.IsSelected = false;
            this.materialButton4.Location = new System.Drawing.Point(4, 89);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.Primary = true;
            this.materialButton4.Size = new System.Drawing.Size(241, 72);
            this.materialButton4.TabIndex = 3;
            this.materialButton4.Text = "LARGE SIZE";
            this.materialButton4.UseFlatStyle = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton2);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton3);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton4);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton5);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton6);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton7);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton8);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton9);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton10);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton11);
            this.flowLayoutPanel2.Controls.Add(this.materialRaisedButton12);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 27);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1076, 196);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton2.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.IconType = MaterialSkin.IconType.NONE;
            this.materialRaisedButton2.IsSelected = false;
            this.materialRaisedButton2.Location = new System.Drawing.Point(4, 5);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(124, 40);
            this.materialRaisedButton2.TabIndex = 0;
            this.materialRaisedButton2.Text = "DEFAULT";
            this.materialRaisedButton2.UseFlatStyle = false;
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton3.AutoSize = true;
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton3.ColorStyle = MaterialSkin.ColorType.PRIMARY;
            this.materialRaisedButton3.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Icon = null;
            this.materialRaisedButton3.IconType = MaterialSkin.IconType.NONE;
            this.materialRaisedButton3.IsSelected = false;
            this.materialRaisedButton3.Location = new System.Drawing.Point(136, 5);
            this.materialRaisedButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(125, 40);
            this.materialRaisedButton3.TabIndex = 1;
            this.materialRaisedButton3.Text = "PRIMARY";
            this.materialRaisedButton3.UseFlatStyle = false;
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton4.AutoSize = true;
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton4.ColorStyle = MaterialSkin.ColorType.SUCCESS;
            this.materialRaisedButton4.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton4.Icon")));
            this.materialRaisedButton4.IconType = MaterialSkin.IconType.DONE_ALL;
            this.materialRaisedButton4.IsSelected = false;
            this.materialRaisedButton4.Location = new System.Drawing.Point(269, 5);
            this.materialRaisedButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(158, 40);
            this.materialRaisedButton4.TabIndex = 2;
            this.materialRaisedButton4.Text = "SUCCESS";
            this.materialRaisedButton4.UseFlatStyle = false;
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton5.AutoSize = true;
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton5.ColorStyle = MaterialSkin.ColorType.INFO;
            this.materialRaisedButton5.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton5.Icon")));
            this.materialRaisedButton5.IconType = MaterialSkin.IconType.INFO;
            this.materialRaisedButton5.IsSelected = false;
            this.materialRaisedButton5.Location = new System.Drawing.Point(435, 5);
            this.materialRaisedButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(115, 40);
            this.materialRaisedButton5.TabIndex = 3;
            this.materialRaisedButton5.Text = "INFO";
            this.materialRaisedButton5.UseFlatStyle = false;
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton6.AutoSize = true;
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton6.ColorStyle = MaterialSkin.ColorType.WARNING;
            this.materialRaisedButton6.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton6.Icon")));
            this.materialRaisedButton6.IconType = MaterialSkin.IconType.WARNING;
            this.materialRaisedButton6.IsSelected = false;
            this.materialRaisedButton6.Location = new System.Drawing.Point(558, 5);
            this.materialRaisedButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(163, 40);
            this.materialRaisedButton6.TabIndex = 4;
            this.materialRaisedButton6.Text = "WARNING";
            this.materialRaisedButton6.UseFlatStyle = false;
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton7.AutoSize = true;
            this.materialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton7.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton7.ColorStyle = MaterialSkin.ColorType.DANGER;
            this.materialRaisedButton7.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton7.Icon")));
            this.materialRaisedButton7.IconType = MaterialSkin.IconType.DO_NOT_DISTURB;
            this.materialRaisedButton7.IsSelected = false;
            this.materialRaisedButton7.Location = new System.Drawing.Point(729, 5);
            this.materialRaisedButton7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(149, 40);
            this.materialRaisedButton7.TabIndex = 5;
            this.materialRaisedButton7.Text = "DANGER";
            this.materialRaisedButton7.UseFlatStyle = false;
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton8
            // 
            this.materialRaisedButton8.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton8.AutoSize = true;
            this.materialRaisedButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton8.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton8.ColorStyle = MaterialSkin.ColorType.INVERSE;
            this.materialRaisedButton8.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton8.Depth = 0;
            this.materialRaisedButton8.Icon = null;
            this.materialRaisedButton8.IconType = MaterialSkin.IconType.NONE;
            this.materialRaisedButton8.IsSelected = false;
            this.materialRaisedButton8.Location = new System.Drawing.Point(886, 5);
            this.materialRaisedButton8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton8.Name = "materialRaisedButton8";
            this.materialRaisedButton8.Primary = true;
            this.materialRaisedButton8.Size = new System.Drawing.Size(119, 40);
            this.materialRaisedButton8.TabIndex = 6;
            this.materialRaisedButton8.Text = "INVERSE";
            this.materialRaisedButton8.UseFlatStyle = false;
            this.materialRaisedButton8.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton9
            // 
            this.materialRaisedButton9.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton9.AutoSize = true;
            this.materialRaisedButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton9.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton9.ColorStyle = MaterialSkin.ColorType.GREEN;
            this.materialRaisedButton9.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton9.Depth = 0;
            this.materialRaisedButton9.Icon = null;
            this.materialRaisedButton9.IconType = MaterialSkin.IconType.NONE;
            this.materialRaisedButton9.IsSelected = false;
            this.materialRaisedButton9.Location = new System.Drawing.Point(4, 55);
            this.materialRaisedButton9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton9.Name = "materialRaisedButton9";
            this.materialRaisedButton9.Primary = true;
            this.materialRaisedButton9.Size = new System.Drawing.Size(102, 40);
            this.materialRaisedButton9.TabIndex = 7;
            this.materialRaisedButton9.Text = "GREEN";
            this.materialRaisedButton9.UseFlatStyle = false;
            this.materialRaisedButton9.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton10
            // 
            this.materialRaisedButton10.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton10.AutoSize = true;
            this.materialRaisedButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton10.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton10.ColorStyle = MaterialSkin.ColorType.PINK;
            this.materialRaisedButton10.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton10.Depth = 0;
            this.materialRaisedButton10.Icon = null;
            this.materialRaisedButton10.IconType = MaterialSkin.IconType.NONE;
            this.materialRaisedButton10.IsSelected = false;
            this.materialRaisedButton10.Location = new System.Drawing.Point(114, 55);
            this.materialRaisedButton10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton10.Name = "materialRaisedButton10";
            this.materialRaisedButton10.Primary = true;
            this.materialRaisedButton10.Size = new System.Drawing.Size(83, 40);
            this.materialRaisedButton10.TabIndex = 8;
            this.materialRaisedButton10.Text = "PINK";
            this.materialRaisedButton10.UseFlatStyle = false;
            this.materialRaisedButton10.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton11
            // 
            this.materialRaisedButton11.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton11.AutoSize = true;
            this.materialRaisedButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton11.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton11.ColorStyle = MaterialSkin.ColorType.PURPLE;
            this.materialRaisedButton11.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton11.Depth = 0;
            this.materialRaisedButton11.Icon = null;
            this.materialRaisedButton11.IconType = MaterialSkin.IconType.NONE;
            this.materialRaisedButton11.IsSelected = false;
            this.materialRaisedButton11.Location = new System.Drawing.Point(205, 55);
            this.materialRaisedButton11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton11.Name = "materialRaisedButton11";
            this.materialRaisedButton11.Primary = true;
            this.materialRaisedButton11.Size = new System.Drawing.Size(112, 40);
            this.materialRaisedButton11.TabIndex = 9;
            this.materialRaisedButton11.Text = "PURPLE";
            this.materialRaisedButton11.UseFlatStyle = false;
            this.materialRaisedButton11.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton12
            // 
            this.materialRaisedButton12.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton12.AutoSize = true;
            this.materialRaisedButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton12.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton12.ColorStyle = MaterialSkin.ColorType.YELLOW;
            this.materialRaisedButton12.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton12.Depth = 0;
            this.materialRaisedButton12.Icon = null;
            this.materialRaisedButton12.IconType = MaterialSkin.IconType.NONE;
            this.materialRaisedButton12.IsSelected = false;
            this.materialRaisedButton12.Location = new System.Drawing.Point(325, 55);
            this.materialRaisedButton12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton12.Name = "materialRaisedButton12";
            this.materialRaisedButton12.Primary = true;
            this.materialRaisedButton12.Size = new System.Drawing.Size(116, 40);
            this.materialRaisedButton12.TabIndex = 10;
            this.materialRaisedButton12.Text = "YELLOW";
            this.materialRaisedButton12.UseFlatStyle = false;
            this.materialRaisedButton12.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(169, 27);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Standard Button";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Alignment = System.Drawing.StringAlignment.Center;
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton1.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.IconType = MaterialSkin.IconType.NONE;
            this.materialRaisedButton1.IsSelected = false;
            this.materialRaisedButton1.Location = new System.Drawing.Point(1879, 10);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(277, 40);
            this.materialRaisedButton1.TabIndex = 21;
            this.materialRaisedButton1.Text = "Change color scheme";
            this.materialRaisedButton1.UseFlatStyle = false;
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item1ToolStripMenuItem,
            this.disabledItemToolStripMenuItem,
            this.item2ToolStripMenuItem,
            this.toolStripSeparator1,
            this.item3ToolStripMenuItem});
            this.materialContextMenuStrip1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(218, 130);
            // 
            // item1ToolStripMenuItem
            // 
            this.item1ToolStripMenuItem.AutoSize = false;
            this.item1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subItem1ToolStripMenuItem,
            this.subItem2ToolStripMenuItem});
            this.item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            this.item1ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            this.subItem1ToolStripMenuItem.AutoSize = false;
            this.subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            this.subItem1ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            this.subItem2ToolStripMenuItem.AutoSize = false;
            this.subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            this.subItem2ToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            this.disabledItemToolStripMenuItem.AutoSize = false;
            this.disabledItemToolStripMenuItem.Enabled = false;
            this.disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            this.disabledItemToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            this.item2ToolStripMenuItem.AutoSize = false;
            this.item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            this.item2ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // item3ToolStripMenuItem
            // 
            this.item3ToolStripMenuItem.AutoSize = false;
            this.item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            this.item3ToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.item3ToolStripMenuItem.Text = "Item 3";
            // 
            // materialPanel1
            // 
            this.materialPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanel1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanel1.Controls.Add(this.flowLayoutPanel1);
            this.materialPanel1.Controls.Add(this.materialDivider1);
            this.materialPanel1.Depth = 0;
            this.materialPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialPanel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialPanel1.Location = new System.Drawing.Point(0, 1280);
            this.materialPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Size = new System.Drawing.Size(2160, 100);
            this.materialPanel1.TabIndex = 22;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.materialRaisedButton1);
            this.flowLayoutPanel1.Controls.Add(this.materialButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(2160, 98);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // materialButton5
            // 
            this.materialButton5.Alignment = System.Drawing.StringAlignment.Center;
            this.materialButton5.AutoSize = true;
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialButton5.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialButton5.ControlSize = MaterialSkin.ControlSize.SMALL;
            this.materialButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton5.Depth = 0;
            this.materialButton5.Icon = null;
            this.materialButton5.IconType = MaterialSkin.IconType.NONE;
            this.materialButton5.IsSelected = false;
            this.materialButton5.Location = new System.Drawing.Point(4, 171);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.Primary = true;
            this.materialButton5.Size = new System.Drawing.Size(124, 24);
            this.materialButton5.TabIndex = 4;
            this.materialButton5.Text = "SMALL SIZE";
            this.materialButton5.UseFlatStyle = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialButton6
            // 
            this.materialButton6.Alignment = System.Drawing.StringAlignment.Center;
            this.materialButton6.AutoSize = true;
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialButton6.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialButton6.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.materialButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton6.Depth = 0;
            this.materialButton6.Icon = null;
            this.materialButton6.IconType = MaterialSkin.IconType.NONE;
            this.materialButton6.IsSelected = false;
            this.materialButton6.Location = new System.Drawing.Point(4, 205);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.Primary = true;
            this.materialButton6.Size = new System.Drawing.Size(168, 40);
            this.materialButton6.TabIndex = 5;
            this.materialButton6.Text = "NORMAL SIZE";
            this.materialButton6.UseFlatStyle = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            // 
            // materialButton7
            // 
            this.materialButton7.Alignment = System.Drawing.StringAlignment.Center;
            this.materialButton7.AutoSize = true;
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.materialButton7.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialButton7.ControlSize = MaterialSkin.ControlSize.LARGE;
            this.materialButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton7.Depth = 0;
            this.materialButton7.Icon = null;
            this.materialButton7.IconType = MaterialSkin.IconType.NONE;
            this.materialButton7.IsSelected = false;
            this.materialButton7.Location = new System.Drawing.Point(4, 255);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Primary = true;
            this.materialButton7.Size = new System.Drawing.Size(189, 72);
            this.materialButton7.TabIndex = 6;
            this.materialButton7.Text = "LARGE SIZE";
            this.materialButton7.UseFlatStyle = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2160, 1380);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialPanel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeFormAtStart = true;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialSkin Demo";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.materialTabControl1.ResumeLayout(false);
            this.tpControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.materialFormGroup7.ResumeLayout(false);
            this.materialFormGroup3.ResumeLayout(false);
            this.materialFormGroup6.ResumeLayout(false);
            this.frmDate.ResumeLayout(false);
            this.formDropwDown2.ResumeLayout(false);
            this.grpDisabledDropDown.ResumeLayout(false);
            this.formDropwDown1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.frmMultiLine.ResumeLayout(false);
            this.materialFormGroup5.ResumeLayout(false);
            this.materialFormGroup5.PerformLayout();
            this.materialFormGroup4.ResumeLayout(false);
            this.materialFormGroup4.PerformLayout();
            this.materialFormGroup2.ResumeLayout(false);
            this.materialFormGroup2.PerformLayout();
            this.grpDisabled.ResumeLayout(false);
            this.materialFormGroup1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.materialPanel3.ResumeLayout(false);
            this.materialPanel3.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.materialPanel2.ResumeLayout(false);
            this.materialPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.materialPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialDivider materialDivider1;
        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem item3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem disabledItemToolStripMenuItem;
		private MaterialButton materialRaisedButton1;
        private TabPage tpControls;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private MaterialFormGroup materialFormGroup1;
        private MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialFormGroup grpDisabled;
        private MaterialPanel materialPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialFormGroup materialFormGroup2;
        private MaterialCheckBox materialCheckBox7;
        private MaterialFormGroup materialFormGroup4;
        private MaterialCheckBox materialCheckBox8;
        private MaterialFormGroup materialFormGroup5;
        private MaterialRadioButton materialRadioButton6;
        private MaterialRadioButton materialRadioButton7;
        private MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialFormGroup formDropwDown1;
        private MaterialDropDown dropDown1;
        private MaterialFormGroup formDropwDown2;
        private MaterialDropDown dropDown2;
        private MaterialFormGroup grpDisabledDropDown;
        private MaterialDropDown dropDown3;
        private MaterialFormGroup frmDate;
        private MaterialDatePicker materialDatePicker1;
        private MaterialFormGroup materialFormGroup6;
        private MaterialDatePicker materialDatePicker2;
        private MaterialFormGroup materialFormGroup3;
        private MaterialDateRangePicker materialDateRangePicker1;
        private MaterialFormGroup materialFormGroup7;
        private MaterialDateRangePicker materialDateRangePicker2;
        private MaterialFormGroup frmMultiLine;
        private MaterialRichText materialRichText1;
        private TabPage tabPage1;
        private FlowLayoutPanel flpIcon;
        private TabPage tabPage2;
        private MaterialGridView gView;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialPanel materialPanel2;
        private MaterialPanel materialPanel3;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private MaterialButton materialRaisedButton2;
        private MaterialButton materialRaisedButton3;
        private MaterialButton materialRaisedButton4;
        private MaterialButton materialRaisedButton5;
        private MaterialButton materialRaisedButton6;
        private MaterialButton materialRaisedButton7;
        private MaterialButton materialRaisedButton8;
        private MaterialButton materialRaisedButton9;
        private MaterialButton materialRaisedButton10;
        private MaterialButton materialRaisedButton11;
        private MaterialButton materialRaisedButton12;
        private MaterialButton materialFlatButton1;
        private MaterialButton materialFlatButton2;
        private MaterialButton materialFlatButton3;
        private FlowLayoutPanel flowLayoutPanel4;
        private MaterialButton materialButton2;
        private MaterialButton materialButton3;
        private MaterialButton materialButton4;
        private MaterialButton materialButton5;
        private MaterialButton materialButton6;
        private MaterialButton materialButton7;
    }
}