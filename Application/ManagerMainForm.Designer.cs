namespace ConvienceStore
{
    partial class ManagerMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeForm = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductForm = new System.Windows.Forms.ToolStripMenuItem();
            this.listProductForm = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.manageType = new System.Windows.Forms.ToolStripMenuItem();
            this.manageManuafacture = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSupply = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeStatisticsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueStatisticsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.invoiceToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeForm,
            this.manageEmployee});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeForm
            // 
            this.addEmployeeForm.Name = "addEmployeeForm";
            this.addEmployeeForm.Size = new System.Drawing.Size(216, 26);
            this.addEmployeeForm.Text = "Add Employee";
            this.addEmployeeForm.Click += new System.EventHandler(this.addEmployeeForm_Click);
            // 
            // manageEmployee
            // 
            this.manageEmployee.Name = "manageEmployee";
            this.manageEmployee.Size = new System.Drawing.Size(216, 26);
            this.manageEmployee.Text = "Manage Employee";
            this.manageEmployee.Click += new System.EventHandler(this.manageEmployee_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductForm,
            this.listProductForm,
            this.manageProduct,
            this.manageType,
            this.manageManuafacture,
            this.manageSupply});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addProductForm
            // 
            this.addProductForm.Name = "addProductForm";
            this.addProductForm.Size = new System.Drawing.Size(241, 26);
            this.addProductForm.Text = "Add Product";
            this.addProductForm.Click += new System.EventHandler(this.addProductForm_Click);
            // 
            // listProductForm
            // 
            this.listProductForm.Name = "listProductForm";
            this.listProductForm.Size = new System.Drawing.Size(241, 26);
            this.listProductForm.Text = "List Product";
            this.listProductForm.Click += new System.EventHandler(this.listProductForm_Click);
            // 
            // manageProduct
            // 
            this.manageProduct.Name = "manageProduct";
            this.manageProduct.Size = new System.Drawing.Size(241, 26);
            this.manageProduct.Text = "Manage Product";
            this.manageProduct.Click += new System.EventHandler(this.manageProduct_Click);
            // 
            // manageType
            // 
            this.manageType.Name = "manageType";
            this.manageType.Size = new System.Drawing.Size(241, 26);
            this.manageType.Text = "Manage Type";
            this.manageType.Click += new System.EventHandler(this.manageType_Click);
            // 
            // manageManuafacture
            // 
            this.manageManuafacture.Name = "manageManuafacture";
            this.manageManuafacture.Size = new System.Drawing.Size(241, 26);
            this.manageManuafacture.Text = "Manage Manuafacture";
            this.manageManuafacture.Click += new System.EventHandler(this.manageManuafacture_Click);
            // 
            // manageSupply
            // 
            this.manageSupply.Name = "manageSupply";
            this.manageSupply.Size = new System.Drawing.Size(241, 26);
            this.manageSupply.Text = "Manage Supply";
            this.manageSupply.Click += new System.EventHandler(this.manageSupply_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomer,
            this.manageCustomer});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomer
            // 
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(213, 26);
            this.addCustomer.Text = "Add Customer";
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // manageCustomer
            // 
            this.manageCustomer.Name = "manageCustomer";
            this.manageCustomer.Size = new System.Drawing.Size(213, 26);
            this.manageCustomer.Text = "Manage Customer";
            this.manageCustomer.Click += new System.EventHandler(this.manageCustomer_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeStatisticsToolStripMenuItem1,
            this.revenueStatisticsToolStripMenuItem1});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // employeeStatisticsToolStripMenuItem1
            // 
            this.employeeStatisticsToolStripMenuItem1.Name = "employeeStatisticsToolStripMenuItem1";
            this.employeeStatisticsToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.employeeStatisticsToolStripMenuItem1.Text = "Employee Statistics";
            this.employeeStatisticsToolStripMenuItem1.Click += new System.EventHandler(this.employeeStatisticsToolStripMenuItem1_Click);
            // 
            // revenueStatisticsToolStripMenuItem1
            // 
            this.revenueStatisticsToolStripMenuItem1.Name = "revenueStatisticsToolStripMenuItem1";
            this.revenueStatisticsToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.revenueStatisticsToolStripMenuItem1.Text = "Revenue Statistics";
            this.revenueStatisticsToolStripMenuItem1.Click += new System.EventHandler(this.revenueStatisticsToolStripMenuItem1_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerMainForm";
            this.Text = "ManagerMainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeForm;
        private System.Windows.Forms.ToolStripMenuItem manageEmployee;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomer;
        private System.Windows.Forms.ToolStripMenuItem manageCustomer;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductForm;
        private System.Windows.Forms.ToolStripMenuItem listProductForm;
        private System.Windows.Forms.ToolStripMenuItem manageProduct;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeStatisticsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem revenueStatisticsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageType;
        private System.Windows.Forms.ToolStripMenuItem manageManuafacture;
        private System.Windows.Forms.ToolStripMenuItem manageSupply;
    }
}