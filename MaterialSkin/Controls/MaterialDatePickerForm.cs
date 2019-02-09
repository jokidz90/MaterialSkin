using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class MaterialDatePickerForm : MaterialFormDialog
    {
        private string _dateFormat = "ddd, dd MMM yyyy";

        private DateTime _value = DateTime.Now;
        public DateTime Value
        {
            set
            {
                _value = value;
                this.Text = _value.ToString(_dateFormat);
                this.Invalidate();
            }
            get
            {
                return _value;
            }
        }

        public MaterialDatePickerForm()
        {
            InitializeComponent();
        }

        private void MaterialDatePickerForm_Load(object sender, EventArgs e)
        {
            btnToday.Text = DateTime.Now.ToString(_dateFormat);
            btnShowYear.Tag = _value.Year;
            btnShowYear.Text = _value.Year.ToString();
            btnShowMonth.Tag = _value.Month;
            btnShowMonth.Text = _value.ToString("MMMM");
            LoadDate();
        }

        private void LoadDate()
        {
            this.SuspendLayout();
            tblDate.Dock = DockStyle.Fill;
            tblDate.BringToFront();
            tblMonth.Dock = DockStyle.Bottom;
            tblYear.Dock = DockStyle.Bottom;
            tblDate.Visible = true;
            tblMonth.Visible = false;
            tblYear.Visible = false;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;

            for (int y = 1; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    var pnl = tblDate.GetControlFromPosition(x, y);
                    var btn = (MaterialFlatButton)pnl.Controls[0];
                    btn.Enabled = false;
                    btn.Text = "";
                    btn.Tag = null;
                    btn.ColorStyle = (x == 0 || x == 6) ? ColorType.DANGER : ColorType.DEFAULT;
                }
            }

            int year = (int)btnShowYear.Tag;
            int month = (int)btnShowMonth.Tag;

            DateTime startMonth = new DateTime(year, month, 1).Date;
            DateTime endMonth = startMonth.AddMonths(1).AddDays(-1).Date;

            int startDay = (int)startMonth.DayOfWeek;
            int row = 1;
            while (startMonth.Date <= endMonth.Date)
            {
                for (int i = startDay; i < 7; i++)
                {
                    var pnl = tblDate.GetControlFromPosition(i, row);
                    var btn = (MaterialFlatButton)pnl.Controls[0];
                    btn.Text = startMonth.Day.ToString();
                    btn.Tag = startMonth.Date;
                    btn.Enabled = true;
                    if (startMonth.Date == DateTime.Now.Date)
                        btn.ColorStyle = ColorType.PRIMARY;

                    startMonth = startMonth.AddDays(1);
                    if (startMonth.Date > endMonth.Date)
                        break;
                }
                row++;

                startDay = 0;
            }
            this.ResumeLayout();
        }

        private void LoadYear()
        {
            tblDate.Dock = DockStyle.Bottom;
            tblMonth.Dock = DockStyle.Bottom;
            tblYear.Dock = DockStyle.Fill;
            tblYear.BringToFront();
            tblDate.Visible = false;
            tblMonth.Visible = false;
            tblYear.Visible = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;

            int year = (int)btnShowYear.Tag;
            for (int x = 0; x < tblYear.ColumnCount; x++)
            {
                for (int y = 0; y < tblYear.RowCount; y++)
                {
                    var pnl = tblYear.GetControlFromPosition(x, y);
                    var btn = (MaterialFlatButton)pnl.Controls[0];
                    btn.Tag = year;
                    btn.Text = year.ToString();
                    year++;
                }
            }
        }

        private void LoadMonth()
        {
            tblDate.Dock = DockStyle.Bottom;
            tblMonth.Dock = DockStyle.Fill;
            tblMonth.BringToFront();
            tblYear.Dock = DockStyle.Bottom;
            tblDate.Visible = false;
            tblMonth.Visible = true;
            tblYear.Visible = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
        }

        MaterialFlatButton selectedBtn = null;
        private void btnDate_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.ColorStyle = (_value.DayOfWeek == DayOfWeek.Sunday || _value.DayOfWeek == DayOfWeek.Saturday) ? ColorType.DANGER : ColorType.DEFAULT;

            selectedBtn = (MaterialFlatButton)sender;
            selectedBtn.ColorStyle = ColorType.INFO;
            Value = (DateTime)selectedBtn.Tag;
        }

        private void btnMonth_Clicked(object sender, EventArgs e)
        {
            var btn = (MaterialFlatButton)sender;
            btnShowMonth.Tag = Convert.ToInt32(btn.Tag);
            btnShowMonth.Text = new DateTime(2000, (int)btnShowMonth.Tag, 1).ToString("MMMM");
            LoadDate();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            var btn = (MaterialFlatButton)sender;
            btnShowYear.Tag = Convert.ToInt32(btn.Tag);
            btnShowYear.Text = btn.Tag.ToString();
            LoadDate();
        }


        private void btnPrev_Click(object sender, EventArgs e)
        {
            int year = (int)btnShowYear.Tag;
            int month = (int)btnShowMonth.Tag;
            if (tblDate.Visible)
            {
                DateTime prev = new DateTime(year, month, 1).AddMonths(-1);
                btnShowYear.Tag = prev.Year;
                btnShowYear.Text = prev.Year.ToString();
                btnShowMonth.Tag = prev.Month;
                btnShowMonth.Text = prev.ToString("MMMM");
                LoadDate();
            }
            else if (tblYear.Visible)
            {
                btnShowYear.Tag = year - (tblYear.RowCount * tblYear.ColumnCount);
                btnShowYear.Text = btnShowYear.Tag.ToString();
                LoadYear();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int year = (int)btnShowYear.Tag;
            int month = (int)btnShowMonth.Tag;
            if (tblDate.Visible)
            {
                DateTime next = new DateTime(year, month, 1).AddMonths(1);
                btnShowYear.Tag = next.Year;
                btnShowYear.Text = next.Year.ToString();
                btnShowMonth.Tag = next.Month;
                btnShowMonth.Text = next.ToString("MMMM");
                LoadDate();
            }
            else if (tblYear.Visible)
            {
                btnShowYear.Tag = year + (tblYear.RowCount * tblYear.ColumnCount);
                btnShowYear.Text = btnShowYear.Tag.ToString();
                LoadYear();
            }
        }

        private void btnShowYear_Click(object sender, EventArgs e)
        {
            LoadYear();
        }

        private void btnShowMonth_Click(object sender, EventArgs e)
        {
            LoadMonth();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            Value = DateTime.Now.Date;
            btnShowYear.Tag = _value.Year;
            btnShowYear.Text = _value.Year.ToString();
            btnShowMonth.Tag = _value.Month;
            btnShowMonth.Text = _value.ToString("MMMM");
            LoadDate();
        }
    }
}
