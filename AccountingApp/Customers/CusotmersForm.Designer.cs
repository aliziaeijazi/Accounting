namespace AccountingApp
{
    partial class CusotmersForm
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchCustomerInput = new System.Windows.Forms.ToolStripTextBox();
            this.DataGridCustomer = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerImageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounting_DBDataSet = new AccountingApp.Accounting_DBDataSet();
            this.customersTableAdapter = new AccountingApp.Accounting_DBDataSetTableAdapters.CustomersTableAdapter();
            this.addCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.editCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.refrshCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerBtn,
            this.editCustomerBtn,
            this.deleteCustomerBtn,
            this.refrshCustomerBtn,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.searchCustomerInput});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 72);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // searchCustomerInput
            // 
            this.searchCustomerInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchCustomerInput.Name = "searchCustomerInput";
            this.searchCustomerInput.Size = new System.Drawing.Size(220, 72);
            this.searchCustomerInput.Click += new System.EventHandler(this.refrshCustomerBtn_Click);
            this.searchCustomerInput.TextChanged += new System.EventHandler(this.searchCustomerInput_TextChanged);
            // 
            // DataGridCustomer
            // 
            this.DataGridCustomer.AllowUserToAddRows = false;
            this.DataGridCustomer.AllowUserToDeleteRows = false;
            this.DataGridCustomer.AutoGenerateColumns = false;
            this.DataGridCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerImageDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.DataGridCustomer.DataSource = this.customersBindingSource;
            this.DataGridCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridCustomer.Location = new System.Drawing.Point(0, 72);
            this.DataGridCustomer.Name = "DataGridCustomer";
            this.DataGridCustomer.ReadOnly = true;
            this.DataGridCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridCustomer.Size = new System.Drawing.Size(584, 400);
            this.DataGridCustomer.TabIndex = 1;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.FillWeight = 2F;
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "شناسه";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerImageDataGridViewTextBoxColumn
            // 
            this.customerImageDataGridViewTextBoxColumn.DataPropertyName = "CustomerImage";
            this.customerImageDataGridViewTextBoxColumn.HeaderText = "عکس";
            this.customerImageDataGridViewTextBoxColumn.Name = "customerImageDataGridViewTextBoxColumn";
            this.customerImageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "شماره تماس";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "ایمیل";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.accounting_DBDataSet;
            // 
            // accounting_DBDataSet
            // 
            this.accounting_DBDataSet.DataSetName = "Accounting_DBDataSet";
            this.accounting_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Font = new System.Drawing.Font("IRANSans", 8.25F);
            this.addCustomerBtn.Image = global::AccountingApp.Properties.Resources.icons8_add_user_male_48px_1;
            this.addCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(69, 69);
            this.addCustomerBtn.Text = "شخص جدید";
            this.addCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.Font = new System.Drawing.Font("IRANSans", 8.25F);
            this.editCustomerBtn.Image = global::AccountingApp.Properties.Resources.icons8_user_engagement_male_48px;
            this.editCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(79, 69);
            this.editCustomerBtn.Text = "ویرایش شخص";
            this.editCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Font = new System.Drawing.Font("IRANSans", 8.25F);
            this.deleteCustomerBtn.Image = global::AccountingApp.Properties.Resources.icons8_delete_user_male_48px;
            this.deleteCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(68, 69);
            this.deleteCustomerBtn.Text = "حذف شخص";
            this.deleteCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // refrshCustomerBtn
            // 
            this.refrshCustomerBtn.Font = new System.Drawing.Font("IRANSans", 8.25F);
            this.refrshCustomerBtn.Image = global::AccountingApp.Properties.Resources.icons8_change_user_48px;
            this.refrshCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refrshCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refrshCustomerBtn.Name = "refrshCustomerBtn";
            this.refrshCustomerBtn.Size = new System.Drawing.Size(60, 69);
            this.refrshCustomerBtn.Text = " بروزرسانی ";
            this.refrshCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refrshCustomerBtn.Click += new System.EventHandler(this.refrshCustomerBtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("IRANSans", 8.25F);
            this.toolStripLabel1.Image = global::AccountingApp.Properties.Resources.icons8_find_user_male_24px;
            this.toolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 69);
            this.toolStripLabel1.Text = "جستجو";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // CusotmersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 472);
            this.Controls.Add(this.DataGridCustomer);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("IRANSans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CusotmersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست اشخاص";
            this.Load += new System.EventHandler(this.CusotmersForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounting_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addCustomerBtn;
        private System.Windows.Forms.ToolStripButton editCustomerBtn;
        private System.Windows.Forms.ToolStripButton deleteCustomerBtn;
        private System.Windows.Forms.ToolStripButton refrshCustomerBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchCustomerInput;
        private System.Windows.Forms.DataGridView DataGridCustomer;
        private Accounting_DBDataSet accounting_DBDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Accounting_DBDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerImageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}