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
            this.SuspendLayout();
            // 
            // labelHelloUsr
            // 
            this.labelHelloUsr.AutoSize = true;
            this.labelHelloUsr.Location = new System.Drawing.Point(53, 33);
            this.labelHelloUsr.Name = "labelHelloUsr";
            this.labelHelloUsr.Size = new System.Drawing.Size(59, 13);
            this.labelHelloUsr.TabIndex = 0;
            this.labelHelloUsr.Text = "Hello, User";
            // 
            // FormAppointmentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHelloUsr);
            this.Name = "FormAppointmentMain";
            this.Text = "FormAppointmentMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAppointmentMain_FormClosed);
            this.Load += new System.EventHandler(this.FormAppointmentMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelloUsr;
    }
}