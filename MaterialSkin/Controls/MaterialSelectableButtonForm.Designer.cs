namespace MaterialSkin.Controls
{
    partial class MaterialSelectableButtonForm
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
            this.pnlCancel = new MaterialSkin.Controls.MaterialPanel();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.pnlOk = new MaterialSkin.Controls.MaterialPanel();
            this.btnOK = new MaterialSkin.Controls.MaterialButton();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFooter.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.pnlOk.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlFooter.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.pnlFooter.Controls.Add(this.pnlCancel);
            this.pnlFooter.Controls.Add(this.pnlOk);
            this.pnlFooter.Depth = 0;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Font = new System.Drawing.Font("Roboto", 11F);
            this.pnlFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.pnlFooter.Location = new System.Drawing.Point(2, 223);
            this.pnlFooter.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(5);
            this.pnlFooter.Size = new System.Drawing.Size(447, 50);
            this.pnlFooter.TabIndex = 2;
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
            this.pnlCancel.Location = new System.Drawing.Point(5, 5);
            this.pnlCancel.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(251, 40);
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
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Primary = true;
            this.btnCancel.Size = new System.Drawing.Size(251, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Tag = "CANCEL";
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseFlatStyle = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.pnlOk.Location = new System.Drawing.Point(256, 5);
            this.pnlOk.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlOk.Name = "pnlOk";
            this.pnlOk.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlOk.Size = new System.Drawing.Size(186, 40);
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
            this.btnOK.Size = new System.Drawing.Size(181, 40);
            this.btnOK.TabIndex = 2;
            this.btnOK.Tag = "OK";
            this.btnOK.Text = "OK";
            this.btnOK.UseFlatStyle = false;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(2, 40);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(447, 183);
            this.flpMain.TabIndex = 3;
            // 
            // MaterialSelectableButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 275);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.pnlFooter);
            this.Name = "MaterialSelectableButtonForm";
            this.Padding = new System.Windows.Forms.Padding(2, 40, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Button";
            this.Load += new System.EventHandler(this.MaterialSelectableButtonForm_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.pnlOk.ResumeLayout(false);
            this.pnlOk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialPanel pnlFooter;
        private MaterialPanel pnlCancel;
        private MaterialButton btnCancel;
        private MaterialPanel pnlOk;
        private MaterialButton btnOK;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
    }
}