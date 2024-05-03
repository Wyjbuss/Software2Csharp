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
            this.guna2ButtonUpdateCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonCreateNewCustomer = new Guna.UI2.WinForms.Guna2Button();
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
            // guna2ButtonUpdateCustomer
            // 
            this.guna2ButtonUpdateCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ButtonUpdateCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUpdateCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonUpdateCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonUpdateCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonUpdateCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonUpdateCustomer.Location = new System.Drawing.Point(11, 365);
            this.guna2ButtonUpdateCustomer.Name = "guna2ButtonUpdateCustomer";
            this.guna2ButtonUpdateCustomer.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonUpdateCustomer.TabIndex = 6;
            this.guna2ButtonUpdateCustomer.Text = "Update Customer";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(11, 416);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Delete Customer";
            // 
            // guna2ButtonCreateNewCustomer
            // 
            this.guna2ButtonCreateNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCreateNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCreateNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCreateNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCreateNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonCreateNewCustomer.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonCreateNewCustomer.Location = new System.Drawing.Point(11, 73);
            this.guna2ButtonCreateNewCustomer.Name = "guna2ButtonCreateNewCustomer";
            this.guna2ButtonCreateNewCustomer.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonCreateNewCustomer.TabIndex = 4;
            this.guna2ButtonCreateNewCustomer.Text = "Create New Customer";
            // 
            // Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ButtonUpdateCustomer);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ButtonCreateNewCustomer);
            this.Controls.Add(this.labelAppointments);
            this.Name = "Appointments";
            this.Size = new System.Drawing.Size(946, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointments;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUpdateCustomer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCreateNewCustomer;
    }
}
