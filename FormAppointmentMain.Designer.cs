namespace Software2Csharp
{
    partial class FormAppointmentMain
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
            this.labelHelloUsr = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.guna2ButtonCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAppointments = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHelloUsr
            // 
            this.labelHelloUsr.AutoSize = true;
            this.labelHelloUsr.Location = new System.Drawing.Point(29, 27);
            this.labelHelloUsr.Name = "labelHelloUsr";
            this.labelHelloUsr.Size = new System.Drawing.Size(59, 13);
            this.labelHelloUsr.TabIndex = 0;
            this.labelHelloUsr.Text = "Hello, User";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Honeydew;
            this.panelTop.Controls.Add(this.guna2ButtonAppointments);
            this.panelTop.Controls.Add(this.labelHelloUsr);
            this.panelTop.Controls.Add(this.guna2ButtonCustomers);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(946, 64);
            this.panelTop.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Wheat;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 64);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(946, 476);
            this.panelContainer.TabIndex = 2;
            // 
            // guna2ButtonCustomers
            // 
            this.guna2ButtonCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ButtonCustomers.BorderThickness = 1;
            this.guna2ButtonCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCustomers.FillColor = System.Drawing.Color.White;
            this.guna2ButtonCustomers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonCustomers.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonCustomers.Location = new System.Drawing.Point(283, 12);
            this.guna2ButtonCustomers.Name = "guna2ButtonCustomers";
            this.guna2ButtonCustomers.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonCustomers.TabIndex = 1;
            this.guna2ButtonCustomers.Text = "Customers";
            this.guna2ButtonCustomers.Click += new System.EventHandler(this.guna2ButtonCustomers_Click);
            // 
            // guna2ButtonAppointments
            // 
            this.guna2ButtonAppointments.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2ButtonAppointments.BorderThickness = 1;
            this.guna2ButtonAppointments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAppointments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAppointments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAppointments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAppointments.FillColor = System.Drawing.Color.White;
            this.guna2ButtonAppointments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonAppointments.ForeColor = System.Drawing.Color.Black;
            this.guna2ButtonAppointments.Location = new System.Drawing.Point(469, 12);
            this.guna2ButtonAppointments.Name = "guna2ButtonAppointments";
            this.guna2ButtonAppointments.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonAppointments.TabIndex = 2;
            this.guna2ButtonAppointments.Text = "Appointments";
            this.guna2ButtonAppointments.Click += new System.EventHandler(this.guna2ButtonAppointments_Click);
            // 
            // FormAppointmentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 540);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTop);
            this.Name = "FormAppointmentMain";
            this.Text = "FormAppointmentMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAppointmentMain_FormClosed);
            this.Load += new System.EventHandler(this.FormAppointmentMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHelloUsr;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCustomers;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAppointments;
    }
}