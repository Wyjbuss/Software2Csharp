namespace Software2Csharp
{
    partial class Customers
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
            this.labelCustomers = new System.Windows.Forms.Label();
            this.guna2ButtonCreateNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonUpdateCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomers
            // 
            this.labelCustomers.AutoSize = true;
            this.labelCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomers.Location = new System.Drawing.Point(3, 0);
            this.labelCustomers.Name = "labelCustomers";
            this.labelCustomers.Size = new System.Drawing.Size(213, 46);
            this.labelCustomers.TabIndex = 0;
            this.labelCustomers.Text = "Customers";
            // 
            // guna2ButtonCreateNewCustomer
            // 
            this.guna2ButtonCreateNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCreateNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButtonCreateNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButtonCreateNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButtonCreateNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonCreateNewCustomer.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonCreateNewCustomer.Location = new System.Drawing.Point(11, 78);
            this.guna2ButtonCreateNewCustomer.Name = "guna2ButtonCreateNewCustomer";
            this.guna2ButtonCreateNewCustomer.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonCreateNewCustomer.TabIndex = 1;
            this.guna2ButtonCreateNewCustomer.Text = "Create New Customer";
            this.guna2ButtonCreateNewCustomer.Click += new System.EventHandler(this.guna2ButtonCreateNewCustomer_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(11, 421);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Delete Customer";
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
            this.guna2ButtonUpdateCustomer.Location = new System.Drawing.Point(11, 370);
            this.guna2ButtonUpdateCustomer.Name = "guna2ButtonUpdateCustomer";
            this.guna2ButtonUpdateCustomer.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonUpdateCustomer.TabIndex = 3;
            this.guna2ButtonUpdateCustomer.Text = "Update Customer";
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(242, 74);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(657, 384);
            this.dataGridViewCustomers.TabIndex = 4;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewCustomers);
            this.Controls.Add(this.guna2ButtonUpdateCustomer);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2ButtonCreateNewCustomer);
            this.Controls.Add(this.labelCustomers);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(946, 476);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomers;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonCreateNewCustomer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonUpdateCustomer;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
    }
}
