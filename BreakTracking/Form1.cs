using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BreakTracking.Repository;
using BreakTracking.Domain.Models;
using BreakTracking.Aplication.ViewModel;
using BreakTracking.Aplication.Utilities;
using BreakTracking.Context;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BreakTracking
{
    public partial class Form1 : Form
    {
        private BreakTrackingContext _context;
        private UnitOfWork uow;

        public Form1(BreakTrackingContext context)
        {


            _context = context;
            uow = new UnitOfWork(_context);
            InitializeComponent();

            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("es-ES");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;

            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = culture.DateTimeFormat.FullDateTimePattern;

            this.WeekGrid();
            this.WeekCombo();

            this.SuspendLayout();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            SetWeeklyDataGridView((int)cbWeekSelection.SelectedValue);

            var selectedRow = dataGridView1.Rows.Cast<DataGridViewRow>().ToList().Where(w => w.Selected == true).FirstOrDefault();

            int employeeId = (int)selectedRow.Cells[0].Value;

            DateTime dateCalendar = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime endDate = dateCalendar.Add(new TimeSpan(23, 59, 00));

            var wt = uow.WorkTimeRepository.Get(w => w.EmployeeId == employeeId && w.StartTime >= dateCalendar && w.StartTime < endDate).FirstOrDefault();

            if (wt != null)
            {
                txtStartTime.Text = wt.StartTime.TimeOfDay.ToString().Substring(0,5);
                txtEndTime.Text = wt.EndTime.TimeOfDay.ToString().Substring(0, 5);
            }
            else
            {
                txtStartTime.Text = "";
                txtEndTime.Text = "";
            }

            lblSaveMsg.Text = "";
            lblSaveMsg.Visible = false;
            

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            // Calculate amount code goes here
        }
        private void txtEmployeeNameFilter_TextChanged(object sender, EventArgs e)
        {
            string text = txtEmployeeNameFilter.Text;
            int resultCount = 0;

            if (text.Length == 0) 
            {
                this.lblFilterResultMsg.Text = String.Empty;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;
                }
            }
            else if (text.Length > 0 && text.Length < 3)
            {
                this.lblFilterResultMsg.Text = "Please type at least three letter to use the Name as a filter.";

            }
            else 
            {
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Visible = true;

                    if (!row.Cells[1].Value.ToString().ToUpper().Contains(text.ToUpper())) 
                    {
                        row.Visible = false;
                    }

                }
                resultCount = dataGridView1.Rows.Cast<DataGridViewRow>().ToList().Where(w => w.Visible == true).Count();

                this.lblFilterResultMsg.Text = resultCount >= 1 ? resultCount.ToString(): this.lblFilterResultMsg.Text = "No results found.";
                
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.Rows.Cast<DataGridViewRow>().ToList().Where(w => w.Selected == true).FirstOrDefault();

            int employeeId = (int)selectedRow.Cells[0].Value;

            DateTime dateCalendar = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime endDate = dateCalendar.Add(new TimeSpan(23, 59, 00));

            var wt = uow.WorkTimeRepository.Get(w => w.EmployeeId == employeeId && w.StartTime >= dateCalendar && w.StartTime < endDate).FirstOrDefault();

            if (wt != null)
            {
                txtStartTime.Text = wt.StartTime.TimeOfDay.ToString().Substring(0, 5);
                txtEndTime.Text = wt.EndTime.TimeOfDay.ToString().Substring(0, 5);
            }
            else 
            {
                txtStartTime.Text = "";
                txtEndTime.Text = "";
            }
            

        }

        private void cbWeekSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeId = 0;

            var selectedRow = dataGridView1.Rows.Cast<DataGridViewRow>().ToList().Where(w => w.Selected == true).FirstOrDefault();

            
            if (selectedRow != null) 
            {
                var week = cbWeekSelection.SelectedValue;

                employeeId = (int)selectedRow.Cells[0].Value;


                SetWeeklyDataGridView((int)week);

            }
            

        }

        private void WeekCombo() 
        {
            List<int> weekLst = WeekUtilities.GetAllWeekNumberOfYear(DateTime.Now.Year);
            List<ComboWeekViewModelcs> comboWeekViewModelcs = new List<ComboWeekViewModelcs>();

            weekLst.ForEach(f => {

                var fistWeekDay = WeekUtilities.FirstDateOfWeek(DateTime.Now.Year, f);
                var lastWeekDay = fistWeekDay.AddDays(6);

                var shotdate = fistWeekDay.Date.ToShortDateString();

                comboWeekViewModelcs.Add(new ComboWeekViewModelcs() { Week = f, WeekDetail = f + " - " + fistWeekDay.Date.ToShortDateString()  + " to " + lastWeekDay.Date.ToShortDateString() });
                
            });

            cbWeekSelection.DataSource = comboWeekViewModelcs;
            cbWeekSelection.DisplayMember = "WeekDetail";
            cbWeekSelection.ValueMember = "Week";

            cbWeekSelection.SelectedValue = WeekUtilities.GetWeekOfYear(DateTime.Now);
        }

        private void WeekGrid() 
        {
            dataGridView2.Rows.Add("Mo", "", "", "", "");
            dataGridView2.Rows.Add("Tu", "", "", "", "");
            dataGridView2.Rows.Add("We", "", "", "", "");
            dataGridView2.Rows.Add("Th", "", "", "", "");
            dataGridView2.Rows.Add("Fr", "", "", "", "");
            dataGridView2.Rows.Add("Sa", "", "", "", "");
            dataGridView2.Rows.Add("Su", "", "", "", "");
            dataGridView2.Rows.Add();
            dataGridView2.Rows.Add("Week", "", "", "", "");
        }

        private void SetWeeklyDataGridView(int weekOfWork) 
        {
            dataGridView2.Rows.Clear();
            WeekGrid();
            TimeSpan totalWeekWorkTime = new TimeSpan();
            TimeSpan totalWeekBreakTime = new TimeSpan();

            List<WorkTime> workTimes = new List<WorkTime>();
            Employee employee;

            int employeeId = 0;
            var selectedRow = dataGridView1.Rows.Cast<DataGridViewRow>().ToList().Where(w => w.Selected == true).FirstOrDefault();

            employeeId = (int)selectedRow.Cells[0].Value;

            employee = uow.EmployeeRepository.GetByID(employeeId);

            lblEmployeeInfNameS.Text = employee.Name;
            lblEmployeeInfNameS.Visible = true;

            lblEmployeeInfDtpS.Text = employee.Department.Name;
            lblEmployeeInfDtpS.Visible = true;

            lblEmployeeInfShiftS.Text = employee.Shift.Name;
            lblEmployeeInfShiftS.Visible = true;

            lblEmployeeInfIdS.Text = employee.Id.ToString();
            lblEmployeeInfIdS.Visible = true;

            workTimes = uow.WorkTimeRepository.Get(w => w.EmployeeId == employeeId).ToList();

            Dictionary<String, DaylyWorkTime> WeeklyWorkTimeValue = new WeeklyWorkTimeViewModelcs().WeeklyWorkTimeValue;

            WeeklyWorkTimeValue = new Aplication.SetWeeklyGrid(_context, employeeId).getWeeklyWorkTime(weekOfWork);

            foreach (var item in WeeklyWorkTimeValue)
            {
                if (item.Value.StartTime != null && item.Value.EndTime != null)
                {
                    var dayRow = dataGridView2.Rows.Cast<DataGridViewRow>().ToList().Where(w => w.Cells[0].Value.ToString() == item.Key).FirstOrDefault();
                    dayRow.Cells[1].Value = item.Value.StartTime.ToString();
                    dayRow.Cells[2].Value = item.Value.EndTime.ToString();
                    dayRow.Cells[3].Value = item.Value.TotalDayTimeOfWork.ToString();
                    dayRow.Cells[4].Value = item.Value.TotalDayBreakTime.ToString();

                    totalWeekWorkTime = totalWeekWorkTime.Add((TimeSpan)item.Value.TotalDayTimeOfWork);
                    totalWeekBreakTime = totalWeekBreakTime.Add((TimeSpan)item.Value.TotalDayBreakTime);
                }



            }

            dataGridView2.Rows[8].Cells[3].Value = string.Format("{0:#,##0}:{1:mm}:{1:ss}", Math.Truncate(totalWeekWorkTime.TotalHours), totalWeekWorkTime);
            dataGridView2.Rows[8].Cells[4].Value = string.Format("{0:#,##0}:{1:mm}:{1:ss}", Math.Truncate(totalWeekBreakTime.TotalHours), totalWeekBreakTime);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.Rows.Cast<DataGridViewRow>().ToList().Where(w => w.Selected == true).FirstOrDefault();

            int employeeId = (int)selectedRow.Cells[0].Value;

            DateTime dateCalendar = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime endDate = dateCalendar.Add(new TimeSpan(23, 59, 00));

            lblSaveMsg.Visible = false;

            string timepattern = @"(?:2[0-3]|[01]?[0-9])[:.][0-5]?[0-9]";

            var returnedValue = Regex.Match(txtStartTime.Text, timepattern);

            if (txtStartTime.Text == String.Empty || txtEndTime.Text == String.Empty)
            {
                lblSaveMsg.Text = "Start Time and End Time are required.";
                //lblSaveMsg.ForeColor = ForeColor.
                lblSaveMsg.Visible = true;
            }
            else if (Regex.Match(txtStartTime.Text, timepattern).Length <= 0 || Regex.Match(txtEndTime.Text, timepattern).Length <= 0)
            {
                lblSaveMsg.Text = "Incorret format for the time. please use HH:ss format.";
                //lblSaveMsg.ForeColor = ForeColor.
                lblSaveMsg.Visible = true;
            }
            else 
            {

                var wt = uow.WorkTimeRepository.Get(w => w.EmployeeId == employeeId && w.StartTime >= dateCalendar && w.StartTime < endDate).FirstOrDefault();

                var Lastwt = uow.WorkTimeRepository.Get().OrderByDescending(o => o.Id).FirstOrDefault().Id;

                if (wt != null)
                {
                    WorkTime worktime = new WorkTime(wt.Id, employeeId, dateCalendar.Add(TimeSpan.Parse(txtStartTime.Text)), dateCalendar.Add(TimeSpan.Parse(txtEndTime.Text)));
                    new WorkTimeRepository(_context).WorkTimeUpdate(worktime);
                }
                else
                {
                    WorkTime worktime = new WorkTime(Lastwt + 1, employeeId, dateCalendar.Add(TimeSpan.Parse(txtStartTime.Text)), dateCalendar.Add(TimeSpan.Parse(txtEndTime.Text)));
                    uow.WorkTimeRepository.Insert(worktime);
                }

                uow.Save();

                SetWeeklyDataGridView((int)cbWeekSelection.SelectedValue);

                lblSaveMsg.Text = "The employee work time has been saved.";
                lblSaveMsg.Visible = true;
            }
        }

        private void txtStartTime_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == ':') return;
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void txtEndTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == ':') return;
            if (e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
           
        }
    }
    
}
