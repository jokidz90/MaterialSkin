using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class MaterialDatePickerForm : MaterialFormDialog
    {
        public event DateChangedHandler ValueChanged;

        private string _dateFormat = "ddd, dd MMM yyyy";
        public string DateFormat { get => _dateFormat; set => _dateFormat = value; }

        private DateTime _value = DateTime.Now;
        public DateTime Value
        {
            set
            {
                _value = value;
                //btnDateValue.Text = _value.ToString(DateFormat);
                //ddHour.SelectedValue = _value.Hour.ToString("00");
                //ddMinute.SelectedValue = _value.Minute.ToString("00");
                this.Invalidate();
            }
            get
            {
                return _value;
            }
        }

        public bool ShowTime
        {
            set
            {
                //pnlTime.Visible = value;
                //if (!value)
                //    tblHeader.ColumnStyles.RemoveAt(1);
            }
            get
            {
                //return pnlTime.Visible;
                return false;
            }
        }

        public MaterialDatePickerForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            //btnToday.Text = DateTime.Now.ToString(DateFormat);
            //btnShowYear.Tag = _value.Year;
            //btnShowYear.Text = _value.Year.ToString();
            //btnShowMonth.Tag = _value.Month;
            //btnShowMonth.Text = _value.ToString("MMMM");
            //ddHour.SelectedValue = _value.Hour.ToString("00");
            //if (ddHour.SelectedValue == null)
            //    ddHour.SelectedIndex = 0;

            //ddMinute.SelectedValue = _value.Minute.ToString("00");
            //if (ddMinute.SelectedValue == null)
            //    ddMinute.SelectedIndex = 0;

            //LoadDate();
        }

        private void MaterialDatePickerForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadDate()
        {
            ShowPanel("DATE");
            for (int y = 1; y < 7; y++)
            {
                //for (int x = 0; x < 7; x++)
                //{
                //    var pnl = tblDate.GetControlFromPosition(x, y);
                //    var btn = (MaterialFlatButton)pnl.Controls[0];
                //    btn.Enabled = false;
                //    btn.Text = "";
                //    btn.Tag = null;
                //    btn.ColorStyle = (x == 0 || x == 6) ? ColorType.DANGER : ColorType.DEFAULT;
                //}
            }

            //int year = (int)btnShowYear.Tag;
            //int month = (int)btnShowMonth.Tag;

            //DateTime startMonth = new DateTime(year, month, 1).Date;
            //DateTime endMonth = startMonth.AddMonths(1).AddDays(-1).Date;

            //int startDay = (int)startMonth.DayOfWeek;
            //int row = 1;
            //while (startMonth.Date <= endMonth.Date)
            //{
            //    for (int i = startDay; i < 7; i++)
            //    {
            //        var pnl = tblDate.GetControlFromPosition(i, row);
            //        var btn = (MaterialFlatButton)pnl.Controls[0];
            //        btn.Text = startMonth.Day.ToString();
            //        btn.Tag = startMonth.Date;
            //        btn.Enabled = true;
            //        if (startMonth.Date == _value.Date)
            //        {
            //            btn.ColorStyle = ColorType.INFO;
            //            btn.BorderColorType = ColorType.INFO;
            //            if (selectedBtn == null)
            //                selectedBtn = btn;
            //        }

            //        startMonth = startMonth.AddDays(1);
            //        if (startMonth.Date > endMonth.Date)
            //            break;
            //    }
            //    row++;

            //    startDay = 0;
            //}
        }

        private void LoadYear()
        {
            //ShowPanel("YEAR");
            //int year = (int)btnShowYear.Tag;
            //for (int y = 0; y < tblYear.RowCount; y++)
            //{
            //    for (int x = 0; x < tblYear.ColumnCount; x++)
            //    {
            //        var pnl = tblYear.GetControlFromPosition(x, y);
            //        var btn = (MaterialFlatButton)pnl.Controls[0];
            //        btn.Tag = year;
            //        btn.Text = year.ToString();
            //        year++;
            //    }
            //}
        }

        private void LoadMonth()
        {
            ShowPanel("MONTH");
        }

        private void ShowPanel(string panel)
        {
            //tblDate.Dock = DockStyle.Bottom;
            //tblMonth.Dock = DockStyle.Bottom;
            //tblYear.Dock = DockStyle.Bottom;
            //tblDate.Visible = false;
            //tblMonth.Visible = false;
            //tblYear.Visible = false;
            //btnPrev.Enabled = true;
            //btnNext.Enabled = true;
            //pnlNavigation.Visible = true;

            //if (panel == "DATE")
            //{
            //    tblDate.Dock = DockStyle.Fill;
            //    tblDate.Visible = true;
            //}
            //else if (panel == "MONTH")
            //{
            //    tblMonth.Dock = DockStyle.Fill;
            //    tblMonth.Visible = true;
            //    btnPrev.Enabled = false;
            //    btnNext.Enabled = false;
            //}
            //else if (panel == "YEAR")
            //{
            //    tblYear.Dock = DockStyle.Fill;
            //    tblYear.Visible = true;
            //}
        }

        MaterialFlatButton selectedBtn = null;
        private void btnDate_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
            {
                selectedBtn.ColorStyle = (_value.DayOfWeek == DayOfWeek.Sunday || _value.DayOfWeek == DayOfWeek.Saturday) ? ColorType.DANGER : ColorType.DEFAULT;
                selectedBtn.BorderColorType = ColorType.DEFAULT;
            }

            selectedBtn = (MaterialFlatButton)sender;
            selectedBtn.ColorStyle = ColorType.INFO;
            selectedBtn.BorderColorType = ColorType.INFO;

            //string hour = ddHour.SelectedValue + "";
            //if (string.IsNullOrEmpty(hour))
            //    hour = "00";
            //string min = ddMinute.SelectedValue + "";
            //if (string.IsNullOrEmpty(min))
            //    min = "00";
            //var dtStr = ((DateTime)selectedBtn.Tag).ToString("yyyy-MM-dd") + " " + hour + ":" + min;
            //var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            //Value = ShowTime ? dtValue : dtValue.Date;
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
            //int year = (int)btnShowYear.Tag;
            //int month = (int)btnShowMonth.Tag;
            //if (tblDate.Visible)
            //{
            //    DateTime prev = new DateTime(year, month, 1).AddMonths(-1);
            //    btnShowYear.Tag = prev.Year;
            //    btnShowYear.Text = prev.Year.ToString();
            //    btnShowMonth.Tag = prev.Month;
            //    btnShowMonth.Text = prev.ToString("MMMM");
            //    LoadDate();
            //}
            //else if (tblYear.Visible)
            //{
            //    btnShowYear.Tag = year - (tblYear.RowCount * tblYear.ColumnCount);
            //    btnShowYear.Text = btnShowYear.Tag.ToString();
            //    LoadYear();
            //}
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //int year = (int)btnShowYear.Tag;
            //int month = (int)btnShowMonth.Tag;
            //if (tblDate.Visible)
            //{
            //    DateTime next = new DateTime(year, month, 1).AddMonths(1);
            //    btnShowYear.Tag = next.Year;
            //    btnShowYear.Text = next.Year.ToString();
            //    btnShowMonth.Tag = next.Month;
            //    btnShowMonth.Text = next.ToString("MMMM");
            //    LoadDate();
            //}
            //else if (tblYear.Visible)
            //{
            //    btnShowYear.Tag = year + (tblYear.RowCount * tblYear.ColumnCount);
            //    btnShowYear.Text = btnShowYear.Tag.ToString();
            //    LoadYear();
            //}
        }

        private void btnShowYear_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("btnShowYear");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, Value);
            this.Close();
        }

        private void btnDateValue_Click(object sender, EventArgs e)
        {
            btnShowYear.Tag = _value.Year;
            btnShowYear.Text = _value.Year.ToString();
            btnShowMonth.Tag = _value.Month;
            btnShowMonth.Text = _value.ToString("MMMM");
            LoadDate();
        }

        private void ddTime_ValueChanged(object sender, ItemSelectArgs e)
        {
            //string hour = ddHour.SelectedValue + "";
            //if (string.IsNullOrEmpty(hour))
            //    hour = "00";
            //string min = ddMinute.SelectedValue + "";
            //if (string.IsNullOrEmpty(min))
            //    min = "00";

            //var dtStr = _value.ToString("yyyy-MM-dd") + " " + hour + ":" + min;
            //var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            //Value = ShowTime ? dtValue : dtValue.Date;
        }
    }

    public delegate void DateChangedHandler(object sender, DateTime value);
}
