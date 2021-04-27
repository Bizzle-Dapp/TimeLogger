using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TimeLogger
{
    public partial class MainWindow : Form
    {
        BindingList<TimeEntry> timeEntries = new BindingList<TimeEntry>();
        DateTimePicker dtp;
        public MainWindow()
        {
            InitializeComponent();
            InitializeDataStore();
            GenerateDataGrid();
        }

        public void InitializeDataStore()
        {
            try
            {
                if (File.Exists("C:\\TimeLogger\\Data.json"))
                {
                    var content = File.ReadAllText("C:\\TimeLogger\\Data.json");
                    var jContent = JsonConvert.DeserializeObject<List<TimeEntry>>(content);
                    timeEntries = new BindingList<TimeEntry>(jContent);
                }
                else
                {

                    Directory.CreateDirectory("C:\\TimeLogger\\");
                    File.Create("C:\\TimeLogger\\Data.json");
                    MessageBox.Show("Initialized new JSON data store");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Please provide this error message to the developers:{Environment.NewLine}{e.Message}", "Oh no! Something went wrong!");
            }
        }


        public void GenerateDataGrid()
        {
            timeLoggerDataGridView.AutoGenerateColumns = false;
            timeLoggerDataGridView.AutoSize = true;
            timeLoggerDataGridView.DataSource = new BindingSource(timeEntries, null);
            
            timeLoggerDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Task Name",
                DataPropertyName = "TaskName",
                HeaderText = "Task Name"
            });
            timeLoggerDataGridView.Columns.Add(new DataGridViewComboBoxColumn()
            {
                Name = "Task Type",
                HeaderText = "Task Type",
                DataSource = Enum.GetValues(typeof(TimeEntryTask)),
                DataPropertyName = "TaskType",
                ValueType = typeof(TimeEntryTask)
            });
            timeLoggerDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Task Code",
                DataPropertyName = "TaskCode",
                HeaderText = "Task Code"
            });
            timeLoggerDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Time",
                DataPropertyName = "TimeSpent",
                HeaderText = "Time Spent (Hours)",
                ValueType = typeof(double)
            });
            timeLoggerDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Date",
                DataPropertyName = "Date",
                HeaderText = "Date",
                ValueType = typeof(DateTime)
            });
            timeLoggerDataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Comment",
                DataPropertyName = "Notes",
                HeaderText = "Comment",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void TimeLoggerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1) { return; }
            // determine if click was on our date column
            if (timeLoggerDataGridView.Columns[e.ColumnIndex].DataPropertyName == "Date")
            {
                // cleanup existing
                if (dtp != null)
                {
                    dtp.Visible = false;
                    dtp.Dispose();
                }
                if (e.RowIndex == -1) return;
                // initialize DateTimePicker
                dtp = new DateTimePicker();
                dtp.Format = DateTimePickerFormat.Short;
                dtp.Visible = true;
                try
                {
                    dtp.Value = DateTime.Parse(timeLoggerDataGridView.CurrentCell?.Value?.ToString());
                }
                catch
                {
                    dtp.Value = DateTime.Now;
                }

                // set size and location
                var rect = timeLoggerDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(rect.Width, rect.Height);
                dtp.Location = new Point(rect.X, rect.Y);

                // attach events
                dtp.CloseUp += new EventHandler(DateTimePicker_CloseUp);
                dtp.TextChanged += new EventHandler(DateTimePicker_OnTextChange);

                timeLoggerDataGridView.Controls.Add(dtp);
            }
            else
            {
                if(dtp != null)
                {
                    dtp.Visible = false;
                    dtp.Dispose();
                    return;
                }
                
            }
        }

        private void DateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            timeLoggerDataGridView.CurrentCell.Value = dtp.Text.ToString();
            dtp.Visible = false;
            dtp.Dispose();
        }

        // on close of cell, hide dtp
        void DateTimePicker_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var jTimeEntries = JsonConvert.SerializeObject(timeEntries);
            File.WriteAllText("C:\\TimeLogger\\Data.json", jTimeEntries);
        }


        #region Cell Validation
        private void TimeLoggerDataGridView_CellValueChanged(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double testdouble;
            
            if(e.ColumnIndex == 3)
            {
                if (e.FormattedValue.ToString().Length != 0)
                {
                    // Try to convert the cell value to an int.
                    if (!double.TryParse(e.FormattedValue.ToString(), out testdouble))
                    {
                        timeLoggerDataGridView.Rows[e.RowIndex].ErrorText =
                            "Error: Only Numbers Are Accepted";
                        e.Cancel = true;
                    }
                }
            }
        }

        private void TimeLoggerDataGridView__CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Clear any error messages that may have been set in cell validation.
            timeLoggerDataGridView.Rows[e.RowIndex].ErrorText = null;
        }
        #endregion

        
        #region Header Buttons
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MinimiseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
        
    }
}
