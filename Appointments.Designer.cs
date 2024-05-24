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
            this.labelAppointments = new System.Windows.Forms.Label();
            this.guna2ButtonUpdateAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDeleteAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonCreateNewAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.monthCalendarAppointments = new System.Windows.Forms.MonthCalendar();
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
            this.monthCalendarAppointments.Location = new System.Drawing.Point(355, 39);
            this.monthCalendarAppointments.Name = "monthCalendarAppointments";
            this.monthCalendarAppointments.TabIndex = 7;
            this.monthCalendarAppointments.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarAppointments_DateSelected);
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.monthCalendarAppointments);
            this.Controls.Add(this.guna2ButtonUpdateAppointment);
            this.Controls.Add(this.guna2ButtonDeleteAppointment);
            this.Controls.Add(this.guna2ButtonCreateNewAppointment);
            this.Controls.Add(this.labelAppointments);
            this.Name = "Appointments";
            this.Size = new System.Drawing.Size(946, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointments;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUpdateAppointment;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDeleteAppointment;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCreateNewAppointment;
        private System.Windows.Forms.MonthCalendar monthCalendarAppointments;
    }
}
