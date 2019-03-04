namespace MaterialSkin.Controls
{
    partial class MaterialMessageBoxForm
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
            this.pnlAbort = new MaterialSkin.Controls.MaterialPanel();
            this.btnAbort = new MaterialSkin.Controls.MaterialButton();
            this.pnlRetry = new MaterialSkin.Controls.MaterialPanel();
            this.btnRetry = new MaterialSkin.Controls.MaterialButton();
            this.pnlIgnore = new MaterialSkin.Controls.MaterialPanel();
            this.btnIgnore = new MaterialSkin.Controls.MaterialButton();
            this.pnlCancel = new MaterialSkin.Controls.MaterialPanel();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.pnlOk = new MaterialSkin.Controls.MaterialPanel();
            this.btnOK = new MaterialSkin.Controls.MaterialButton();
            this.pnlNo = new MaterialSkin.Controls.MaterialPanel();
            this.btnNo = new MaterialSkin.Controls.MaterialButton();
            this.pnlYes = new MaterialSkin.Controls.MaterialPanel();
            this.btnYes = new MaterialSkin.Controls.MaterialButton();
            this.materialPanel1 = new MaterialSkin.Controls.MaterialPanel();
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.pnlFooter.SuspendLayout();
            this.pnlAbort.SuspendLayout();
            this.pnlRetry.SuspendLayout();
            this.pnlIgnore.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.pnlOk.SuspendLayout();
            this.pnlNo.SuspendLayout();
            this.pnlYes.SuspendLayout();
            this.materialPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFooter.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlFooter.Controls.Add(this.pnlAbort);
            this.pnlFooter.Controls.Add(this.pnlRetry);
            this.pnlFooter.Controls.Add(this.pnlIgnore);
            this.pnlFooter.Controls.Add(this.pnlCancel);
            this.pnlFooter.Controls.Add(this.pnlOk);
            this.pnlFooter.Controls.Add(this.pnlNo);
            this.pnlFooter.Controls.Add(this.pnlYes);
            this.pnlFooter.Depth = 0;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlFooter.Location = new System.Drawing.Point(2, 245);
            this.pnlFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(3);
            this.pnlFooter.Size = new System.Drawing.Size(402, 45);
            this.pnlFooter.TabIndex = 1;
            // 
            // pnlAbort
            // 
            this.pnlAbort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlAbort.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlAbort.Controls.Add(this.btnAbort);
            this.pnlAbort.Depth = 0;
            this.pnlAbort.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAbort.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlAbort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlAbort.Location = new System.Drawing.Point(-532, 3);
            this.pnlAbort.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAbort.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlAbort.Name = "pnlAbort";
            this.pnlAbort.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlAbort.Size = new System.Drawing.Size(133, 39);
            this.pnlAbort.TabIndex = 4;
            // 
            // btnAbort
            // 
            this.btnAbort.Alignment = System.Drawing.StringAlignment.Center;
            this.btnAbort.AutoSize = true;
            this.btnAbort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbort.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnAbort.ColorStyle = MaterialSkin.ColorType.DANGER;
            this.btnAbort.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.btnAbort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbort.Depth = 0;
            this.btnAbort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbort.Icon = null;
            this.btnAbort.IconType = MaterialSkin.IconType.NONE;
            this.btnAbort.IsSelected = false;
            this.btnAbort.Location = new System.Drawing.Point(3, 0);
            this.btnAbort.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnAbort.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Primary = true;
            this.btnAbort.Size = new System.Drawing.Size(130, 39);
            this.btnAbort.TabIndex = 1;
            this.btnAbort.Tag = "ABORT";
            this.btnAbort.Text = "ABORT";
            this.btnAbort.UseFlatStyle = true;
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlRetry
            // 
            this.pnlRetry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlRetry.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlRetry.Controls.Add(this.btnRetry);
            this.pnlRetry.Depth = 0;
            this.pnlRetry.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRetry.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlRetry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlRetry.Location = new System.Drawing.Point(-399, 3);
            this.pnlRetry.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRetry.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlRetry.Name = "pnlRetry";
            this.pnlRetry.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlRetry.Size = new System.Drawing.Size(133, 39);
            this.pnlRetry.TabIndex = 3;
            // 
            // btnRetry
            // 
            this.btnRetry.Alignment = System.Drawing.StringAlignment.Center;
            this.btnRetry.AutoSize = true;
            this.btnRetry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRetry.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnRetry.ColorStyle = MaterialSkin.ColorType.SUCCESS;
            this.btnRetry.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetry.Depth = 0;
            this.btnRetry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetry.Icon = null;
            this.btnRetry.IconType = MaterialSkin.IconType.NONE;
            this.btnRetry.IsSelected = false;
            this.btnRetry.Location = new System.Drawing.Point(3, 0);
            this.btnRetry.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnRetry.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Primary = true;
            this.btnRetry.Size = new System.Drawing.Size(130, 39);
            this.btnRetry.TabIndex = 1;
            this.btnRetry.Tag = "RETRY";
            this.btnRetry.Text = "RETRY";
            this.btnRetry.UseFlatStyle = true;
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlIgnore
            // 
            this.pnlIgnore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlIgnore.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlIgnore.Controls.Add(this.btnIgnore);
            this.pnlIgnore.Depth = 0;
            this.pnlIgnore.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlIgnore.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlIgnore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlIgnore.Location = new System.Drawing.Point(-266, 3);
            this.pnlIgnore.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIgnore.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlIgnore.Name = "pnlIgnore";
            this.pnlIgnore.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlIgnore.Size = new System.Drawing.Size(133, 39);
            this.pnlIgnore.TabIndex = 2;
            // 
            // btnIgnore
            // 
            this.btnIgnore.Alignment = System.Drawing.StringAlignment.Center;
            this.btnIgnore.AutoSize = true;
            this.btnIgnore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIgnore.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnIgnore.ColorStyle = MaterialSkin.ColorType.PRIMARY;
            this.btnIgnore.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.btnIgnore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIgnore.Depth = 0;
            this.btnIgnore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIgnore.Icon = null;
            this.btnIgnore.IconType = MaterialSkin.IconType.NONE;
            this.btnIgnore.IsSelected = false;
            this.btnIgnore.Location = new System.Drawing.Point(3, 0);
            this.btnIgnore.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnIgnore.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Primary = true;
            this.btnIgnore.Size = new System.Drawing.Size(130, 39);
            this.btnIgnore.TabIndex = 1;
            this.btnIgnore.Tag = "IGNORE";
            this.btnIgnore.Text = "IGNORE";
            this.btnIgnore.UseFlatStyle = false;
            this.btnIgnore.UseVisualStyleBackColor = true;
            this.btnIgnore.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlCancel
            // 
            this.pnlCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCancel.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Depth = 0;
            this.pnlCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCancel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlCancel.Location = new System.Drawing.Point(-133, 3);
            this.pnlCancel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlCancel.Size = new System.Drawing.Size(133, 39);
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
            this.btnCancel.Location = new System.Drawing.Point(3, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(130, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "CANCEL";
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseFlatStyle = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlOk
            // 
            this.pnlOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlOk.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlOk.Controls.Add(this.btnOK);
            this.pnlOk.Depth = 0;
            this.pnlOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOk.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlOk.Location = new System.Drawing.Point(0, 3);
            this.pnlOk.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlOk.Name = "pnlOk";
            this.pnlOk.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlOk.Size = new System.Drawing.Size(133, 39);
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
            this.btnOK.Location = new System.Drawing.Point(3, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = true;
            this.btnOK.Size = new System.Drawing.Size(130, 39);
            this.btnOK.TabIndex = 2;
            this.btnOK.Tag = "OK";
            this.btnOK.Text = "OK";
            this.btnOK.UseFlatStyle = false;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlNo
            // 
            this.pnlNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlNo.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlNo.Controls.Add(this.btnNo);
            this.pnlNo.Depth = 0;
            this.pnlNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNo.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlNo.Location = new System.Drawing.Point(133, 3);
            this.pnlNo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlNo.Name = "pnlNo";
            this.pnlNo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlNo.Size = new System.Drawing.Size(133, 39);
            this.pnlNo.TabIndex = 6;
            // 
            // btnNo
            // 
            this.btnNo.Alignment = System.Drawing.StringAlignment.Center;
            this.btnNo.AutoSize = true;
            this.btnNo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNo.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnNo.ColorStyle = MaterialSkin.ColorType.DANGER;
            this.btnNo.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.Depth = 0;
            this.btnNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNo.Icon = null;
            this.btnNo.IconType = MaterialSkin.IconType.NONE;
            this.btnNo.IsSelected = false;
            this.btnNo.Location = new System.Drawing.Point(3, 0);
            this.btnNo.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.Primary = true;
            this.btnNo.Size = new System.Drawing.Size(130, 39);
            this.btnNo.TabIndex = 2;
            this.btnNo.Tag = "NO";
            this.btnNo.Text = "NO";
            this.btnNo.UseFlatStyle = true;
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btn_Click);
            // 
            // pnlYes
            // 
            this.pnlYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlYes.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlYes.Controls.Add(this.btnYes);
            this.pnlYes.Depth = 0;
            this.pnlYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlYes.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlYes.Location = new System.Drawing.Point(266, 3);
            this.pnlYes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlYes.Name = "pnlYes";
            this.pnlYes.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlYes.Size = new System.Drawing.Size(133, 39);
            this.pnlYes.TabIndex = 5;
            // 
            // btnYes
            // 
            this.btnYes.Alignment = System.Drawing.StringAlignment.Center;
            this.btnYes.AutoSize = true;
            this.btnYes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYes.BorderColorType = MaterialSkin.ColorType.DEFAULT;
            this.btnYes.ColorStyle = MaterialSkin.ColorType.PRIMARY;
            this.btnYes.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Depth = 0;
            this.btnYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYes.Icon = null;
            this.btnYes.IconType = MaterialSkin.IconType.NONE;
            this.btnYes.IsSelected = false;
            this.btnYes.Location = new System.Drawing.Point(3, 0);
            this.btnYes.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = true;
            this.btnYes.Size = new System.Drawing.Size(130, 39);
            this.btnYes.TabIndex = 2;
            this.btnYes.Tag = "YES";
            this.btnYes.Text = "YES";
            this.btnYes.UseFlatStyle = false;
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btn_Click);
            // 
            // materialPanel1
            // 
            this.materialPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialPanel1.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.materialPanel1.Controls.Add(this.lblMessage);
            this.materialPanel1.Depth = 0;
            this.materialPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialPanel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.materialPanel1.Location = new System.Drawing.Point(2, 40);
            this.materialPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.materialPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Size = new System.Drawing.Size(402, 205);
            this.materialPanel1.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.ControlSize = MaterialSkin.ControlSize.NORMAL;
            this.lblMessage.Depth = 0;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(402, 205);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaterialMessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 292);
            this.Controls.Add(this.materialPanel1);
            this.Controls.Add(this.pnlFooter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaterialMessageBoxForm";
            this.Padding = new System.Windows.Forms.Padding(2, 40, 2, 2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message Box";
            this.Load += new System.EventHandler(this.MaterialMessageBoxForm_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlAbort.ResumeLayout(false);
            this.pnlAbort.PerformLayout();
            this.pnlRetry.ResumeLayout(false);
            this.pnlRetry.PerformLayout();
            this.pnlIgnore.ResumeLayout(false);
            this.pnlIgnore.PerformLayout();
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.pnlOk.ResumeLayout(false);
            this.pnlOk.PerformLayout();
            this.pnlNo.ResumeLayout(false);
            this.pnlNo.PerformLayout();
            this.pnlYes.ResumeLayout(false);
            this.pnlYes.PerformLayout();
            this.materialPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialPanel pnlFooter;
        private MaterialPanel pnlCancel;
        private MaterialButton btnCancel;
        private MaterialPanel pnlOk;
        private MaterialButton btnOK;
        private MaterialPanel pnlAbort;
        private MaterialButton btnAbort;
        private MaterialPanel pnlRetry;
        private MaterialButton btnRetry;
        private MaterialPanel pnlIgnore;
        private MaterialButton btnIgnore;
        private MaterialPanel pnlNo;
        private MaterialButton btnNo;
        private MaterialPanel pnlYes;
        private MaterialButton btnYes;
        private MaterialPanel materialPanel1;
        private MaterialLabel lblMessage;
    }
}