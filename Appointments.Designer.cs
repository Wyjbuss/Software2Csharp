namespace Software2Csharp
{
    partial class Appointments
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelAppointments = new System.Windows.Forms.Label();
            this.guna2ButtonUpdateAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDeleteAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonCreateNewAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.monthCalendarAppointments = new System.Windows.Forms.MonthCalendar();
            this.guna2DataGridViewAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppointments
            // 
            this.labelAppointments.AutoSize = true;
            this.labelAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointments.Location = new System.Drawing.Point(3, 10);
            this.labelAppointments.Name = "labelAppointments";
            this.labelAppointments.Size = new System.Drawing.Size(264, 46);
            this.labelAppointments.TabIndex = 1;
            this.labelAppointments.Text = "Appointments";
            // 
            // guna2ButtonUpdateAppointment
            // 
            this.guna2ButtonUpdateAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ButtonUpdateAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUpdateAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUpdateAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonUpdateAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonUpdateAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonUpdateAppointment.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonUpdateAppointment.Location = new System.Drawing.Point(11, 365);
            this.guna2ButtonUpdateAppointment.Name = "guna2ButtonUpdateAppointment";
            this.guna2ButtonUpdateAppointment.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonUpdateAppointment.TabIndex = 6;
            this.guna2ButtonUpdateAppointment.Text = "Update Appointment";
            this.guna2ButtonUpdateAppointment.Click += new System.EventHandler(this.guna2ButtonUpdateAppointment_Click);
            // 
            // guna2ButtonDeleteAppointment
            // 
            this.guna2ButtonDeleteAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ButtonDeleteAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonDeleteAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonDeleteAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonDeleteAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonDeleteAppointment.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDeleteAppointment.Location = new System.Drawing.Point(11, 416);
            this.guna2ButtonDeleteAppointment.Name = "guna2ButtonDeleteAppointment";
            this.guna2ButtonDeleteAppointment.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonDeleteAppointment.TabIndex = 5;
            this.guna2ButtonDeleteAppointment.Text = "Delete Appointment";
            this.guna2ButtonDeleteAppointment.Click += new System.EventHandler(this.guna2ButtonDeleteAppointment_Click);
            // 
            // guna2ButtonCreateNewAppointment
            // 
            this.guna2ButtonCreateNewAppointment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCreateNewAppointment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCreateNewAppointment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCreateNewAppointment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCreateNewAppointment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonCreateNewAppointment.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonCreateNewAppointment.Location = new System.Drawing.Point(11, 73);
            this.guna2ButtonCreateNewAppointment.Name = "guna2ButtonCreateNewAppointment";
            this.guna2ButtonCreateNewAppointment.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonCreateNewAppointment.TabIndex = 4;
            this.guna2ButtonCreateNewAppointment.Text = "Create New Appointment";
            this.guna2ButtonCreateNewAppointment.Click += new System.EventHandler(this.guna2ButtonCreateNewAppointment_Click);
            // 
            // monthCalendarAppointments
            // 
            this.monthCalendarAppointments.Location = new System.Drawing.Point(11, 159);
            this.monthCalendarAppointments.Name = "monthCalendarAppointments";
            this.monthCalendarAppointments.TabIndex = 7;
            this.monthCalendarAppointments.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarAppointments_DateChanged);
            this.monthCalendarAppointments.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarAppointments_DateSelected);
            // 
            // guna2DataGridViewAppointments
            // 
            this.guna2DataGridViewAppointments.AllowUserToAddRows = false;
            this.guna2DataGridViewAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridViewAppointments.ColumnHeadersHeight = 4;
            this.guna2DataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridViewAppointments.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridViewAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewAppointments.Location = new System.Drawing.Point(330, 35);
            this.guna2DataGridViewAppointments.MultiSelect = false;
            this.guna2DataGridViewAppointments.Name = "guna2DataGridViewAppointments";
            this.guna2DataGridViewAppointments.ReadOnly = true;
            this.guna2DataGridViewAppointments.RowHeadersVisible = false;
            this.guna2DataGridViewAppointments.Size = new System.Drawing.Size(551, 399);
            this.guna2DataGridViewAppointments.TabIndex = 8;
            this.guna2DataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridViewAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewAppointments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridViewAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridViewAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridViewAppointments.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridViewAppointments.ThemeStyle.ReadOnly = true;
            this.guna2DataGridViewAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridViewAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridViewAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridViewAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridViewAppointments.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridViewAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridViewAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2DataGridViewAppointments);
            this.Controls.Add(this.monthCalendarAppointments);
            this.Controls.Add(this.guna2ButtonUpdateAppointment);
            this.Controls.Add(this.guna2ButtonDeleteAppointment);
            this.Controls.Add(this.guna2ButtonCreateNewAppointment);
            this.Controls.Add(this.labelAppointments);
            this.Name = "Appointments";
            this.Size = new System.Drawing.Size(946, 476);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointments;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUpdateAppointment;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeleteAppointment;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCreateNewAppointment;
        private System.Windows.Forms.MonthCalendar monthCalendarAppointments;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewAppointments;
    }
}
