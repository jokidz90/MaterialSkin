using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
                btnDateValue.Text = _value.ToString(DateFormat);
                btnTimeValue.Text = _value.ToString("hh:mm tt");
                btnTimeValue.Tag = _value.ToString("hh:mm tt");
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
                btnTimeValue.Visible = value;
                if (!value)
                    tblHeader.ColumnStyles.RemoveAt(1);
            }
            get
            {
                return btnTimeValue.Visible;
            }
        }



        public MaterialDatePickerForm()
        {
            InitializeComponent();
        }

        private void InitForm()
        {
            btnToday.Text = DateTime.Now.ToString(DateFormat);
            SetTimeValue(_value);
            btnShowYear.Tag = _value.Year;
            btnShowYear.Text = _value.Year.ToString();
            btnShowMonth.Tag = _value.Month;
            btnShowMonth.Text = _value.ToString("MMMM");

            LoadDate();
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
                var btn = (MaterialFlatButton)pnlMonthYear.Controls[i];
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
                var btn = (MaterialFlatButton)pnlDate.Controls[i];
                if (btn == null)
                    continue;

                int x = (btn.Name.Replace("btnDate", "").Split('x')[0] + "").GetInt32Value();
                int y = (btn.Name.Replace("btnDate", "").Split('x')[1] + "").GetInt32Value();

                btn.AutoSize = false;
                btn.Size = new Size(btnWidth, btnHeight);
                btn.Location = new Point((x * btnWidth), (y * btnHeight));
            }
        }

        private void MaterialDatePickerForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void LoadDate()
        {
            ShowPanel("DATE");
            int year = (int)btnShowYear.Tag;
            int month = (int)btnShowMonth.Tag;

            for (int i = 0; i < pnlDate.Controls.Count; i++)
            {
                var btn = (MaterialFlatButton)pnlDate.Controls[i];
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

            DateTime startMonth = new DateTime(year, month, 1).Date;
            DateTime endMonth = startMonth.AddMonths(1).AddDays(-1).Date;
            int startDay = (int)startMonth.DayOfWeek;
            int row = 1;

            while (startMonth.Date <= endMonth.Date)
            {
                for (int i = startDay; i < 7; i++)
                {
                    var btn = (MaterialFlatButton)pnlDate.GetChildControlByName(string.Format("btnDate{0}x{1}", i, row));
                    btn.Text = startMonth.Day.ToString();
                    btn.Tag = startMonth.Date;
                    btn.Enabled = true;
                    if (startMonth.Date == DateTime.Now.Date)
                    {
                        btn.ColorStyle = ColorType.SUCCESS;
                        btn.BorderColorType = ColorType.SUCCESS;
                    }

                    if (startMonth.Date == _value.Date)
                    {
                        btn.ColorStyle = ColorType.PRIMARY;
                        btn.BorderColorType = ColorType.PRIMARY;
                        if (_selectedBtn == null)
                            _selectedBtn = btn;
                    }

                    startMonth = startMonth.AddDays(1);
                    if (startMonth.Date > endMonth.Date)
                        break;
                }
                row++;

                startDay = 0;
            }
        }

        private int minYear = 2000;
        private int yearPos = 4;
        private void LoadYear()
        {
            ShowPanel("YEAR");
            minYear = ((int)btnShowYear.Tag) - yearPos;
            int yearCount = minYear;
            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    var btn = (MaterialFlatButton)pnlMonthYear.GetChildControlByName(string.Format("btnMonthYear{0}x{1}", x, y));
                    btn.Tag = yearCount;
                    btn.Text = yearCount.ToString();
                    btn.ColorStyle = ColorType.DEFAULT;
                    btn.BorderColorType = ColorType.DEFAULT;
                    if (yearCount == _value.Year)
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
                    var btn = (MaterialFlatButton)pnlMonthYear.GetChildControlByName(string.Format("btnMonthYear{0}x{1}", x, y));
                    btn.Tag = month.Month;
                    btn.Text = month.ToString("MMMM");
                    btn.ColorStyle = ColorType.DEFAULT;
                    btn.BorderColorType = ColorType.DEFAULT;
                    if (month.Month == _value.Month)
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
            string timeStr = btnTimeValue.Tag + "";
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

        private string _shownPanel = "";
        private void ShowPanel(string panel)
        {
            _shownPanel = panel;
            pnlMonthYear.Dock = DockStyle.Fill;
            pnlDate.Dock = DockStyle.Fill;
            pnlTime.Dock = DockStyle.Fill;
            pnlMonthYear.Visible = false;
            pnlDate.Visible = false;
            pnlTime.Visible = false;
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
        }

        MaterialFlatButton _selectedBtn = null;
        private void btnDate_Click(object sender, EventArgs e)
        {
            if (_selectedBtn != null && _selectedBtn.Tag != null)
            {
                _selectedBtn.ColorStyle = (_value.DayOfWeek == DayOfWeek.Sunday || _value.DayOfWeek == DayOfWeek.Saturday) ? ColorType.DANGER : ColorType.DEFAULT;
                _selectedBtn.BorderColorType = ((DateTime)_selectedBtn.Tag).Date == DateTime.Now.Date ? ColorType.SUCCESS : ColorType.DEFAULT;
            }

            _selectedBtn = (MaterialFlatButton)sender;
            _selectedBtn.ColorStyle = ColorType.PRIMARY;
            _selectedBtn.BorderColorType = ColorType.PRIMARY;

            var timeStr = btnTimeValue.Tag + "";
            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";
            
            var dtStr = ((DateTime)_selectedBtn.Tag).ToString("yyyy-MM-dd") + " " + timeStr;
            var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            Value = ShowTime ? dtValue : dtValue.Date;
        }

        private void btnMonthYear_Click(object sender, EventArgs e)
        {
            var btn = (MaterialFlatButton)sender;
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
                btnShowYear.Tag = (minYear + yearPos)-12;
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
                btnShowYear.Tag = (minYear + yearPos) + 12;
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

        private void btnToday_Click(object sender, EventArgs e)
        {
            Value = ShowTime ? DateTime.Now : DateTime.Now.Date;
            btnShowYear.Tag = _value.Year;
            btnShowYear.Text = _value.Year.ToString();
            btnShowMonth.Tag = _value.Month;
            btnShowMonth.Text = _value.ToString("MMMM");

            LoadDate();

            foreach (Control ctrl in pnlDate.Controls)
            {
                if (!(ctrl is MaterialFlatButton))
                    continue;

                var btn = (MaterialFlatButton)ctrl;
                if (btn == null)
                    continue;
                if (btn.Tag == null)
                    continue;

                if (((DateTime)btn.Tag).Date == _value.Date)
                    _selectedBtn = btn;
            }
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

        private void btnTimeValue_Click(object sender, EventArgs e)
        {
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

        private void MoveHour(int step)
        {
            string timeStr = btnTimeValue.Tag + "";
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
            string timeStr = btnTimeValue.Tag + "";
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
            btnTimeValue.Text = timeValue.ToString("hh:mm tt");
            btnTimeValue.Tag = timeValue.ToString("hh:mm tt");

            var timeStr = btnTimeValue.Tag + "";
            if (string.IsNullOrEmpty(timeStr))
                timeStr = "00:00 AM";

            var dtStr = _value.ToString("yyyy-MM-dd") + " " + timeStr;
            var dtValue = DateTime.ParseExact(dtStr, "yyyy-MM-dd hh:mm tt", CultureInfo.InvariantCulture);
            _value = ShowTime ? dtValue : dtValue.Date;
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

        private int _hourStep = 0;
        private int _timerInterval = 500;
        private void btnNextHour_MouseDown(object sender, MouseEventArgs e)
        {
            _hourStep = 1;
            MoveHour(_hourStep);
            _timerInterval = 500;
            timerMain.Interval = _timerInterval;
            timerMain.Enabled = true;
            timerMain.Start();
        }

        private void btnNextHour_MouseUp(object sender, MouseEventArgs e)
        {
            _hourStep = 0;
            _timerInterval = 500;
            timerMain.Enabled = false;
            timerMain.Stop();
        }

        private void btnPrevHour_MouseDown(object sender, MouseEventArgs e)
        {
            _hourStep = -1;
            MoveHour(_hourStep);
            _timerInterval = 500;
            timerMain.Interval = _timerInterval;
            timerMain.Enabled = true;
            timerMain.Start();
        }

        private void btnPrevHour_MouseUp(object sender, MouseEventArgs e)
        {
            _hourStep = 0;
            _timerInterval = 500;
            timerMain.Enabled = false;
            timerMain.Stop();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("timerMain.Interval:" + timerMain.Interval);
            Debug.WriteLine("_hourStep:" + _hourStep);
            Debug.WriteLine("_minStep:" + _minStep);
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

        private int _minStep = 0;
        private void btnNextMin_MouseDown(object sender, MouseEventArgs e)
        {
            _minStep = 1;
            MoveMin(_minStep);
            _timerInterval = 500;
            timerMain.Interval = _timerInterval;
            timerMain.Enabled = true;
            timerMain.Start();
        }

        private void btnNextMin_MouseUp(object sender, MouseEventArgs e)
        {
            _minStep = 0;
            _timerInterval = 500;
            timerMain.Enabled = false;
            timerMain.Stop();
        }

        private void btnPrevMin_MouseDown(object sender, MouseEventArgs e)
        {
            _minStep = -1;
            MoveMin(_minStep);
            _timerInterval = 500;
            timerMain.Interval = _timerInterval;
            timerMain.Enabled = true;
            timerMain.Start();
        }

        private void btnPrevMin_MouseUp(object sender, MouseEventArgs e)
        {
            _minStep = 0;
            _timerInterval = 500;
            timerMain.Enabled = false;
            timerMain.Stop();
        }
    }

    public delegate void DateChangedHandler(object sender, DateTime value);
}
