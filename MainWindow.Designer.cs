
namespace TimeLogger
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timeLoggerDataGridView = new System.Windows.Forms.DataGridView();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.appTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLoggerDataGridView)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.saveButton);
            this.mainPanel.Controls.Add(this.timeLoggerDataGridView);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 0;
            // 
            // timeLoggerDataGridView
            // 
            this.timeLoggerDataGridView.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.timeLoggerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeLoggerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLoggerDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.timeLoggerDataGridView.Location = new System.Drawing.Point(0, 35);
            this.timeLoggerDataGridView.Name = "timeLoggerDataGridView";
            this.timeLoggerDataGridView.Size = new System.Drawing.Size(796, 411);
            this.timeLoggerDataGridView.TabIndex = 1;
            this.timeLoggerDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TimeLoggerDataGridView_CellValueChanged);
            this.timeLoggerDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeLoggerDataGridView__CellValidated);
            this.timeLoggerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeLoggerDataGridView_CellClick);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.appTitle);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.minimiseButton);
            this.headerPanel.Controls.Add(this.quitButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(796, 35);
            this.headerPanel.TabIndex = 0;
            // 
            // appTitle
            // 
            this.appTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.appTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appTitle.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(47, 0);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(660, 30);
            this.appTitle.TabIndex = 3;
            this.appTitle.Text = "Time Logger";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseMove);

            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::TimeLogger.Properties.Resources.gnome_calendar_icon;
            this.pictureBox1.InitialImage = global::TimeLogger.Properties.Resources.gnome_calendar_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // minimiseButton
            // 
            this.minimiseButton.AutoSize = true;
            this.minimiseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minimiseButton.BackColor = System.Drawing.Color.Transparent;
            this.minimiseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimiseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseButton.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiseButton.Location = new System.Drawing.Point(713, 0);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.minimiseButton.Size = new System.Drawing.Size(38, 33);
            this.minimiseButton.TabIndex = 0;
            this.minimiseButton.TabStop = false;
            this.minimiseButton.Text = "-";
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.AutoSize = true;
            this.quitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(751, 0);
            this.quitButton.Name = "quitButton";
            this.quitButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.quitButton.Size = new System.Drawing.Size(43, 33);
            this.quitButton.TabIndex = 1;
            this.quitButton.TabStop = false;
            this.quitButton.Text = "x";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(0, 412);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.saveButton.Size = new System.Drawing.Size(796, 34);
            this.saveButton.TabIndex = 4;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save Data";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Logger";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLoggerDataGridView)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimiseButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.DataGridView timeLoggerDataGridView;
        private System.Windows.Forms.Button saveButton;
    }
}

