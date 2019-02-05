﻿using System.Drawing;
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
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tpControls = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFormGroup6 = new MaterialSkin.Controls.MaterialFormGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFormGroup5 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialRadioButton8 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton7 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton6 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialFormGroup4 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialCheckBox8 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFormGroup2 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialCheckBox7 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFormGroup3 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFormGroup1 = new MaterialSkin.Controls.MaterialFormGroup();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.materialTabControl1.SuspendLayout();
            this.tpControls.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.materialFormGroup5.SuspendLayout();
            this.materialFormGroup4.SuspendLayout();
            this.materialFormGroup2.SuspendLayout();
            this.materialFormGroup3.SuspendLayout();
            this.materialFormGroup1.SuspendLayout();
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
            this.materialDivider1.Size = new System.Drawing.Size(1024, 1);
            this.materialDivider1.TabIndex = 16;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSize = true;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.BackColor = System.Drawing.Color.Maroon;
            this.materialButton1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialButton1.Depth = 0;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(641, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Primary = true;
            this.materialButton1.Size = new System.Drawing.Size(159, 50);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Change Theme";
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1024, 48);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tpControls);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 112);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1024, 523);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tpControls
            // 
            this.tpControls.Controls.Add(this.tableLayoutPanel1);
            this.tpControls.Location = new System.Drawing.Point(4, 22);
            this.tpControls.Name = "tpControls";
            this.tpControls.Padding = new System.Windows.Forms.Padding(3);
            this.tpControls.Size = new System.Drawing.Size(1016, 497);
            this.tpControls.TabIndex = 5;
            this.tpControls.Text = "Controls";
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1010, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialFormGroup6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(505, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 491);
            this.panel2.TabIndex = 1;
            // 
            // materialFormGroup6
            // 
            this.materialFormGroup6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup6.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup6.Depth = 0;
            this.materialFormGroup6.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup6.Location = new System.Drawing.Point(0, 0);
            this.materialFormGroup6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup6.Name = "materialFormGroup6";
            this.materialFormGroup6.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup6.Size = new System.Drawing.Size(505, 65);
            this.materialFormGroup6.TabIndex = 1;
            this.materialFormGroup6.TabStop = false;
            this.materialFormGroup6.Text = "Drop Box";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.materialFormGroup5);
            this.panel1.Controls.Add(this.materialFormGroup4);
            this.panel1.Controls.Add(this.materialFormGroup2);
            this.panel1.Controls.Add(this.materialFormGroup3);
            this.panel1.Controls.Add(this.materialFormGroup1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 491);
            this.panel1.TabIndex = 0;
            // 
            // materialFormGroup5
            // 
            this.materialFormGroup5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup5.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup5.Controls.Add(this.materialRadioButton8);
            this.materialFormGroup5.Controls.Add(this.materialRadioButton7);
            this.materialFormGroup5.Controls.Add(this.materialRadioButton5);
            this.materialFormGroup5.Controls.Add(this.materialRadioButton6);
            this.materialFormGroup5.Depth = 0;
            this.materialFormGroup5.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup5.Location = new System.Drawing.Point(0, 260);
            this.materialFormGroup5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup5.Name = "materialFormGroup5";
            this.materialFormGroup5.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup5.Size = new System.Drawing.Size(505, 162);
            this.materialFormGroup5.TabIndex = 5;
            this.materialFormGroup5.TabStop = false;
            this.materialFormGroup5.Text = "Radio Button";
            // 
            // materialRadioButton8
            // 
            this.materialRadioButton8.AutoSize = true;
            this.materialRadioButton8.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton8.Depth = 0;
            this.materialRadioButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialRadioButton8.Enabled = false;
            this.materialRadioButton8.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton8.Location = new System.Drawing.Point(3, 113);
            this.materialRadioButton8.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton8.Name = "materialRadioButton8";
            this.materialRadioButton8.Ripple = true;
            this.materialRadioButton8.Size = new System.Drawing.Size(499, 30);
            this.materialRadioButton8.TabIndex = 14;
            this.materialRadioButton8.Text = "Selection 4";
            this.materialRadioButton8.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton7
            // 
            this.materialRadioButton7.AutoSize = true;
            this.materialRadioButton7.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton7.Depth = 0;
            this.materialRadioButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialRadioButton7.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton7.Location = new System.Drawing.Point(3, 83);
            this.materialRadioButton7.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton7.Name = "materialRadioButton7";
            this.materialRadioButton7.Ripple = true;
            this.materialRadioButton7.Size = new System.Drawing.Size(499, 30);
            this.materialRadioButton7.TabIndex = 13;
            this.materialRadioButton7.Text = "Selection 3";
            this.materialRadioButton7.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton5
            // 
            this.materialRadioButton5.AutoSize = true;
            this.materialRadioButton5.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton5.Depth = 0;
            this.materialRadioButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialRadioButton5.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton5.Location = new System.Drawing.Point(3, 53);
            this.materialRadioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton5.Name = "materialRadioButton5";
            this.materialRadioButton5.Ripple = true;
            this.materialRadioButton5.Size = new System.Drawing.Size(499, 30);
            this.materialRadioButton5.TabIndex = 11;
            this.materialRadioButton5.Text = "Selection 2";
            this.materialRadioButton5.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton6
            // 
            this.materialRadioButton6.AutoSize = true;
            this.materialRadioButton6.Checked = true;
            this.materialRadioButton6.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialRadioButton6.Depth = 0;
            this.materialRadioButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialRadioButton6.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton6.Location = new System.Drawing.Point(3, 23);
            this.materialRadioButton6.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton6.Name = "materialRadioButton6";
            this.materialRadioButton6.Ripple = true;
            this.materialRadioButton6.Size = new System.Drawing.Size(499, 30);
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
            this.materialFormGroup4.Location = new System.Drawing.Point(0, 195);
            this.materialFormGroup4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup4.Name = "materialFormGroup4";
            this.materialFormGroup4.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup4.Size = new System.Drawing.Size(505, 65);
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
            this.materialCheckBox8.Location = new System.Drawing.Point(3, 23);
            this.materialCheckBox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox8.Name = "materialCheckBox8";
            this.materialCheckBox8.Ripple = true;
            this.materialCheckBox8.Size = new System.Drawing.Size(499, 30);
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
            this.materialFormGroup2.Location = new System.Drawing.Point(0, 130);
            this.materialFormGroup2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup2.Name = "materialFormGroup2";
            this.materialFormGroup2.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup2.Size = new System.Drawing.Size(505, 65);
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
            this.materialCheckBox7.Location = new System.Drawing.Point(3, 23);
            this.materialCheckBox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox7.Name = "materialCheckBox7";
            this.materialCheckBox7.Ripple = true;
            this.materialCheckBox7.Size = new System.Drawing.Size(499, 30);
            this.materialCheckBox7.TabIndex = 5;
            this.materialCheckBox7.Text = "Check Box";
            this.materialCheckBox7.UseVisualStyleBackColor = true;
            // 
            // materialFormGroup3
            // 
            this.materialFormGroup3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialFormGroup3.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialFormGroup3.Controls.Add(this.materialSingleLineTextField1);
            this.materialFormGroup3.Depth = 0;
            this.materialFormGroup3.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialFormGroup3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.materialFormGroup3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.materialFormGroup3.Location = new System.Drawing.Point(0, 65);
            this.materialFormGroup3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup3.Name = "materialFormGroup3";
            this.materialFormGroup3.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup3.Size = new System.Drawing.Size(505, 65);
            this.materialFormGroup3.TabIndex = 2;
            this.materialFormGroup3.TabStop = false;
            this.materialFormGroup3.Text = "Disabled Text Box";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialSingleLineTextField1.ForeColor = System.Drawing.Color.Gray;
            this.materialSingleLineTextField1.Hint = "Disabled Text Box";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(3, 23);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(499, 23);
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
            this.materialFormGroup1.Location = new System.Drawing.Point(0, 0);
            this.materialFormGroup1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFormGroup1.Name = "materialFormGroup1";
            this.materialFormGroup1.Padding = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.materialFormGroup1.Size = new System.Drawing.Size(505, 65);
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
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(3, 23);
            this.materialSingleLineTextField4.MaxLength = 32767;
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(499, 23);
            this.materialSingleLineTextField4.TabIndex = 0;
            this.materialSingleLineTextField4.TabStop = false;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(806, 6);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(215, 50);
            this.materialRaisedButton1.TabIndex = 21;
            this.materialRaisedButton1.Text = "Change color scheme";
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
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(166, 130);
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
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
            this.materialPanel1.Location = new System.Drawing.Point(0, 635);
            this.materialPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.materialPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Size = new System.Drawing.Size(1024, 65);
            this.materialPanel1.TabIndex = 22;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.materialRaisedButton1);
            this.flowLayoutPanel1.Controls.Add(this.materialButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 64);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialPanel1);
            this.Controls.Add(this.materialTabSelector1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialSkin Demo";
            this.materialTabControl1.ResumeLayout(false);
            this.tpControls.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.materialFormGroup5.ResumeLayout(false);
            this.materialFormGroup5.PerformLayout();
            this.materialFormGroup4.ResumeLayout(false);
            this.materialFormGroup4.PerformLayout();
            this.materialFormGroup2.ResumeLayout(false);
            this.materialFormGroup2.PerformLayout();
            this.materialFormGroup3.ResumeLayout(false);
            this.materialFormGroup1.ResumeLayout(false);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.materialPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialButton1;
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
		private MaterialRaisedButton materialRaisedButton1;
        private TabPage tpControls;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private MaterialFormGroup materialFormGroup1;
        private MaterialSingleLineTextField materialSingleLineTextField4;
        private MaterialFormGroup materialFormGroup3;
        private MaterialPanel materialPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaterialFormGroup materialFormGroup2;
        private MaterialCheckBox materialCheckBox7;
        private MaterialFormGroup materialFormGroup4;
        private MaterialCheckBox materialCheckBox8;
        private MaterialFormGroup materialFormGroup5;
        private MaterialRadioButton materialRadioButton5;
        private MaterialRadioButton materialRadioButton6;
        private MaterialRadioButton materialRadioButton8;
        private MaterialRadioButton materialRadioButton7;
        private MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialFormGroup materialFormGroup6;
    }
}