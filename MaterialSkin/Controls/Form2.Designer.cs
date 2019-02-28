namespace MaterialSkin.Controls
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pnlTime = new MaterialSkin.Controls.MaterialPanelColored();
            this.btnTimeValue = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialPanelColored2 = new MaterialSkin.Controls.MaterialPanelColored();
            this.ddHour = new MaterialSkin.Controls.MaterialDropDown();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialPanelColored4 = new MaterialSkin.Controls.MaterialPanelColored();
            this.ddMinute = new MaterialSkin.Controls.MaterialDropDown();
            this.pnlTime.SuspendLayout();
            this.materialPanelColored2.SuspendLayout();
            this.materialPanelColored4.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTime.Location = new System.Drawing.Point(280, 195);
            this.pnlTime.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(240, 60);
            this.pnlTime.TabIndex = 7;
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
            this.btnTimeValue.Size = new System.Drawing.Size(65, 60);
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
            this.materialPanelColored2.Location = new System.Drawing.Point(65, 0);
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
            this.materialLabel1.Location = new System.Drawing.Point(145, 0);
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
            this.materialPanelColored4.Location = new System.Drawing.Point(160, 0);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTime);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Text = "Form2";
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.materialPanelColored2.ResumeLayout(false);
            this.materialPanelColored4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialPanelColored pnlTime;
        private MaterialFlatButton btnTimeValue;
        private MaterialPanelColored materialPanelColored2;
        private MaterialDropDown ddHour;
        private MaterialLabel materialLabel1;
        private MaterialPanelColored materialPanelColored4;
        private MaterialDropDown ddMinute;
    }
}