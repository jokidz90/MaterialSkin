namespace MaterialSkin.Controls
{
    partial class MaterialDatePickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialDatePickerForm));
            this.pnlFooter = new MaterialSkin.Controls.MaterialPanel();
            this.materialPanel4 = new MaterialSkin.Controls.MaterialPanel();
            this.btnToday = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialPanel3 = new MaterialSkin.Controls.MaterialPanel();
            this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialPanel2 = new MaterialSkin.Controls.MaterialPanel();
            this.btnOK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlNavigation = new MaterialSkin.Controls.MaterialPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowYear = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnShowMonth = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnPrev = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNext = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pnlHeader = new MaterialSkin.Controls.MaterialPanelColored();
            this.btnDateValue = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlTime = new MaterialSkin.Controls.MaterialPanelColored();
            this.btnTimeValue = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialPanelColored2 = new MaterialSkin.Controls.MaterialPanelColored();
            this.ddHour = new MaterialSkin.Controls.MaterialDropDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialPanelColored4 = new MaterialSkin.Controls.MaterialPanelColored();
            this.ddMinute = new MaterialSkin.Controls.MaterialDropDown();
            this.pnlFooter.SuspendLayout();
            this.materialPanel4.SuspendLayout();
            this.materialPanel3.SuspendLayout();
            this.materialPanel2.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.materialPanelColored2.SuspendLayout();
            this.materialPanelColored4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFooter.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlFooter.Controls.Add(this.materialPanel4);
            this.pnlFooter.Controls.Add(this.materialPanel3);
            this.pnlFooter.Controls.Add(this.materialPanel2);
            this.pnlFooter.Depth = 0;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlFooter.Location = new System.Drawing.Point(2, 428);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFooter.Size = new System.Drawing.Size(796, 70);
            this.pnlFooter.TabIndex = 0;
            // 
            // materialPanel4
            // 
            this.materialPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanel4.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanel4.Controls.Add(this.btnToday);
            this.materialPanel4.Depth = 0;
            this.materialPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialPanel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialPanel4.Location = new System.Drawing.Point(5, 5);
            this.materialPanel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel4.Name = "materialPanel4";
            this.materialPanel4.Size = new System.Drawing.Size(386, 60);
            this.materialPanel4.TabIndex = 2;
            // 
            // btnToday
            // 
            this.btnToday.Alignment = System.Drawing.StringAlignment.Center;
            this.btnToday.AutoSize = true;
            this.btnToday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnToday.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnToday.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.btnToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToday.Depth = 0;
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToday.Icon = ((System.Drawing.Image)(resources.GetObject("btnToday.Icon")));
            this.btnToday.IconType = MaterialSkin.IconType.EVENT;
            this.btnToday.IsSelected = null;
            this.btnToday.Location = new System.Drawing.Point(0, 0);
            this.btnToday.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnToday.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnToday.Name = "btnToday";
            this.btnToday.Primary = false;
            this.btnToday.Size = new System.Drawing.Size(386, 60);
            this.btnToday.TabIndex = 4;
            this.btnToday.Text = "2018";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // materialPanel3
            // 
            this.materialPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanel3.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanel3.Controls.Add(this.btnCancel);
            this.materialPanel3.Depth = 0;
            this.materialPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialPanel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialPanel3.Location = new System.Drawing.Point(391, 5);
            this.materialPanel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel3.Name = "materialPanel3";
            this.materialPanel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.materialPanel3.Size = new System.Drawing.Size(200, 60);
            this.materialPanel3.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.ColorStyle = MaterialSkin.ColorType.WARNING;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Icon = null;
            this.btnCancel.IconType = MaterialSkin.IconType.NONE;
            this.btnCancel.Location = new System.Drawing.Point(5, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(195, 60);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // materialPanel2
            // 
            this.materialPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanel2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanel2.Controls.Add(this.btnOK);
            this.materialPanel2.Depth = 0;
            this.materialPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialPanel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialPanel2.Location = new System.Drawing.Point(591, 5);
            this.materialPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel2.Name = "materialPanel2";
            this.materialPanel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.materialPanel2.Size = new System.Drawing.Size(200, 60);
            this.materialPanel2.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Depth = 0;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Icon = null;
            this.btnOK.IconType = MaterialSkin.IconType.NONE;
            this.btnOK.Location = new System.Drawing.Point(5, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = true;
            this.btnOK.Size = new System.Drawing.Size(195, 60);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlNavigation.ColorStyle = MaterialSkin.ColorType.PRIMARY;
            this.pnlNavigation.Controls.Add(this.tableLayoutPanel1);
            this.pnlNavigation.Controls.Add(this.btnPrev);
            this.pnlNavigation.Controls.Add(this.btnNext);
            this.pnlNavigation.Depth = 0;
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlNavigation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlNavigation.Location = new System.Drawing.Point(2, 62);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNavigation.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(796, 60);
            this.pnlNavigation.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnShowYear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnShowMonth, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(724, 60);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnShowYear
            // 
            this.btnShowYear.Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowYear.AutoSize = true;
            this.btnShowYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowYear.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnShowYear.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.btnShowYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowYear.Depth = 0;
            this.btnShowYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowYear.Icon = null;
            this.btnShowYear.IconType = MaterialSkin.IconType.NONE;
            this.btnShowYear.IsSelected = null;
            this.btnShowYear.Location = new System.Drawing.Point(362, 0);
            this.btnShowYear.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowYear.Name = "btnShowYear";
            this.btnShowYear.Primary = false;
            this.btnShowYear.Size = new System.Drawing.Size(362, 60);
            this.btnShowYear.TabIndex = 3;
            this.btnShowYear.Text = "2018";
            this.btnShowYear.UseVisualStyleBackColor = true;
            this.btnShowYear.Click += new System.EventHandler(this.btnShowYear_Click);
            // 
            // btnShowMonth
            // 
            this.btnShowMonth.Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowMonth.AutoSize = true;
            this.btnShowMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowMonth.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnShowMonth.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.btnShowMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMonth.Depth = 0;
            this.btnShowMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowMonth.Icon = null;
            this.btnShowMonth.IconType = MaterialSkin.IconType.NONE;
            this.btnShowMonth.IsSelected = null;
            this.btnShowMonth.Location = new System.Drawing.Point(0, 0);
            this.btnShowMonth.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowMonth.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowMonth.Name = "btnShowMonth";
            this.btnShowMonth.Primary = false;
            this.btnShowMonth.Size = new System.Drawing.Size(362, 60);
            this.btnShowMonth.TabIndex = 2;
            this.btnShowMonth.Text = "August";
            this.btnShowMonth.UseVisualStyleBackColor = true;
            this.btnShowMonth.Click += new System.EventHandler(this.btnShowMonth_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Alignment = System.Drawing.StringAlignment.Center;
            this.btnPrev.AutoSize = true;
            this.btnPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrev.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnPrev.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Depth = 0;
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrev.Icon = ((System.Drawing.Image)(resources.GetObject("btnPrev.Icon")));
            this.btnPrev.IconType = MaterialSkin.IconType.KEYBOARD_ARROW_LEFT;
            this.btnPrev.IsSelected = null;
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Primary = false;
            this.btnPrev.Size = new System.Drawing.Size(36, 60);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Alignment = System.Drawing.StringAlignment.Center;
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnNext.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Depth = 0;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Icon = ((System.Drawing.Image)(resources.GetObject("btnNext.Icon")));
            this.btnNext.IconType = MaterialSkin.IconType.KEYBOARD_ARROW_RIGHT;
            this.btnNext.IsSelected = null;
            this.btnNext.Location = new System.Drawing.Point(760, 0);
            this.btnNext.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = false;
            this.btnNext.Size = new System.Drawing.Size(36, 60);
            this.btnNext.TabIndex = 0;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDivider1.Location = new System.Drawing.Point(2, 122);
            this.materialDivider1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(796, 2);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(156)))), ((int)(((byte)(236)))));
            this.pnlHeader.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlHeader.Controls.Add(this.btnDateValue);
            this.pnlHeader.Controls.Add(this.pnlTime);
            this.pnlHeader.Depth = 0;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlHeader.Location = new System.Drawing.Point(2, 2);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pnlHeader.Size = new System.Drawing.Size(796, 60);
            this.pnlHeader.TabIndex = 6;
            // 
            // btnDateValue
            // 
            this.btnDateValue.Alignment = System.Drawing.StringAlignment.Center;
            this.btnDateValue.AutoSize = true;
            this.btnDateValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDateValue.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnDateValue.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.btnDateValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDateValue.Depth = 0;
            this.btnDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDateValue.Icon = ((System.Drawing.Image)(resources.GetObject("btnDateValue.Icon")));
            this.btnDateValue.IconType = MaterialSkin.IconType.EVENT_NOTE;
            this.btnDateValue.IsSelected = null;
            this.btnDateValue.Location = new System.Drawing.Point(8, 0);
            this.btnDateValue.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnDateValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDateValue.Name = "btnDateValue";
            this.btnDateValue.Primary = true;
            this.btnDateValue.Size = new System.Drawing.Size(505, 60);
            this.btnDateValue.TabIndex = 5;
            this.btnDateValue.Text = "Mon, 1 May 2000";
            this.btnDateValue.UseVisualStyleBackColor = true;
            this.btnDateValue.Click += new System.EventHandler(this.btnDateValue_Click);
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(156)))), ((int)(((byte)(236)))));
            this.pnlTime.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlTime.Controls.Add(this.btnTimeValue);
            this.pnlTime.Controls.Add(this.materialPanelColored2);
            this.pnlTime.Controls.Add(this.materialLabel1);
            this.pnlTime.Controls.Add(this.materialPanelColored4);
            this.pnlTime.Depth = 0;
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTime.Location = new System.Drawing.Point(513, 0);
            this.pnlTime.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.pnlTime.Size = new System.Drawing.Size(275, 60);
            this.pnlTime.TabIndex = 8;
            // 
            // btnTimeValue
            // 
            this.btnTimeValue.Alignment = System.Drawing.StringAlignment.Center;
            this.btnTimeValue.AutoSize = true;
            this.btnTimeValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimeValue.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnTimeValue.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.btnTimeValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeValue.Depth = 0;
            this.btnTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimeValue.Icon = ((System.Drawing.Image)(resources.GetObject("btnTimeValue.Icon")));
            this.btnTimeValue.IconType = MaterialSkin.IconType.ACCESS_TIME;
            this.btnTimeValue.IsSelected = null;
            this.btnTimeValue.Location = new System.Drawing.Point(0, 0);
            this.btnTimeValue.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnTimeValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimeValue.Name = "btnTimeValue";
            this.btnTimeValue.Primary = true;
            this.btnTimeValue.Size = new System.Drawing.Size(85, 60);
            this.btnTimeValue.TabIndex = 0;
            this.btnTimeValue.UseVisualStyleBackColor = true;
            // 
            // materialPanelColored2
            // 
            this.materialPanelColored2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(156)))), ((int)(((byte)(236)))));
            this.materialPanelColored2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanelColored2.Controls.Add(this.ddHour);
            this.materialPanelColored2.Depth = 0;
            this.materialPanelColored2.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialPanelColored2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanelColored2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanelColored2.Location = new System.Drawing.Point(85, 0);
            this.materialPanelColored2.Margin = new System.Windows.Forms.Padding(0);
            this.materialPanelColored2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanelColored2.Name = "materialPanelColored2";
            this.materialPanelColored2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.materialPanelColored2.Size = new System.Drawing.Size(80, 60);
            this.materialPanelColored2.TabIndex = 0;
            // 
            // ddHour
            // 
            this.ddHour.ColorStyle = MaterialSkin.ColorType.INVERSE;
            this.ddHour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddHour.DataSource = ((object)(resources.GetObject("ddHour.DataSource")));
            this.ddHour.Depth = 0;
            this.ddHour.DisplayMember = null;
            this.ddHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddHour.DropDownHeight = 200;
            this.ddHour.DropDownItemHeight = 30;
            this.ddHour.DropDownWidth = -1;
            this.ddHour.HideEmptyValue = true;
            this.ddHour.Hint = null;
            this.ddHour.IsMultiSelect = false;
            this.ddHour.Items = ((System.Collections.Generic.List<object>)(resources.GetObject("ddHour.Items")));
            this.ddHour.Location = new System.Drawing.Point(0, 15);
            this.ddHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddHour.MouseState = MaterialSkin.MouseState.HOVER;
            this.ddHour.Name = "ddHour";
            this.ddHour.SelectedIndex = -1;
            this.ddHour.SelectedIndices = ((System.Collections.Generic.List<int>)(resources.GetObject("ddHour.SelectedIndices")));
            this.ddHour.SelectedValue = null;
            this.ddHour.Size = new System.Drawing.Size(80, 32);
            this.ddHour.TabIndex = 0;
            this.ddHour.TabStop = false;
            this.ddHour.ValueMember = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialLabel1.Location = new System.Drawing.Point(165, 0);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(15, 60);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = ":";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialPanelColored4
            // 
            this.materialPanelColored4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(156)))), ((int)(((byte)(236)))));
            this.materialPanelColored4.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanelColored4.Controls.Add(this.ddMinute);
            this.materialPanelColored4.Depth = 0;
            this.materialPanelColored4.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialPanelColored4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanelColored4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanelColored4.Location = new System.Drawing.Point(180, 0);
            this.materialPanelColored4.Margin = new System.Windows.Forms.Padding(0);
            this.materialPanelColored4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanelColored4.Name = "materialPanelColored4";
            this.materialPanelColored4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.materialPanelColored4.Size = new System.Drawing.Size(80, 60);
            this.materialPanelColored4.TabIndex = 2;
            // 
            // ddMinute
            // 
            this.ddMinute.ColorStyle = MaterialSkin.ColorType.INVERSE;
            this.ddMinute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddMinute.DataSource = ((object)(resources.GetObject("ddMinute.DataSource")));
            this.ddMinute.Depth = 0;
            this.ddMinute.DisplayMember = null;
            this.ddMinute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddMinute.DropDownHeight = 200;
            this.ddMinute.DropDownItemHeight = 30;
            this.ddMinute.DropDownWidth = -1;
            this.ddMinute.HideEmptyValue = true;
            this.ddMinute.Hint = null;
            this.ddMinute.IsMultiSelect = false;
            this.ddMinute.Items = ((System.Collections.Generic.List<object>)(resources.GetObject("ddMinute.Items")));
            this.ddMinute.Location = new System.Drawing.Point(0, 15);
            this.ddMinute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddMinute.MouseState = MaterialSkin.MouseState.HOVER;
            this.ddMinute.Name = "ddMinute";
            this.ddMinute.SelectedIndex = -1;
            this.ddMinute.SelectedIndices = ((System.Collections.Generic.List<int>)(resources.GetObject("ddMinute.SelectedIndices")));
            this.ddMinute.SelectedValue = null;
            this.ddMinute.Size = new System.Drawing.Size(80, 32);
            this.ddMinute.TabIndex = 1;
            this.ddMinute.TabStop = false;
            this.ddMinute.ValueMember = null;
            // 
            // MaterialDatePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MaterialDatePickerForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TitleAlignment = System.Drawing.StringAlignment.Center;
            this.Load += new System.EventHandler(this.MaterialDatePickerForm_Load);
            this.pnlFooter.ResumeLayout(false);
            this.materialPanel4.ResumeLayout(false);
            this.materialPanel4.PerformLayout();
            this.materialPanel3.ResumeLayout(false);
            this.materialPanel3.PerformLayout();
            this.materialPanel2.ResumeLayout(false);
            this.materialPanel2.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlNavigation.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.materialPanelColored2.ResumeLayout(false);
            this.materialPanelColored4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialPanel pnlFooter;
        private MaterialPanel pnlNavigation;
        private MaterialFlatButton btnNext;
        private MaterialFlatButton btnPrev;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialFlatButton btnShowMonth;
        private MaterialFlatButton btnShowYear;
        private MaterialDivider materialDivider1;
        private MaterialRaisedButton btnCancel;
        private MaterialFlatButton btnToday;
        private MaterialPanelColored pnlHeader;
        private MaterialFlatButton btnDateValue;
        private MaterialRaisedButton btnOK;
        private MaterialPanel materialPanel3;
        private MaterialPanel materialPanel2;
        private MaterialPanel materialPanel4;
        private MaterialPanelColored pnlTime;
        private MaterialFlatButton btnTimeValue;
        private MaterialPanelColored materialPanelColored2;
        private MaterialDropDown ddHour;
        private MaterialLabel materialLabel1;
        private MaterialPanelColored materialPanelColored4;
        private MaterialDropDown ddMinute;
    }
}