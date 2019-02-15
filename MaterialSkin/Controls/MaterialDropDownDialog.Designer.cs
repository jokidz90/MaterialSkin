namespace MaterialSkin.Controls
{
    partial class MaterialDropDownDialog
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
            this.flpMain = new MaterialSkin.Controls.MaterialPanel();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flpMain.ColorStyle = MaterialSkin.ColorType.DEFAULT;
            this.flpMain.Depth = 0;
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Font = new System.Drawing.Font("Roboto", 11F);
            this.flpMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.flpMain.Location = new System.Drawing.Point(2, 2);
            this.flpMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(329, 196);
            this.flpMain.TabIndex = 0;
            // 
            // MaterialDropDownDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 200);
            this.Controls.Add(this.flpMain);
            this.Name = "MaterialDropDownDialog";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.MaterialComboBoxDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialPanel flpMain;
    }
}