namespace AccountingApp.Customers
{
    partial class AddOrEditCustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditCustomersForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerAddressInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerEmailInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerPhoneNumberInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerFamilyInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.selectPhotoBtn = new System.Windows.Forms.Button();
            this.CustomerPhoto = new System.Windows.Forms.PictureBox();
            this.insertOrEditCustomerBtn = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.regularExpressionValidator1 = new ValidationComponents.RegularExpressionValidator(this.components);
            this.regularExpressionValidator2 = new ValidationComponents.RegularExpressionValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerAddressInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.customerEmailInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.customerPhoneNumberInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.customerFamilyInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customerNameInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(201, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات شخص";
            // 
            // customerAddressInput
            // 
            this.customerAddressInput.Location = new System.Drawing.Point(6, 222);
            this.customerAddressInput.Multiline = true;
            this.customerAddressInput.Name = "customerAddressInput";
            this.customerAddressInput.Size = new System.Drawing.Size(258, 68);
            this.customerAddressInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "آدرس:";
            // 
            // customerEmailInput
            // 
            this.customerEmailInput.Location = new System.Drawing.Point(6, 174);
            this.customerEmailInput.Name = "customerEmailInput";
            this.customerEmailInput.Size = new System.Drawing.Size(258, 25);
            this.customerEmailInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "ایمیل:";
            // 
            // customerPhoneNumberInput
            // 
            this.customerPhoneNumberInput.Location = new System.Drawing.Point(6, 125);
            this.customerPhoneNumberInput.Name = "customerPhoneNumberInput";
            this.customerPhoneNumberInput.Size = new System.Drawing.Size(258, 25);
            this.customerPhoneNumberInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "شماره تماس:";
            // 
            // customerFamilyInput
            // 
            this.customerFamilyInput.Location = new System.Drawing.Point(6, 80);
            this.customerFamilyInput.Name = "customerFamilyInput";
            this.customerFamilyInput.Size = new System.Drawing.Size(258, 25);
            this.customerFamilyInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            // 
            // customerNameInput
            // 
            this.customerNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerNameInput.Location = new System.Drawing.Point(6, 34);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(258, 25);
            this.customerNameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.selectPhotoBtn);
            this.groupBox2.Controls.Add(this.CustomerPhoto);
            this.groupBox2.Location = new System.Drawing.Point(4, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر ";
            // 
            // selectPhotoBtn
            // 
            this.selectPhotoBtn.Location = new System.Drawing.Point(6, 255);
            this.selectPhotoBtn.Name = "selectPhotoBtn";
            this.selectPhotoBtn.Size = new System.Drawing.Size(179, 36);
            this.selectPhotoBtn.TabIndex = 6;
            this.selectPhotoBtn.Text = "انتخاب عکس";
            this.selectPhotoBtn.UseVisualStyleBackColor = true;
            this.selectPhotoBtn.Click += new System.EventHandler(this.selectPhotoBtn_Click);
            // 
            // CustomerPhoto
            // 
            this.CustomerPhoto.Image = global::AccountingApp.Properties.Resources.noPhoto;
            this.CustomerPhoto.InitialImage = global::AccountingApp.Properties.Resources.icons8_person_200px;
            this.CustomerPhoto.Location = new System.Drawing.Point(6, 22);
            this.CustomerPhoto.Name = "CustomerPhoto";
            this.CustomerPhoto.Size = new System.Drawing.Size(179, 224);
            this.CustomerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CustomerPhoto.TabIndex = 0;
            this.CustomerPhoto.TabStop = false;
            // 
            // insertOrEditCustomerBtn
            // 
            this.insertOrEditCustomerBtn.Location = new System.Drawing.Point(156, 305);
            this.insertOrEditCustomerBtn.Name = "insertOrEditCustomerBtn";
            this.insertOrEditCustomerBtn.Size = new System.Drawing.Size(179, 31);
            this.insertOrEditCustomerBtn.TabIndex = 7;
            this.insertOrEditCustomerBtn.Text = "افزودن شخص";
            this.insertOrEditCustomerBtn.UseVisualStyleBackColor = true;
            this.insertOrEditCustomerBtn.Click += new System.EventHandler(this.insertOrEditCustomerBtn_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.customerNameInput;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام را وارد کنید.";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.customerFamilyInput;
            this.requiredFieldValidator2.ErrorMessage = "لطفا نام خانوادگی را وارد کنید.";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.customerPhoneNumberInput;
            this.requiredFieldValidator3.ErrorMessage = "لطفا شماره تماس را وارد کنید.";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.customerEmailInput;
            this.requiredFieldValidator4.ErrorMessage = "لطفا پست الکترونیکی را وارد کنید.";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // regularExpressionValidator1
            // 
            this.regularExpressionValidator1.CancelFocusChangeWhenInvalid = false;
            this.regularExpressionValidator1.ControlToValidate = this.customerPhoneNumberInput;
            this.regularExpressionValidator1.ErrorMessage = "لطفا شماره تماس خود را به صورت یک شماره 11 رقمی وارد نمایید.";
            this.regularExpressionValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("regularExpressionValidator1.Icon")));
            this.regularExpressionValidator1.ValidationExpression = "^0[0-9]{10}$";
            // 
            // regularExpressionValidator2
            // 
            this.regularExpressionValidator2.CancelFocusChangeWhenInvalid = false;
            this.regularExpressionValidator2.ControlToValidate = this.customerEmailInput;
            this.regularExpressionValidator2.ErrorMessage = "لطفا ایمیل خود را به درستی وارد نمایید.";
            this.regularExpressionValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("regularExpressionValidator2.Icon")));
            this.regularExpressionValidator2.ValidationExpression = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
            // 
            // AddOrEditCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.insertOrEditCustomerBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("IRANSans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddOrEditCustomersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافه کردن شخص جدید";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerEmailInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerPhoneNumberInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerFamilyInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerAddressInput;
        private System.Windows.Forms.Button selectPhotoBtn;
        private System.Windows.Forms.PictureBox CustomerPhoto;
        private System.Windows.Forms.Button insertOrEditCustomerBtn;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private ValidationComponents.RegularExpressionValidator regularExpressionValidator1;
        private ValidationComponents.RegularExpressionValidator regularExpressionValidator2;
    }
}