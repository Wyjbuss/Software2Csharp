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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Customers");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Appointments");
            this.labelHelloUsr = new System.Windows.Forms.Label();
            this.treeViewTabs = new System.Windows.Forms.TreeView();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.groupBoxAppointments = new System.Windows.Forms.GroupBox();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomers.SuspendLayout();
            this.groupBoxAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
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
            // treeViewTabs
            // 
            this.treeViewTabs.Location = new System.Drawing.Point(22, 60);
            this.treeViewTabs.Name = "treeViewTabs";
            treeNode1.Name = "tabCustomers";
            treeNode1.Text = "Customers";
            treeNode2.Name = "tabAppointments";
            treeNode2.Text = "Appointments";
            this.treeViewTabs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeViewTabs.Size = new System.Drawing.Size(121, 47);
            this.treeViewTabs.TabIndex = 1;
            this.treeViewTabs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTabs_AfterSelect);
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.Controls.Add(this.groupBoxAppointments);
            this.groupBoxCustomers.Enabled = false;
            this.groupBoxCustomers.Location = new System.Drawing.Point(188, 33);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(721, 464);
            this.groupBoxCustomers.TabIndex = 2;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Cutomers";
            this.groupBoxCustomers.Visible = false;
            // 
            // groupBoxAppointments
            // 
            this.groupBoxAppointments.Controls.Add(this.dataGridViewCustomers);
            this.groupBoxAppointments.Enabled = false;
            this.groupBoxAppointments.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAppointments.Name = "groupBoxAppointments";
            this.groupBoxAppointments.Size = new System.Drawing.Size(721, 458);
            this.groupBoxAppointments.TabIndex = 3;
            this.groupBoxAppointments.TabStop = false;
            this.groupBoxAppointments.Text = "Appointments";
            this.groupBoxAppointments.Visible = false;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(6, 27);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Size = new System.Drawing.Size(709, 366);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // FormAppointmentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 540);
            this.Controls.Add(this.groupBoxCustomers);
            this.Controls.Add(this.treeViewTabs);
            this.Controls.Add(this.labelHelloUsr);
            this.Name = "FormAppointmentMain";
            this.Text = "FormAppointmentMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAppointmentMain_FormClosed);
            this.Load += new System.EventHandler(this.FormAppointmentMain_Load);
            this.groupBoxCustomers.ResumeLayout(false);
            this.groupBoxAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelloUsr;
        private System.Windows.Forms.TreeView treeViewTabs;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.GroupBox groupBoxAppointments;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
    }
}