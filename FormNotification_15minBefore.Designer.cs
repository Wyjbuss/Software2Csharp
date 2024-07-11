namespace Software2Csharp
{
    partial class FormNotification_15minBefore
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
            this.labelNoticication = new System.Windows.Forms.Label();
            this.guna2ButtonAccept = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // labelNoticication
            // 
            this.labelNoticication.AutoSize = true;
            this.labelNoticication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoticication.Location = new System.Drawing.Point(12, 9);
            this.labelNoticication.Name = "labelNoticication";
            this.labelNoticication.Size = new System.Drawing.Size(611, 31);
            this.labelNoticication.TabIndex = 0;
            this.labelNoticication.Text = "You have an appointment sceduled 15 min or less";
            this.labelNoticication.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2ButtonAccept
            // 
            this.guna2ButtonAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAccept.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonAccept.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAccept.Location = new System.Drawing.Point(265, 61);
            this.guna2ButtonAccept.Name = "guna2ButtonAccept";
            this.guna2ButtonAccept.Size = new System.Drawing.Size(107, 35);
            this.guna2ButtonAccept.TabIndex = 1;
            this.guna2ButtonAccept.Text = "Accept";
            this.guna2ButtonAccept.Click += new System.EventHandler(this.guna2ButtonAccept_Click);
            // 
            // FormNotification_15minBefore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 156);
            this.Controls.Add(this.guna2ButtonAccept);
            this.Controls.Add(this.labelNoticication);
            this.Name = "FormNotification_15minBefore";
            this.Text = "FormNotification_15minBefore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoticication;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAccept;
    }
}