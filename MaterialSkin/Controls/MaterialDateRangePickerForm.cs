using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public partial class MaterialDateRangePickerForm : MaterialFormDialog
    {
        public event DateChangedHandler ValueChanged;

        private string _dateFormat = "ddd, dd MMM yyyy";
        public string DateFormat { get => _dateFormat; set => _dateFormat = value; }

        private DateTime _startValue = DateTime.Now;
        public DateTime StartValue
        {
            set
            {
                _startValue = value;
                btnStartDateValue.Text = _startValue.ToString(DateFormat);
                ddStartHour.SelectedValue = _startValue.Hour.ToString("00");
                ddStartMin.SelectedValue = _startValue.Minute.ToString("00");
                SetSelectedDate();
                this.Invalidate();
            }
            get
            {
                return _startValue;
            }
        }

        private DateTime _endValue = DateTime.Now;
        public DateTime EndValue
        {
            set
            {
                _endValue = value;
                btnEndDateValue.Text = _endValue.ToString(DateFormat);
                ddEndHour.SelectedValue = _endValue.Hour.ToString("00");
                ddEndMin.SelectedValue = _endValue.Minute.ToString("00");
                SetSelectedDate();
                this.Invalidate();
            }
            get
            {
                return _endValue;
            }
        }

        public bool ShowTime
        {
            set
            {
                pnlStartTime.Visible = value;
                if (!value)
                    tblHeaderStart.ColumnStyles.RemoveAt(1);
            }
            get
            {
                return pnlStartTime.Visible;
            }
        }

        public MaterialDateRangePickerForm()
        {
            InitializeComponent();
        }

        private void MaterialDatePickerForm_Load(object sender, EventArgs e)
        {
            btnShowYear.Tag = _startValue.Year;
            btnShowYear.Text = _startValue.Year.ToString();
            btnShowMonth.Tag = _startValue.Month;
            btnShowMonth.Text = _startValue.ToString("MMMM");

            LoadDate();

            var listType = new List<DropDownItem>();
            listType.Add(new DropDownItem(DateRangeType.TODAY, "TODAY"));
            listType.Add(new DropDownItem(DateRangeType.YESTERDAY, "YESTERDAY"));
            listType.Add(new DropDownItem(DateRangeType.THISWEEK, "THIS WEEK"));
            listType.Add(new DropDownItem(DateRangeType.LASTWEEK, "LAST WEEK"));
            listType.Add(new DropDownItem(DateRangeType.THISMONTH, "THIS MONTH"));
            listType.Add(new DropDownItem(DateRangeType.LASTMONTH, "LAST MONTH"));
            listType.Add(new DropDownItem(DateRangeType.THISYEAR, "THIS YEAR"));
            listType.Add(new DropDownItem(DateRangeType.LASTYEAR, "LAST YEAR"));
            listType.Add(new DropDownItem(DateRangeType.CUSTOM, "CUSTOM"));
            ddRangeType.DisplayMember = "Text";
            ddRangeType.ValueMember = "Value";
            ddRangeType.DataSource = listType;
            ddRangeType.SelectedIndex = 0;



            rbStart.Checked = true;
        }

        private bool _loadingDate = false;

        private void GenerateDate()
        {
            int year = (int)btnShowYear.Tag;
            int month = (int)btnShowMonth.Tag;
            string newTag = year + "-" + month;
            string oldTag = tblDate.Tag + "";
            if (newTag.IsEqual(oldTag))
                return;

            tblDate.Tag = newTag;
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
                    {
                        btn.ColorStyle = ColorType.PRIMARY;
                        btn.BorderColorType = ColorType.PRIMARY;
                    }

                    //if (rbStart.Checked)
                    //    btn.Enabled = startMonth.Date <= _endValue;
                    //else
                    //    btn.Enabled = startMonth.Date >= _startValue;

                    startMonth = startMonth.AddDays(1);
                    if (startMonth.Date > endMonth.Date)
                        break;
                }
                row++;

                startDay = 0;
            }
        }

        private void SetSelectedDate()
        {
            for (int y = 1; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    var pnl = tblDate.GetControlFromPosition(x, y);
                    var btn = (MaterialFlatButton)pnl.Controls[0];
                    btn.ColorStyle = (x == 0 || x == 6) ? ColorType.DANGER : ColorType.DEFAULT;
                    btn.BorderColorType = ColorType.DEFAULT;

                    if (btn.Tag == null)
                        continue;

                    var date = (DateTime)btn.Tag;
                    if (date.Date >= _startValue.Date && date.Date <= _endValue.Date)
                    {
                        btn.ColorStyle = ColorType.PRIMARY;
                        btn.BorderColorType = ColorType.PRIMARY;
                    }
                    
                }
            }
        }

        private void LoadDate()
        {
            if (_loadingDate)
                return;
            _loadingDate = true;

            ShowPanel("DATE");

            GenerateDate();

            SetSelectedDate();

            _loadingDate = false;
        }

        private void LoadYear()
        {
            ShowPanel("YEAR");
            int year = (int)btnShowYear.Tag;
            for (int y = 0; y < tblYear.RowCount; y++)
            {
                for (int x = 0; x < tblYear.ColumnCount; x++)
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
            ShowPanel("MONTH");
        }


        private string displayedPanel = "";
        private void ShowPanel(string panel)
        {
            if (displayedPanel.IsEqual(panel))
                return;
            tblDate.Dock = DockStyle.Bottom;
            tblMonth.Dock = DockStyle.Bottom;
            tblYear.Dock = DockStyle.Bottom;
            tblDate.Visible = false;
            tblMonth.Visible = false;
            tblYear.Visible = false;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            pnlNavigation.Visible = true;
            displayedPanel = panel;
            if (panel == "DATE")
            {
                tblDate.Dock = DockStyle.Fill;
                tblDate.Visible = true;
            }
            else if (panel == "MONTH")
            {
                tblMonth.Dock = DockStyle.Fill;
                tblMonth.Visible = true;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
            }
            else if (panel == "YEAR")
            {
                tblYear.Dock = DockStyle.Fill;
                tblYear.Visible = true;
            }
        }

        MaterialFlatButton selectedBtn = null;
        private void btnDate_Click(object sender, EventArgs e)
        {
            if (selectedBtn != null)
                selectedBtn.ColorStyle = (_startValue.DayOfWeek == DayOfWeek.Sunday || _startValue.DayOfWeek == DayOfWeek.Saturday) ? ColorType.DANGER : ColorType.DEFAULT;

            selectedBtn = (MaterialFlatButton)sender;
            selectedBtn.ColorStyle = ColorType.INFO;

            string hour = (rbStart.Checked ? ddStartHour.SelectedValue : ddEndHour.SelectedValue) + "";
            if (string.IsNullOrEmpty(hour))
                hour = "00";

            string min = (rbStart.Checked ? ddStartMin.SelectedValue : ddStartMin.SelectedValue) + "";
            if (string.IsNullOrEmpty(min))
                min = "00";
            var dtStr = ((DateTime)selectedBtn.Tag).ToString("yyyy-MM-dd") + " " + hour + ":" + min;
            var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            if (rbStart.Checked)
            {
                StartValue = ShowTime ? dtValue : dtValue.Date;
                if (_startValue.Date > _endValue.Date)
                    EndValue = _startValue.Date;
                rbEnd.Checked = true;
            }
            else
            {
                EndValue = ShowTime ? dtValue : dtValue.Date;
                if (_startValue.Date > _endValue.Date)
                    StartValue = _endValue.Date;
            }
            ddRangeType.SelectedValue = DateRangeType.CUSTOM.ToString();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, StartValue);
            this.Close();
        }

        private void ddStartTime_ValueChanged(object sender, ItemSelectArgs e)
        {
            string hour = ddStartHour.SelectedValue + "";
            if (string.IsNullOrEmpty(hour))
                hour = "00";

            string min = ddStartMin.SelectedValue + "";
            if (string.IsNullOrEmpty(min))
                min = "00";

            var dtStr = _startValue.ToString("yyyy-MM-dd") + " " + hour + ":" + min;
            var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            StartValue = ShowTime ? dtValue : dtValue.Date;
        }

        private void btnStarDateValue_Click(object sender, EventArgs e)
        {
            if (_loadingDate)
                return;
            btnShowYear.Tag = _startValue.Year;
            btnShowYear.Text = _startValue.Year.ToString();
            btnShowMonth.Tag = _startValue.Month;
            btnShowMonth.Text = _startValue.ToString("MMMM");
            LoadDate();

            rbStart.Checked = true;
        }

        private void ddEndTime_ValueChanged(object sender, ItemSelectArgs e)
        {
            string hour = ddStartHour.SelectedValue + "";
            if (string.IsNullOrEmpty(hour))
                hour = "00";

            string min = ddStartMin.SelectedValue + "";
            if (string.IsNullOrEmpty(min))
                min = "00";

            var dtStr = _startValue.ToString("yyyy-MM-dd") + " " + hour + ":" + min;
            var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            StartValue = ShowTime ? dtValue : dtValue.Date;
        }

        private void btnEndDateValue_Click(object sender, EventArgs e)
        {
            if (_loadingDate)
                return;
            btnShowYear.Tag = _endValue.Year;
            btnShowYear.Text = _endValue.Year.ToString();
            btnShowMonth.Tag = _endValue.Month;
            btnShowMonth.Text = _endValue.ToString("MMMM");
            LoadDate();

            rbEnd.Checked = true;
        }

        private void ddRangeType_ValueChanged(object sender, ItemSelectArgs e)
        {
            string val = e.SelectedValue + "";
            if (val.IsEqual("CUSTOM"))
                return;

            var startDate = DateTime.Now.Date;
            var endDate = DateTime.Now.Date;
            Extenstions.GetDateRange(val.Replace(" ", ""), "00:00", out startDate, out endDate);
            StartValue = startDate;
            EndValue = endDate;
            btnShowYear.Tag = startDate.Year;
            btnShowYear.Text = startDate.Year.ToString();
            btnShowMonth.Tag = startDate.Month;
            btnShowMonth.Text = startDate.ToString("MMMM");
            LoadDate();
        }

        private void rbStart_CheckedChanged(object sender, EventArgs e)
        {
            btnStartDateValue.Enabled = rbStart.Checked;
            btnEndDateValue.Enabled = rbEnd.Checked;
            LoadDate();
        }
    }

    public delegate void DateChangedHandler(object sender, DateTime value);
}
