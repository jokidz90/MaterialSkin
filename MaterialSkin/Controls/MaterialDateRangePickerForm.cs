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
    public partial class MaterialDateRangePickerForm : MaterialFormDialog
    {
        public event DateRangeChangedHandler ValueChanged;

        private DateTime _startValue = DateTime.Now;
        public DateTime StartValue
        {
            set
            {
                _startValue = value;
                btnStartDate.Text = _startValue.ToString(DateFormat);
                btnStartTime.Text = _startValue.ToString("hh:mm tt");
                btnStartTime.Tag = _startValue.ToString("hh:mm tt");
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
                btnEndDate.Text = _endValue.ToString(DateFormat);
                btnEndTime.Text = _endValue.ToString("hh:mm tt");
                btnEndTime.Tag = _endValue.ToString("hh:mm tt");
                this.Invalidate();
            }
            get
            {
                return _endValue;
            }
        }

        private DateRangeType _rangeSelection;
        public DateRangeType RangeSelection
        {
            set
            {
                _rangeSelection = value;
                btnSelectDateRange.Tag = _rangeSelection;
                if (_rangeSelection.ToString().StartsWith("LAST"))
                    btnSelectDateRange.Text = "Last " + _rangeSelection.ToString().Replace("LAST", "").ToLower();
                else if (_rangeSelection.ToString().StartsWith("THIS"))
                    btnSelectDateRange.Text = "This " + _rangeSelection.ToString().Replace("THIS", "").ToLower();
                else
                    btnSelectDateRange.Text = _rangeSelection.ToString().ToUpperFirst();
            }
            get
            {
                return _rangeSelection;
            }
        }

        private string _dateFormat = "ddd, dd MMM yyyy";
        public string DateFormat { get => _dateFormat; set => _dateFormat = value; }

        private bool IsSelectEndDate
        {
            set
            {
                if (value)
                    grpEndDate.Focus();
                else
                    grpStartDate.Focus();
                grpStartDate.IsSelected = !value;
                grpEndDate.IsSelected = value;

                btnStartDate.ColorStyle = value ? ColorType.GREY : ColorType.DEFAULT;
                btnStartTime.ColorStyle = value ? ColorType.GREY : ColorType.DEFAULT;
                btnEndDate.ColorStyle = value ? ColorType.DEFAULT : ColorType.GREY;
                btnEndTime.ColorStyle = value ? ColorType.DEFAULT : ColorType.GREY;

                Debug.WriteLine("grpStartDate.IsSelected:" + grpStartDate.IsSelected);
                Debug.WriteLine("grpEndDate.IsSelected:" + grpEndDate.IsSelected);
            }
            get
            {
                return grpEndDate.IsSelected;
            }
        }

        public DateTime CurrentValue
        {
            set
            {
                if (IsSelectEndDate)
                {
                    EndValue = value;
                    if (_endValue.Date < _startValue.Date)
                        StartValue = EndValue.Date.Add(_startValue.TimeOfDay);
                }
                else
                {
                    StartValue = value;
                    if (_startValue.Date > _endValue.Date)
                        EndValue = StartValue.Date.Add(_endValue.TimeOfDay);
                }
            }
            get
            {
                if (IsSelectEndDate)
                    return EndValue;
                else
                    return StartValue;
            }
        }

        public bool ShowTime
        {
            set
            {
                btnStartTime.Visible = value;
                btnEndTime.Visible = value;
            }
            get
            {
                return btnStartTime.Visible;
            }
        }

        private int _minYear = 2000;
        private int _yearPos = 4;
        private string _shownPanel = "";
        MaterialButton _selectedBtn = null;
        private int _hourStep = 0;
        private int _minStep = 0;
        private int _timerInterval = 500;

        public MaterialDateRangePickerForm()
        {
            InitializeComponent();
        }

        private void InitForm()
        {
            RangeSelection = DateRangeType.TODAY;
            btnSelectDateRange.Text = DateRangeType.TODAY.ToString();
            btnSelectDateRange.Tag = DateRangeType.TODAY.ToString();
            SetTimeValue(CurrentValue);
            btnShowYear.Tag = CurrentValue.Year;
            btnShowYear.Text = CurrentValue.Year.ToString();
            btnShowMonth.Tag = CurrentValue.Month;
            btnShowMonth.Text = CurrentValue.ToString("MMMM");
            IsSelectEndDate = false;
            LoadDate();
            SetHeaderButtonSize();
        }

        private void SetHeaderButtonSize()
        {
            int widthL = Convert.ToInt32(Math.Round(pnlHeader.Width * 0.5m, 0, MidpointRounding.ToEven));

            grpStartDate.Width = widthL;
            grpEndDate.Width = widthL;
            btnStartTime.AutoSize = false;
            btnStartTime.Width = 150;
            btnEndTime.AutoSize = false;
            btnEndTime.Width = 150;
        }

        private void SetTimeButtonSize()
        {
            var widthL = Convert.ToInt32(Math.Round(pnlTime.Width * 0.3m, 0, MidpointRounding.ToEven));
            var widthSM = Convert.ToInt32(Math.Round(pnlTime.Width * 0.03m, 0, MidpointRounding.ToEven));

            var heightL = Convert.ToInt32(Math.Round(pnlTime.Height * 0.28m, 0, MidpointRounding.ToEven));
            var heightSM = Convert.ToInt32(Math.Round(pnlTime.Height * 0.18m, 0, MidpointRounding.ToEven));

            btnNextHour.AutoSize = false;
            btnNextMin.AutoSize = false;
            btnPrevHour.AutoSize = false;
            btnPrevMin.AutoSize = false;
            btnHourNext.AutoSize = false;
            btnHourPrev.AutoSize = false;
            btnMinNext.AutoSize = false;
            btnMinPrev.AutoSize = false;

            btnNextHour.Height = heightSM;
            btnNextMin.Height = heightSM;
            btnPrevHour.Height = heightSM;
            btnPrevMin.Height = heightSM;
            btnHourNext.Height = heightSM;
            btnHourPrev.Height = heightSM;
            btnMinNext.Height = heightSM;
            btnMinPrev.Height = heightSM;

            pnlHour.Width = widthL;
            pnlMin.Width = widthL;
            //pnlAMPM.Width = widthL;
            pnlTimeSeparator1.Width = widthSM;
            pnlTimeSeparator2.Width = widthSM;
            btnAMPM.AutoSize = false;
            btnAMPM.Height = btnMin.Height;
            btnAMPM.Width = pnlAMPM.Width;
            btnAMPM.Location = new Point(0, ((pnlAMPM.Height - btnAMPM.Height) / 2));
        }

        private void SetMonthButtonSize()
        {
            int btnWidth = Convert.ToInt32(Math.Round((pnlDate.Width / 3m), 0, MidpointRounding.ToEven));
            int btnHeight = Convert.ToInt32(Math.Round((pnlDate.Height / 4m), 0, MidpointRounding.ToEven));

            for (int i = 0; i < pnlMonthYear.Controls.Count; i++)
            {
                var btn = (MaterialButton)pnlMonthYear.Controls[i];
                if (btn == null)
                    continue;

                int x = (btn.Name.Replace("btnMonthYear", "").Split('x')[0] + "").GetInt32Value();
                int y = (btn.Name.Replace("btnMonthYear", "").Split('x')[1] + "").GetInt32Value();

                btn.AutoSize = false;
                btn.Size = new Size(btnWidth, btnHeight);
                btn.Location = new Point((x * btnWidth), (y * btnHeight));
            }
        }

        private void SetDateButtonSize()
        {
            int btnWidth = Convert.ToInt32(Math.Round((pnlDate.Width / 7m), 0, MidpointRounding.ToEven));
            int btnHeight = Convert.ToInt32(Math.Round((pnlDate.Height / 7m), 0, MidpointRounding.ToEven));

            for (int i = 0; i < pnlDate.Controls.Count; i++)
            {
                var btn = (MaterialButton)pnlDate.Controls[i];
                if (btn == null)
                    continue;

                int x = (btn.Name.Replace("btnDate", "").Split('x')[0] + "").GetInt32Value();
                int y = (btn.Name.Replace("btnDate", "").Split('x')[1] + "").GetInt32Value();

                btn.AutoSize = false;
                btn.Size = new Size(btnWidth, btnHeight);
                btn.Location = new Point((x * btnWidth), (y * btnHeight));
            }
        }

        private void SetDateRangeButtonSize()
        {
            int btnWidth = Convert.ToInt32(Math.Round((pnlDateRange.Width / 2m), 0, MidpointRounding.ToEven));
            int btnHeight = Convert.ToInt32(Math.Round((pnlDateRange.Height / 5m), 0, MidpointRounding.ToEven));

            btnToday.AutoSize = false;
            btnYesterday.AutoSize = false;
            btnThisWeek.AutoSize = false;
            btnLastWeek.AutoSize = false;
            btnThisMonth.AutoSize = false;
            btnLastMonth.AutoSize = false;
            btnThisYear.AutoSize = false;
            btnLastYear.AutoSize = false;
            btnCustom.AutoSize = false;

            btnToday.Size = new Size(btnWidth, btnHeight);
            btnYesterday.Size = new Size(btnWidth, btnHeight);
            btnThisWeek.Size = new Size(btnWidth, btnHeight);
            btnLastWeek.Size = new Size(btnWidth, btnHeight);
            btnThisMonth.Size = new Size(btnWidth, btnHeight);
            btnLastMonth.Size = new Size(btnWidth, btnHeight);
            btnThisYear.Size = new Size(btnWidth, btnHeight);
            btnLastYear.Size = new Size(btnWidth, btnHeight);
            btnCustom.Size = new Size(pnlDateRange.Width, btnHeight);

            btnToday.Location = new Point(btnWidth, btnHeight * 0);
            btnYesterday.Location = new Point(0, btnHeight * 0);

            btnThisWeek.Location = new Point(btnWidth, btnHeight * 1);
            btnLastWeek.Location = new Point(0, btnHeight * 1);

            btnThisMonth.Location = new Point(btnWidth, btnHeight * 2);
            btnLastMonth.Location = new Point(0, btnHeight * 2);

            btnThisYear.Location = new Point(btnWidth, btnHeight * 3);
            btnLastYear.Location = new Point(0, btnHeight * 3);

            btnCustom.Location = new Point(0, btnHeight * 4);

            btnToday.BorderColorType = _rangeSelection == DateRangeType.TODAY ? ColorType.PRIMARY : ColorType.DEFAULT;
            btnYesterday.BorderColorType = _rangeSelection == DateRangeType.YESTERDAY ? ColorType.PRIMARY : ColorType.DEFAULT;
            btnThisWeek.BorderColorType = _rangeSelection == DateRangeType.THISWEEK ? ColorType.PRIMARY : ColorType.DEFAULT;
            btnLastWeek.BorderColorType = _rangeSelection == DateRangeType.LASTWEEK ? ColorType.PRIMARY : ColorType.DEFAULT;
            btnThisMonth.BorderColorType = _rangeSelection == DateRangeType.THISMONTH ? ColorType.PRIMARY : ColorType.DEFAULT;
            btnLastMonth.BorderColorType = _rangeSelection == DateRangeType.LASTMONTH ? ColorType.PRIMARY : ColorType.DEFAULT;
            btnThisYear.BorderColorType = _rangeSelection == DateRangeType.THISYEAR ? ColorType.PRIMARY : ColorType.DEFAULT;
            btnLastYear.BorderColorType = _rangeSelection == DateRangeType.LASTYEAR ? ColorType.PRIMARY : ColorType.DEFAULT;
            btnCustom.BorderColorType = _rangeSelection == DateRangeType.CUSTOM ? ColorType.PRIMARY : ColorType.DEFAULT;
        }

        private void LoadDate()
        {
            ShowPanel("DATE");
            int year = (int)btnShowYear.Tag;
            int month = (int)btnShowMonth.Tag;

            for (int i = 0; i < pnlDate.Controls.Count; i++)
            {
                var btn = (MaterialButton)pnlDate.Controls[i];
                if (btn == null)
                    continue;

                int x = (btn.Name.Replace("btnDate", "").Split('x')[0] + "").GetInt32Value();
                int y = (btn.Name.Replace("btnDate", "").Split('x')[1] + "").GetInt32Value();

                if (y == 0)
                    continue;
                btn.Enabled = false;
                btn.Text = "";
                btn.Tag = null;
                btn.ColorStyle = (x == 0 || x == 6) ? ColorType.DANGER : ColorType.DEFAULT;
                btn.BorderColorType = ColorType.DEFAULT;
            }

            DateTime startDT = new DateTime(year, month, 1).Date;
            DateTime endDT = startDT.AddMonths(1).AddDays(-1).Date;
            int startDay = (int)startDT.DayOfWeek;
            int row = 1;

            while (startDT.Date <= endDT.Date)
            {
                for (int i = startDay; i < 7; i++)
                {
                    var btn = (MaterialButton)pnlDate.GetChildControlByName(string.Format("btnDate{0}x{1}", i, row));
                    btn.Text = startDT.Day.ToString();
                    btn.Tag = startDT.Date;
                    btn.Enabled = true;
                    if (startDT.Date == DateTime.Now.Date)
                    {
                        btn.ColorStyle = ColorType.SUCCESS;
                        btn.BorderColorType = ColorType.SUCCESS;
                    }

                    if (startDT.Date >= _startValue.Date && startDT.Date <= _endValue.Date)
                    {
                        btn.ColorStyle = ColorType.PRIMARY;
                        btn.BorderColorType = ColorType.PRIMARY;
                        if (_selectedBtn == null)
                            _selectedBtn = btn;
                    }

                    startDT = startDT.AddDays(1);
                    if (startDT.Date > endDT.Date)
                        break;
                }
                row++;

                startDay = 0;
            }
        }

        private void LoadYear()
        {
            ShowPanel("YEAR");
            _minYear = ((int)btnShowYear.Tag) - _yearPos;
            int yearCount = _minYear;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    var btn = (MaterialButton)pnlMonthYear.GetChildControlByName(string.Format("btnMonthYear{0}x{1}", x, y));
                    btn.Tag = yearCount;
                    btn.Text = yearCount.ToString();
                    btn.ColorStyle = ColorType.DEFAULT;
                    btn.BorderColorType = ColorType.DEFAULT;
                    if (yearCount == CurrentValue.Year)
                    {
                        btn.ColorStyle = ColorType.PRIMARY;
                        btn.BorderColorType = ColorType.PRIMARY;
                    }
                    yearCount++;
                }
            }
        }

        private void LoadMonth()
        {
            ShowPanel("MONTH");
            var month = new DateTime(2000, 1, 1);
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    var btn = (MaterialButton)pnlMonthYear.GetChildControlByName(string.Format("btnMonthYear{0}x{1}", x, y));
                    btn.Tag = month.Month;
                    btn.Text = month.ToString("MMMM");
                    btn.ColorStyle = ColorType.DEFAULT;
                    btn.BorderColorType = ColorType.DEFAULT;
                    if (month.Month == CurrentValue.Month)
                    {
                        btn.ColorStyle = ColorType.PRIMARY;
                        btn.BorderColorType = ColorType.PRIMARY;
                    }
                    month = month.AddMonths(1);
                }
            }
        }

        private void LoadTime()
        {
            ShowPanel("TIME");
            string timeStr = btnStartTime.Tag + "";
            if (IsSelectEndDate)
                timeStr = btnEndTime.Tag + "";

            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";
            timeStr = "2000-01-01 " + timeStr;
            var timeValue = DateTime.ParseExact(timeStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            btnHour.Text = timeValue.ToString("hh");
            btnHour.Tag = timeValue.ToString("hh");
            btnHourPrev.Text = timeValue.AddHours(-1).ToString("hh");
            btnHourPrev.Tag = timeValue.AddHours(-1).ToString("hh");
            btnHourNext.Text = timeValue.AddHours(1).ToString("hh");
            btnHourNext.Tag = timeValue.AddHours(1).ToString("hh");

            btnMin.Text = timeValue.ToString("mm");
            btnMin.Tag = timeValue.ToString("mm");
            btnMinPrev.Text = timeValue.AddMinutes(-1).ToString("mm");
            btnMinPrev.Tag = timeValue.AddMinutes(-1).ToString("mm");
            btnMinNext.Text = timeValue.AddMinutes(1).ToString("mm");
            btnMinNext.Tag = timeValue.AddMinutes(1).ToString("mm");

            btnAMPM.Text = timeValue.ToString("tt");
            btnAMPM.Tag = timeValue.ToString("tt");
        }

        private void ShowPanel(string panel)
        {
            _shownPanel = panel;
            pnlMonthYear.Dock = DockStyle.Fill;
            pnlDate.Dock = DockStyle.Fill;
            pnlTime.Dock = DockStyle.Fill;
            pnlDateRange.Dock = DockStyle.Fill;
            pnlNavigation.Visible = true;
            pnlMonthYear.Visible = false;
            pnlDate.Visible = false;
            pnlTime.Visible = false;
            pnlDateRange.Visible = false;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            pnlNavigation.Visible = true;

            if (panel == "DATE")
            {
                pnlDate.Dock = DockStyle.Fill;
                pnlDate.Visible = true;
                SetDateButtonSize();
            }
            else if (panel == "MONTH")
            {
                pnlMonthYear.Dock = DockStyle.Fill;
                pnlMonthYear.Visible = true;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                SetMonthButtonSize();
            }
            else if (panel == "YEAR")
            {
                pnlMonthYear.Dock = DockStyle.Fill;
                pnlMonthYear.Visible = true;
                SetMonthButtonSize();
            }
            else if (panel == "TIME")
            {
                pnlTime.Dock = DockStyle.Fill;
                pnlTime.Visible = true;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                SetTimeButtonSize();
            }
            else if (panel == "DATERANGE")
            {
                pnlNavigation.Visible = false;
                pnlDateRange.Dock = DockStyle.Fill;
                pnlDateRange.Visible = true;
                SetDateRangeButtonSize();
            }
        }

        private void MoveHour(int step)
        {
            string timeStr = btnStartTime.Tag + "";
            if (IsSelectEndDate)
                timeStr = btnEndTime.Tag + "";

            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";
            timeStr = "2000-01-01 " + timeStr;
            var timeValue = DateTime.ParseExact(timeStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            timeValue = timeValue.AddHours(step);
            SetTimeValue(timeValue);
            LoadTime();
        }

        private void MoveMin(int step)
        {
            string timeStr = btnStartTime.Tag + "";
            if (IsSelectEndDate)
                timeStr = btnEndTime.Tag + "";

            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";
            timeStr = "2000-01-01 " + timeStr;
            var timeValue = DateTime.ParseExact(timeStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            timeValue = timeValue.AddMinutes(step);
            SetTimeValue(timeValue);
            LoadTime();
        }

        private void SetTimeValue(DateTime timeValue)
        {
            if (IsSelectEndDate)
            {
                btnEndTime.Text = timeValue.ToString("hh:mm tt");
                btnEndTime.Tag = timeValue.ToString("hh:mm tt");
            }
            else
            {
                btnStartTime.Text = timeValue.ToString("hh:mm tt");
                btnStartTime.Tag = timeValue.ToString("hh:mm tt");
            }

            string timeStr = btnStartTime.Tag + "";
            if (IsSelectEndDate)
                timeStr = btnEndTime.Tag + "";

            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";

            var dtStr = CurrentValue.ToString("yyyy-MM-dd") + " " + timeStr;
            var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            CurrentValue = ShowTime ? dtValue : dtValue.Date;
        }

        private void MaterialDatePickerForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            //if (_selectedBtn != null && _selectedBtn.Tag != null)
            //{
            //    _selectedBtn.ColorStyle = (CurrentValue.DayOfWeek == DayOfWeek.Sunday || CurrentValue.DayOfWeek == DayOfWeek.Saturday) ? ColorType.DANGER : ColorType.DEFAULT;
            //    _selectedBtn.BorderColorType = ((DateTime)_selectedBtn.Tag).Date == DateTime.Now.Date ? ColorType.SUCCESS : ColorType.DEFAULT;
            //}

            _selectedBtn = (MaterialButton)sender;
            //_selectedBtn.ColorStyle = ColorType.PRIMARY;
            //_selectedBtn.BorderColorType = ColorType.PRIMARY;

            var timeStr = btnStartTime.Tag + "";
            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";

            var dtStr = ((DateTime)_selectedBtn.Tag).ToString("yyyy-MM-dd") + " " + timeStr;
            var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            CurrentValue = ShowTime ? dtValue : dtValue.Date;
            RangeSelection = DateRangeType.CUSTOM;
            if (!IsSelectEndDate)
                IsSelectEndDate = true;
            LoadDate();
        }

        private void btnMonthYear_Click(object sender, EventArgs e)
        {
            var btn = (MaterialButton)sender;
            if (_shownPanel == "MONTH")
            {
                btnShowMonth.Tag = Convert.ToInt32(btn.Tag);
                btnShowMonth.Text = new DateTime(2000, (int)btnShowMonth.Tag, 1).ToString("MMMM");
            }
            else if (_shownPanel == "YEAR")
            {
                btnShowYear.Tag = Convert.ToInt32(btn.Tag);
                btnShowYear.Text = btn.Tag.ToString();
            }
            LoadDate();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int year = (int)btnShowYear.Tag;
            int month = (int)btnShowMonth.Tag;
            if (_shownPanel == "DATE")
            {
                DateTime prev = new DateTime(year, month, 1).AddMonths(-1);
                btnShowYear.Tag = prev.Year;
                btnShowYear.Text = prev.Year.ToString();
                btnShowMonth.Tag = prev.Month;
                btnShowMonth.Text = prev.ToString("MMMM");
                LoadDate();
            }
            else if (_shownPanel == "YEAR")
            {
                btnShowYear.Tag = (_minYear + _yearPos) - 12;
                btnShowYear.Text = btnShowYear.Tag.ToString();
                LoadYear();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int year = (int)btnShowYear.Tag;
            int month = (int)btnShowMonth.Tag;
            if (_shownPanel == "DATE")
            {
                DateTime next = new DateTime(year, month, 1).AddMonths(1);
                btnShowYear.Tag = next.Year;
                btnShowYear.Text = next.Year.ToString();
                btnShowMonth.Tag = next.Month;
                btnShowMonth.Text = next.ToString("MMMM");
                LoadDate();
            }
            else if (_shownPanel == "YEAR")
            {
                btnShowYear.Tag = (_minYear + _yearPos) + 12;
                btnShowYear.Text = btnShowYear.Tag.ToString();
                LoadYear();
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, StartValue, EndValue, _rangeSelection);
            this.Close();
        }

        private void btnStartDate_Click(object sender, EventArgs e)
        {
            IsSelectEndDate = false;
            btnShowYear.Tag = CurrentValue.Year;
            btnShowYear.Text = CurrentValue.Year.ToString();
            btnShowMonth.Tag = CurrentValue.Month;
            btnShowMonth.Text = CurrentValue.ToString("MMMM");
            LoadDate();
        }

        private void btnEndDate_Click(object sender, EventArgs e)
        {
            IsSelectEndDate = true;
            btnShowYear.Tag = CurrentValue.Year;
            btnShowYear.Text = CurrentValue.Year.ToString();
            btnShowMonth.Tag = CurrentValue.Month;
            btnShowMonth.Text = CurrentValue.ToString("MMMM");
            LoadDate();
        }

        private void btnStartTimeValue_Click(object sender, EventArgs e)
        {
            IsSelectEndDate = false;
            LoadTime();
        }

        private void btnEndTimeValue_Click(object sender, EventArgs e)
        {
            IsSelectEndDate = true;
            LoadTime();
        }

        private void btnSetHour_Click(object sender, EventArgs e)
        {
            string hour = (((Control)sender).Tag + "");
            string timeStr = hour + ":" + btnMin.Tag + " " + btnAMPM.Tag;
            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";
            timeStr = "2000-01-01 " + timeStr;
            var timeValue = DateTime.ParseExact(timeStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            SetTimeValue(timeValue);
            LoadTime();
        }

        private void btnSetMin_Click(object sender, EventArgs e)
        {
            string min = (((Control)sender).Tag + "");
            string timeStr = btnHour.Tag + ":" + min + " " + btnAMPM.Tag;
            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";
            timeStr = "2000-01-01 " + timeStr;
            var timeValue = DateTime.ParseExact(timeStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            SetTimeValue(timeValue);
            LoadTime();
        }

        private void btnAMPM_Click(object sender, EventArgs e)
        {
            string val = btnAMPM.Text == "AM" ? "PM" : "AM";
            btnAMPM.Text = val;
            btnAMPM.Tag = val;
            string timeStr = btnHour.Tag + ":" + btnMin.Tag + " " + btnAMPM.Tag;
            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";
            timeStr = "2000-01-01 " + timeStr;
            var timeValue = DateTime.ParseExact(timeStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            SetTimeValue(timeValue);
        }

        private void btnMoveHour_MouseDown(object sender, MouseEventArgs e)
        {
            _hourStep = (((Control)sender).Tag + "").GetInt32Value();
            MoveHour(_hourStep);
            _timerInterval = 500;
            timerMain.Interval = _timerInterval;
            timerMain.Enabled = true;
            timerMain.Start();
        }

        private void btnMoveHour_MouseUp(object sender, MouseEventArgs e)
        {
            _hourStep = 0;
            _timerInterval = 500;
            timerMain.Enabled = false;
            timerMain.Stop();
        }

        private void btnMoveMin_MouseDown(object sender, MouseEventArgs e)
        {
            _minStep = (((Control)sender).Tag + "").GetInt32Value();
            MoveMin(_minStep);
            _timerInterval = 500;
            timerMain.Interval = _timerInterval;
            timerMain.Enabled = true;
            timerMain.Start();
        }

        private void btnMoveMin_MouseUp(object sender, MouseEventArgs e)
        {
            _minStep = 0;
            _timerInterval = 500;
            timerMain.Enabled = false;
            timerMain.Stop();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if (_hourStep != 0)
            {
                if (_timerInterval > 100)
                    _timerInterval -= 100;
                MoveHour(_hourStep);
                timerMain.Interval = _timerInterval;
            }
            else if (_minStep != 0)
            {
                if (_timerInterval > 100)
                    _timerInterval -= 100;
                MoveMin(_minStep);
                timerMain.Interval = _timerInterval;
            }
        }

        private void btnDateRangeType_Click(object sender, EventArgs e)
        {
            string range = ((Control)sender).Tag + "";
            Enum.TryParse(range, out _rangeSelection);
            if (_rangeSelection == DateRangeType.CUSTOM)
            {
                LoadDate();
                return;
            }

            //btnSelectDateRange.Text = ((Control)sender).Text;
            //btnSelectDateRange.Tag = range;
            RangeSelection = _rangeSelection;
            var startDate = DateTime.Now.Date;
            var endDate = DateTime.Now.Date;
            Extenstions.GetDateRange(_rangeSelection.ToString(), "00:00", out startDate, out endDate);
            StartValue = startDate;
            EndValue = endDate;
            IsSelectEndDate = true;

            btnShowYear.Tag = CurrentValue.Year;
            btnShowYear.Text = CurrentValue.Year.ToString();
            btnShowMonth.Tag = CurrentValue.Month;
            btnShowMonth.Text = CurrentValue.ToString("MMMM");
            LoadDate();
        }

        private void btnSelectDateRange_Click(object sender, EventArgs e)
        {
            ShowPanel("DATERANGE");
        }
    }

    public delegate void DateRangeChangedHandler(object sender, DateTime startValue, DateTime endValue, DateRangeType rangeType);
}
