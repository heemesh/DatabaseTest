namespace DatabaseTest
{
    partial class Form1
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
            this.connect_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.displayTable_button = new System.Windows.Forms.Button();
            this.loadConnect_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.fpmProcedure = new System.Windows.Forms.TextBox();
            this.tenantDr = new System.Windows.Forms.TextBox();
            this.apxDT = new System.Windows.Forms.TextBox();
            this.tenantMailType = new System.Windows.Forms.TextBox();
            this.ownerMailType = new System.Windows.Forms.TextBox();
            this.payee = new System.Windows.Forms.TextBox();
            this.tenantName = new System.Windows.Forms.TextBox();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.ownerAddress = new System.Windows.Forms.TextBox();
            this.tenantAddress = new System.Windows.Forms.TextBox();
            this.accountType = new System.Windows.Forms.TextBox();
            this.accountID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userAdded_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_button.Location = new System.Drawing.Point(31, 11);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(89, 54);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 491);
            this.dataGridView1.TabIndex = 3;
            // 
            // displayTable_button
            // 
            this.displayTable_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTable_button.Location = new System.Drawing.Point(31, 93);
            this.displayTable_button.Name = "displayTable_button";
            this.displayTable_button.Size = new System.Drawing.Size(89, 54);
            this.displayTable_button.TabIndex = 5;
            this.displayTable_button.Text = "Display Table";
            this.displayTable_button.UseVisualStyleBackColor = true;
            this.displayTable_button.Click += new System.EventHandler(this.displayTable_button_Click);
            // 
            // loadConnect_label
            // 
            this.loadConnect_label.AutoSize = true;
            this.loadConnect_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadConnect_label.Location = new System.Drawing.Point(456, 21);
            this.loadConnect_label.Name = "loadConnect_label";
            this.loadConnect_label.Size = new System.Drawing.Size(118, 29);
            this.loadConnect_label.TabIndex = 6;
            this.loadConnect_label.Text = "Loading...";
            this.loadConnect_label.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 720);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.displayTable_button);
            this.tabPage1.Controls.Add(this.loadConnect_label);
            this.tabPage1.Controls.Add(this.connect_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1042, 687);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userAdded_label);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.fpmProcedure);
            this.tabPage2.Controls.Add(this.tenantDr);
            this.tabPage2.Controls.Add(this.apxDT);
            this.tabPage2.Controls.Add(this.tenantMailType);
            this.tabPage2.Controls.Add(this.ownerMailType);
            this.tabPage2.Controls.Add(this.payee);
            this.tabPage2.Controls.Add(this.tenantName);
            this.tabPage2.Controls.Add(this.OwnerName);
            this.tabPage2.Controls.Add(this.ownerAddress);
            this.tabPage2.Controls.Add(this.tenantAddress);
            this.tabPage2.Controls.Add(this.accountType);
            this.tabPage2.Controls.Add(this.accountID);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 687);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fpmProcedure
            // 
            this.fpmProcedure.Location = new System.Drawing.Point(199, 615);
            this.fpmProcedure.Name = "fpmProcedure";
            this.fpmProcedure.Size = new System.Drawing.Size(346, 27);
            this.fpmProcedure.TabIndex = 23;
            // 
            // tenantDr
            // 
            this.tenantDr.Location = new System.Drawing.Point(199, 564);
            this.tenantDr.Name = "tenantDr";
            this.tenantDr.Size = new System.Drawing.Size(346, 27);
            this.tenantDr.TabIndex = 22;
            // 
            // apxDT
            // 
            this.apxDT.Location = new System.Drawing.Point(199, 513);
            this.apxDT.Name = "apxDT";
            this.apxDT.Size = new System.Drawing.Size(346, 27);
            this.apxDT.TabIndex = 21;
            // 
            // tenantMailType
            // 
            this.tenantMailType.Location = new System.Drawing.Point(199, 462);
            this.tenantMailType.Name = "tenantMailType";
            this.tenantMailType.Size = new System.Drawing.Size(346, 27);
            this.tenantMailType.TabIndex = 20;
            // 
            // ownerMailType
            // 
            this.ownerMailType.Location = new System.Drawing.Point(199, 411);
            this.ownerMailType.Name = "ownerMailType";
            this.ownerMailType.Size = new System.Drawing.Size(346, 27);
            this.ownerMailType.TabIndex = 19;
            // 
            // payee
            // 
            this.payee.Location = new System.Drawing.Point(199, 360);
            this.payee.Name = "payee";
            this.payee.Size = new System.Drawing.Size(346, 27);
            this.payee.TabIndex = 18;
            // 
            // tenantName
            // 
            this.tenantName.Location = new System.Drawing.Point(199, 309);
            this.tenantName.Name = "tenantName";
            this.tenantName.Size = new System.Drawing.Size(346, 27);
            this.tenantName.TabIndex = 17;
            // 
            // OwnerName
            // 
            this.OwnerName.Location = new System.Drawing.Point(199, 258);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(346, 27);
            this.OwnerName.TabIndex = 16;
            // 
            // ownerAddress
            // 
            this.ownerAddress.Location = new System.Drawing.Point(199, 210);
            this.ownerAddress.Name = "ownerAddress";
            this.ownerAddress.Size = new System.Drawing.Size(346, 27);
            this.ownerAddress.TabIndex = 15;
            // 
            // tenantAddress
            // 
            this.tenantAddress.Location = new System.Drawing.Point(199, 156);
            this.tenantAddress.Name = "tenantAddress";
            this.tenantAddress.Size = new System.Drawing.Size(346, 27);
            this.tenantAddress.TabIndex = 14;
            // 
            // accountType
            // 
            this.accountType.Location = new System.Drawing.Point(199, 105);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(346, 27);
            this.accountType.TabIndex = 13;
            // 
            // accountID
            // 
            this.accountID.Location = new System.Drawing.Point(199, 54);
            this.accountID.Name = "accountID";
            this.accountID.Size = new System.Drawing.Size(346, 27);
            this.accountID.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 618);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "FPM_Procedure";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 567);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tenant_Dr";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Apx_DT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tenant_Mail_Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Owner_Mail_Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Payee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tenant_Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Owner_Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Owner_Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tenant_Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account_Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account_ID";
            // 
            // userAdded_label
            // 
            this.userAdded_label.AutoSize = true;
            this.userAdded_label.Location = new System.Drawing.Point(849, 615);
            this.userAdded_label.Name = "userAdded_label";
            this.userAdded_label.Size = new System.Drawing.Size(97, 20);
            this.userAdded_label.TabIndex = 25;
            this.userAdded_label.Text = "User Added";
            this.userAdded_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 744);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "First Property Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button displayTable_button;
        private System.Windows.Forms.Label loadConnect_label;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox fpmProcedure;
        private System.Windows.Forms.TextBox tenantDr;
        private System.Windows.Forms.TextBox apxDT;
        private System.Windows.Forms.TextBox tenantMailType;
        private System.Windows.Forms.TextBox ownerMailType;
        private System.Windows.Forms.TextBox payee;
        private System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.TextBox ownerAddress;
        private System.Windows.Forms.TextBox tenantAddress;
        private System.Windows.Forms.TextBox accountID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountType;
        private System.Windows.Forms.TextBox tenantName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label userAdded_label;
    }
}

