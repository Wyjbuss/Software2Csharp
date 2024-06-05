﻿namespace Software2Csharp
{
    partial class FormAddAppointment
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
            this.guna2ButtonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.labelURL = new System.Windows.Forms.Label();
            this.guna2TextBoxURL = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.guna2TextBoxType = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.guna2TextBoxContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.guna2TextBoxLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // guna2ButtonCancel
            // 
            this.guna2ButtonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonCancel.Location = new System.Drawing.Point(602, 363);
            this.guna2ButtonCancel.Name = "guna2ButtonCancel";
            this.guna2ButtonCancel.Size = new System.Drawing.Size(94, 45);
            this.guna2ButtonCancel.TabIndex = 27;
            this.guna2ButtonCancel.Text = "Cancel";
            this.guna2ButtonCancel.Click += new System.EventHandler(this.guna2ButtonCancel_Click);
            // 
            // guna2ButtonAdd
            // 
            this.guna2ButtonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAdd.Location = new System.Drawing.Point(496, 363);
            this.guna2ButtonAdd.Name = "guna2ButtonAdd";
            this.guna2ButtonAdd.Size = new System.Drawing.Size(94, 45);
            this.guna2ButtonAdd.TabIndex = 26;
            this.guna2ButtonAdd.Text = "Add";
            this.guna2ButtonAdd.Click += new System.EventHandler(this.guna2ButtonAdd_Click);
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(452, 334);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(32, 13);
            this.labelURL.TabIndex = 25;
            this.labelURL.Text = "URL:";
            // 
            // guna2TextBoxURL
            // 
            this.guna2TextBoxURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxURL.DefaultText = "";
            this.guna2TextBoxURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxURL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxURL.Location = new System.Drawing.Point(496, 321);
            this.guna2TextBoxURL.Name = "guna2TextBoxURL";
            this.guna2TextBoxURL.PasswordChar = '\0';
            this.guna2TextBoxURL.PlaceholderText = "https://google.com";
            this.guna2TextBoxURL.SelectedText = "";
            this.guna2TextBoxURL.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBoxURL.TabIndex = 24;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(456, 289);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 13);
            this.labelType.TabIndex = 23;
            this.labelType.Text = "Type:";
            // 
            // guna2TextBoxType
            // 
            this.guna2TextBoxType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxType.DefaultText = "";
            this.guna2TextBoxType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxType.Location = new System.Drawing.Point(496, 279);
            this.guna2TextBoxType.Name = "guna2TextBoxType";
            this.guna2TextBoxType.PasswordChar = '\0';
            this.guna2TextBoxType.PlaceholderText = "Scrum";
            this.guna2TextBoxType.SelectedText = "";
            this.guna2TextBoxType.Size = new System.Drawing.Size(90, 36);
            this.guna2TextBoxType.TabIndex = 22;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Location = new System.Drawing.Point(443, 249);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(47, 13);
            this.labelContact.TabIndex = 21;
            this.labelContact.Text = "Contact:";
            // 
            // guna2TextBoxContact
            // 
            this.guna2TextBoxContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxContact.DefaultText = "";
            this.guna2TextBoxContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxContact.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxContact.Location = new System.Drawing.Point(496, 237);
            this.guna2TextBoxContact.Name = "guna2TextBoxContact";
            this.guna2TextBoxContact.PasswordChar = '\0';
            this.guna2TextBoxContact.PlaceholderText = "Fred";
            this.guna2TextBoxContact.SelectedText = "";
            this.guna2TextBoxContact.Size = new System.Drawing.Size(90, 36);
            this.guna2TextBoxContact.TabIndex = 20;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(442, 205);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(51, 13);
            this.labelLocation.TabIndex = 19;
            this.labelLocation.Text = "Location:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(430, 133);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(452, 63);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Title:";
            // 
            // guna2TextBoxLocation
            // 
            this.guna2TextBoxLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxLocation.DefaultText = "";
            this.guna2TextBoxLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxLocation.Location = new System.Drawing.Point(496, 195);
            this.guna2TextBoxLocation.Name = "guna2TextBoxLocation";
            this.guna2TextBoxLocation.PasswordChar = '\0';
            this.guna2TextBoxLocation.PlaceholderText = "1243 Main St.";
            this.guna2TextBoxLocation.SelectedText = "";
            this.guna2TextBoxLocation.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBoxLocation.TabIndex = 16;
            // 
            // guna2TextBoxDescription
            // 
            this.guna2TextBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxDescription.DefaultText = "";
            this.guna2TextBoxDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxDescription.Location = new System.Drawing.Point(496, 95);
            this.guna2TextBoxDescription.Multiline = true;
            this.guna2TextBoxDescription.Name = "guna2TextBoxDescription";
            this.guna2TextBoxDescription.PasswordChar = '\0';
            this.guna2TextBoxDescription.PlaceholderText = "This is a description of the appointment that I am attending or hosting";
            this.guna2TextBoxDescription.SelectedText = "";
            this.guna2TextBoxDescription.Size = new System.Drawing.Size(200, 94);
            this.guna2TextBoxDescription.TabIndex = 15;
            // 
            // guna2TextBoxTitle
            // 
            this.guna2TextBoxTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxTitle.DefaultText = "";
            this.guna2TextBoxTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxTitle.Location = new System.Drawing.Point(496, 53);
            this.guna2TextBoxTitle.Name = "guna2TextBoxTitle";
            this.guna2TextBoxTitle.PasswordChar = '\0';
            this.guna2TextBoxTitle.PlaceholderText = "Meeting";
            this.guna2TextBoxTitle.SelectedText = "";
            this.guna2TextBoxTitle.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBoxTitle.TabIndex = 14;
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(31, 169);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(29, 13);
            this.labelEnd.TabIndex = 28;
            this.labelEnd.Text = "End:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(31, 116);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(32, 13);
            this.labelStart.TabIndex = 29;
            this.labelStart.Text = "Start:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(69, 116);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerStart.TabIndex = 30;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(66, 169);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerEnd.TabIndex = 31;
            // 
            // FormAddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.guna2ButtonCancel);
            this.Controls.Add(this.guna2ButtonAdd);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.guna2TextBoxURL);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.guna2TextBoxType);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.guna2TextBoxContact);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.guna2TextBoxLocation);
            this.Controls.Add(this.guna2TextBoxDescription);
            this.Controls.Add(this.guna2TextBoxTitle);
            this.Name = "FormAddAppointment";
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2ButtonCancel;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private System.Windows.Forms.Label labelURL;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxURL;
        private System.Windows.Forms.Label labelType;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxType;
        private System.Windows.Forms.Label labelContact;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxContact;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxLocation;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxDescription;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxTitle;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    }
}