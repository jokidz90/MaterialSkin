namespace MaterialSkin.Controls
{
    partial class MaterialMessageBoxTextForm
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
            this.pnlFooter = new MaterialSkin.Controls.MaterialPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCancel = new MaterialSkin.Controls.MaterialPanel();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.pnlOk = new MaterialSkin.Controls.MaterialPanel();
            this.btnOK = new MaterialSkin.Controls.MaterialButton();
            this.materialPanel2 = new MaterialSkin.Controls.MaterialPanel();
            this.txtSingleLine = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMultilines = new MaterialSkin.Controls.MaterialRichText();
            this.pnlFooter.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.pnlOk.SuspendLayout();
            this.materialPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFooter.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlFooter.Controls.Add(this.tableLayoutPanel2);
            this.pnlFooter.Depth = 0;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlFooter.Location = new System.Drawing.Point(2, 103);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pnlFooter.Size = new System.Drawing.Size(496, 45);
            this.pnlFooter.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlCancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlOk, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(486, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlCancel
            // 
            this.pnlCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCancel.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Depth = 0;
            this.pnlCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCancel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlCancel.Location = new System.Drawing.Point(0, 0);
            this.pnlCancel.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(243, 39);
            this.pnlCancel.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancel.AutoSize = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnCancel.ColorStyle = MaterialSkin.ColorType.WARNING;
            this.btnCancel.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Depth = 0;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Icon = null;
            this.btnCancel.IconType = MaterialSkin.IconType.NONE;
            this.btnCancel.IsSelected = false;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(243, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "CANCEL";
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseFlatStyle = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnOKCANCEL_Click);
            // 
            // pnlOk
            // 
            this.pnlOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlOk.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlOk.Controls.Add(this.btnOK);
            this.pnlOk.Depth = 0;
            this.pnlOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOk.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlOk.Location = new System.Drawing.Point(243, 0);
            this.pnlOk.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlOk.Name = "pnlOk";
            this.pnlOk.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlOk.Size = new System.Drawing.Size(243, 39);
            this.pnlOk.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Alignment = System.Drawing.StringAlignment.Center;
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnOK.ColorStyle = MaterialSkin.ColorType.PRIMARY;
            this.btnOK.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Depth = 0;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Icon = null;
            this.btnOK.IconType = MaterialSkin.IconType.NONE;
            this.btnOK.IsSelected = false;
            this.btnOK.Location = new System.Drawing.Point(5, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = true;
            this.btnOK.Size = new System.Drawing.Size(238, 39);
            this.btnOK.TabIndex = 2;
            this.btnOK.TabStop = false;
            this.btnOK.Tag = "OK";
            this.btnOK.Text = "OK";
            this.btnOK.UseFlatStyle = false;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOKCANCEL_Click);
            // 
            // materialPanel2
            // 
            this.materialPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanel2.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanel2.Controls.Add(this.txtMultilines);
            this.materialPanel2.Controls.Add(this.txtSingleLine);
            this.materialPanel2.Depth = 0;
            this.materialPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialPanel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialPanel2.Location = new System.Drawing.Point(2, 40);
            this.materialPanel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel2.Name = "materialPanel2";
            this.materialPanel2.Padding = new System.Windows.Forms.Padding(5, 20, 5, 10);
            this.materialPanel2.Size = new System.Drawing.Size(496, 63);
            this.materialPanel2.TabIndex = 0;
            // 
            // txtSingleLine
            // 
            this.txtSingleLine.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.txtSingleLine.ControlSize = MaterialSkin.ControlSize.LARGE;
            this.txtSingleLine.Depth = 0;
            this.txtSingleLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSingleLine.Hint = null;
            this.txtSingleLine.Location = new System.Drawing.Point(5, 20);
            this.txtSingleLine.MaxLength = 32767;
            this.txtSingleLine.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSingleLine.Name = "txtSingleLine";
            this.txtSingleLine.PasswordChar = '\0';
            this.txtSingleLine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSingleLine.SelectedText = "";
            this.txtSingleLine.SelectionLength = 0;
            this.txtSingleLine.SelectionStart = 0;
            this.txtSingleLine.Size = new System.Drawing.Size(486, 31);
            this.txtSingleLine.TabIndex = 0;
            this.txtSingleLine.TabStop = false;
            this.txtSingleLine.UseSystemPasswordChar = false;
            // 
            // txtMultilines
            // 
            this.txtMultilines.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.txtMultilines.Depth = 0;
            this.txtMultilines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMultilines.Hint = null;
            this.txtMultilines.Location = new System.Drawing.Point(5, 51);
            this.txtMultilines.MaxLength = 2147483647;
            this.txtMultilines.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMultilines.Name = "txtMultilines";
            this.txtMultilines.SelectedText = "";
            this.txtMultilines.SelectionLength = 0;
            this.txtMultilines.SelectionStart = 0;
            this.txtMultilines.Size = new System.Drawing.Size(486, 2);
            this.txtMultilines.TabIndex = 1;
            this.txtMultilines.TabStop = false;
            // 
            // MaterialMessageBoxTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 150);
            this.Controls.Add(this.materialPanel2);
            this.Controls.Add(this.pnlFooter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaterialMessageBoxTextForm";
            this.Padding = new System.Windows.Forms.Padding(2, 40, 2, 2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message Box";
            this.pnlFooter.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.pnlOk.ResumeLayout(false);
            this.pnlOk.PerformLayout();
            this.materialPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialPanel pnlFooter;
        private MaterialPanel pnlCancel;
        private MaterialButton btnCancel;
        private MaterialPanel pnlOk;
        private MaterialButton btnOK;
        private MaterialPanel materialPanel2;
        private MaterialSingleLineTextField txtSingleLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialRichText txtMultilines;
    }
}