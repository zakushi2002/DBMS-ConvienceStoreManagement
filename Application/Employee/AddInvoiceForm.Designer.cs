
namespace ConvienceStore.Employee
{
    partial class AddInvoiceForm
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
            this.labelTotalPay = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addToInvoiceButton = new System.Windows.Forms.Button();
            this.labelUnit = new System.Windows.Forms.Label();
            this.txtBoxIntoMoney = new System.Windows.Forms.TextBox();
            this.labelIntoMoney = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.txtBoxProductID = new System.Windows.Forms.TextBox();
            this.labelProductID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelInvoiceID = new System.Windows.Forms.Label();
            this.groupBoxInvoice = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchButton = new System.Windows.Forms.Button();
            this.txtBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBoxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBoxInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotalPay
            // 
            this.labelTotalPay.AutoSize = true;
            this.labelTotalPay.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.labelTotalPay.Location = new System.Drawing.Point(893, 461);
            this.labelTotalPay.Name = "labelTotalPay";
            this.labelTotalPay.Size = new System.Drawing.Size(316, 32);
            this.labelTotalPay.TabIndex = 14;
            this.labelTotalPay.Text = "Total Pay:  0.000.000 vnd";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.printButton);
            this.groupBoxProduct.Controls.Add(this.addButton);
            this.groupBoxProduct.Controls.Add(this.labelTotalPay);
            this.groupBoxProduct.Controls.Add(this.pictureBox1);
            this.groupBoxProduct.Controls.Add(this.addToInvoiceButton);
            this.groupBoxProduct.Controls.Add(this.labelUnit);
            this.groupBoxProduct.Controls.Add(this.txtBoxIntoMoney);
            this.groupBoxProduct.Controls.Add(this.labelIntoMoney);
            this.groupBoxProduct.Controls.Add(this.txtBoxQuantity);
            this.groupBoxProduct.Controls.Add(this.labelQuantity);
            this.groupBoxProduct.Controls.Add(this.txtBoxPrice);
            this.groupBoxProduct.Controls.Add(this.labelPrice);
            this.groupBoxProduct.Controls.Add(this.txtBoxProductName);
            this.groupBoxProduct.Controls.Add(this.labelProductName);
            this.groupBoxProduct.Controls.Add(this.txtBoxProductID);
            this.groupBoxProduct.Controls.Add(this.labelProductID);
            this.groupBoxProduct.Controls.Add(this.dataGridView1);
            this.groupBoxProduct.Controls.Add(this.dataGridView2);
            this.groupBoxProduct.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxProduct.Location = new System.Drawing.Point(109, 238);
            this.groupBoxProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxProduct.Size = new System.Drawing.Size(1204, 592);
            this.groupBoxProduct.TabIndex = 103;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Information Of Product";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(732, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // addToInvoiceButton
            // 
            this.addToInvoiceButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addToInvoiceButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.addToInvoiceButton.Location = new System.Drawing.Point(914, 26);
            this.addToInvoiceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addToInvoiceButton.Name = "addToInvoiceButton";
            this.addToInvoiceButton.Size = new System.Drawing.Size(224, 65);
            this.addToInvoiceButton.TabIndex = 97;
            this.addToInvoiceButton.Text = "Add To Invoice";
            this.addToInvoiceButton.UseVisualStyleBackColor = false;
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.BackColor = System.Drawing.Color.Transparent;
            this.labelUnit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit.ForeColor = System.Drawing.Color.Black;
            this.labelUnit.Location = new System.Drawing.Point(268, 89);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(52, 23);
            this.labelUnit.TabIndex = 112;
            this.labelUnit.Text = "/Unit";
            // 
            // txtBoxIntoMoney
            // 
            this.txtBoxIntoMoney.Enabled = false;
            this.txtBoxIntoMoney.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxIntoMoney.Location = new System.Drawing.Point(492, 79);
            this.txtBoxIntoMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxIntoMoney.Name = "txtBoxIntoMoney";
            this.txtBoxIntoMoney.Size = new System.Drawing.Size(162, 30);
            this.txtBoxIntoMoney.TabIndex = 110;
            // 
            // labelIntoMoney
            // 
            this.labelIntoMoney.AutoSize = true;
            this.labelIntoMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelIntoMoney.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntoMoney.ForeColor = System.Drawing.Color.Black;
            this.labelIntoMoney.Location = new System.Drawing.Point(358, 89);
            this.labelIntoMoney.Name = "labelIntoMoney";
            this.labelIntoMoney.Size = new System.Drawing.Size(130, 23);
            this.labelIntoMoney.TabIndex = 109;
            this.labelIntoMoney.Text = "Total Amount:";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxQuantity.Location = new System.Drawing.Point(129, 128);
            this.txtBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(142, 30);
            this.txtBoxQuantity.TabIndex = 108;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.Black;
            this.labelQuantity.Location = new System.Drawing.Point(33, 138);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(92, 23);
            this.labelQuantity.TabIndex = 107;
            this.labelQuantity.Text = "Quantity:";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Enabled = false;
            this.txtBoxPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxPrice.Location = new System.Drawing.Point(129, 79);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(142, 30);
            this.txtBoxPrice.TabIndex = 105;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(60, 89);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 23);
            this.labelPrice.TabIndex = 106;
            this.labelPrice.Text = "Price:";
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Enabled = false;
            this.txtBoxProductName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxProductName.Location = new System.Drawing.Point(492, 32);
            this.txtBoxProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(221, 30);
            this.txtBoxProductName.TabIndex = 111;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.Black;
            this.labelProductName.Location = new System.Drawing.Point(349, 41);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(137, 23);
            this.labelProductName.TabIndex = 104;
            this.labelProductName.Text = "Product Name:";
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxProductID.Location = new System.Drawing.Point(129, 31);
            this.txtBoxProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.Size = new System.Drawing.Size(142, 30);
            this.txtBoxProductID.TabIndex = 102;
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.BackColor = System.Drawing.Color.Transparent;
            this.labelProductID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductID.ForeColor = System.Drawing.Color.Black;
            this.labelProductID.Location = new System.Drawing.Point(14, 42);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(109, 23);
            this.labelProductID.TabIndex = 103;
            this.labelProductID.Text = "Product ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(634, 278);
            this.dataGridView1.TabIndex = 49;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(658, 168);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(537, 278);
            this.dataGridView2.TabIndex = 113;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtInvoiceID.Location = new System.Drawing.Point(160, 38);
            this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(229, 30);
            this.txtInvoiceID.TabIndex = 88;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(97, 104);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(58, 23);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date:";
            // 
            // labelInvoiceID
            // 
            this.labelInvoiceID.AutoSize = true;
            this.labelInvoiceID.BackColor = System.Drawing.Color.Transparent;
            this.labelInvoiceID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceID.ForeColor = System.Drawing.Color.Black;
            this.labelInvoiceID.Location = new System.Drawing.Point(51, 48);
            this.labelInvoiceID.Name = "labelInvoiceID";
            this.labelInvoiceID.Size = new System.Drawing.Size(104, 23);
            this.labelInvoiceID.TabIndex = 5;
            this.labelInvoiceID.Text = "Invoice ID:";
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.dateTimePicker);
            this.groupBoxInvoice.Controls.Add(this.searchButton);
            this.groupBoxInvoice.Controls.Add(this.txtBoxCustomerName);
            this.groupBoxInvoice.Controls.Add(this.labelCustomerName);
            this.groupBoxInvoice.Controls.Add(this.txtBoxPhone);
            this.groupBoxInvoice.Controls.Add(this.labelPhone);
            this.groupBoxInvoice.Controls.Add(this.textBoxCustomerID);
            this.groupBoxInvoice.Controls.Add(this.labelCustomerID);
            this.groupBoxInvoice.Controls.Add(this.txtInvoiceID);
            this.groupBoxInvoice.Controls.Add(this.labelDate);
            this.groupBoxInvoice.Controls.Add(this.labelInvoiceID);
            this.groupBoxInvoice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxInvoice.Location = new System.Drawing.Point(237, 14);
            this.groupBoxInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInvoice.Size = new System.Drawing.Size(952, 205);
            this.groupBoxInvoice.TabIndex = 104;
            this.groupBoxInvoice.TabStop = false;
            this.groupBoxInvoice.Text = "Information";
            this.groupBoxInvoice.Enter += new System.EventHandler(this.groupBoxInvoice_Enter);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm ";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(161, 94);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 30);
            this.dateTimePicker.TabIndex = 99;
            this.dateTimePicker.Value = new System.DateTime(2022, 5, 14, 21, 40, 40, 0);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(780, 34);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(142, 38);
            this.searchButton.TabIndex = 92;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.Enabled = false;
            this.txtBoxCustomerName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxCustomerName.Location = new System.Drawing.Point(580, 144);
            this.txtBoxCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.Size = new System.Drawing.Size(193, 30);
            this.txtBoxCustomerName.TabIndex = 97;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.ForeColor = System.Drawing.Color.Black;
            this.labelCustomerName.Location = new System.Drawing.Point(418, 151);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(153, 23);
            this.labelCustomerName.TabIndex = 98;
            this.labelCustomerName.Text = "Customer Name:";
            this.labelCustomerName.Click += new System.EventHandler(this.labelCustomerName_Click);
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.txtBoxPhone.Location = new System.Drawing.Point(580, 38);
            this.txtBoxPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(193, 30);
            this.txtBoxPhone.TabIndex = 94;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.Black;
            this.labelPhone.Location = new System.Drawing.Point(502, 41);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(69, 23);
            this.labelPhone.TabIndex = 93;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Enabled = false;
            this.textBoxCustomerID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxCustomerID.Location = new System.Drawing.Point(580, 94);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(193, 30);
            this.textBoxCustomerID.TabIndex = 96;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerID.ForeColor = System.Drawing.Color.Black;
            this.labelCustomerID.Location = new System.Drawing.Point(446, 98);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(125, 23);
            this.labelCustomerID.TabIndex = 95;
            this.labelCustomerID.Text = "Customer ID:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(18, 498);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(610, 60);
            this.addButton.TabIndex = 116;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.printButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.printButton.Location = new System.Drawing.Point(634, 498);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(561, 60);
            this.printButton.TabIndex = 117;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImage = global::ConvienceStore.Properties.Resources.cancelButton;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(1309, 14);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(54, 54);
            this.cancelButton.TabIndex = 122;
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // AddInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 887);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.groupBoxInvoice);
            this.Name = "AddInvoiceForm";
            this.Text = "AddInvoiceForm";
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBoxInvoice.ResumeLayout(false);
            this.groupBoxInvoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTotalPay;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addToInvoiceButton;
        private System.Windows.Forms.Label labelUnit;
        public System.Windows.Forms.TextBox txtBoxIntoMoney;
        private System.Windows.Forms.Label labelIntoMoney;
        public System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        public System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        public System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        public System.Windows.Forms.TextBox txtBoxProductID;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelInvoiceID;
        private System.Windows.Forms.GroupBox groupBoxInvoice;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.TextBox txtBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        public System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        public System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button cancelButton;
    }
}