
namespace TransactionManagement.WindFormApp.Views.BankViews
{
    partial class BankView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.mtbPhoneBank = new System.Windows.Forms.MaskedTextBox();
            this.txtCityBank = new System.Windows.Forms.TextBox();
            this.txtAddressBank = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteBank = new System.Windows.Forms.Button();
            this.btnCancelChangesBank = new System.Windows.Forms.Button();
            this.btnNewBank = new System.Windows.Forms.Button();
            this.btnUpdateBank = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteBankAccount = new System.Windows.Forms.Button();
            this.btnCancelChangeToBankAccount = new System.Windows.Forms.Button();
            this.btnCreateBankAccount = new System.Windows.Forms.Button();
            this.btnUpdateBankAccount = new System.Windows.Forms.Button();
            this.rdbItIsNotLocked = new System.Windows.Forms.RadioButton();
            this.rdbItIsLocked = new System.Windows.Forms.RadioButton();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.txtIncumbent = new System.Windows.Forms.TextBox();
            this.txtBalanceAvailable = new System.Windows.Forms.TextBox();
            this.txtBalanceInTransit = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbBank = new System.Windows.Forms.ComboBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(590, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Banco :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Teléfono :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Ciudad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Dirección :";
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(88, 21);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.Size = new System.Drawing.Size(253, 24);
            this.txtBankName.TabIndex = 5;
            // 
            // mtbPhoneBank
            // 
            this.mtbPhoneBank.Location = new System.Drawing.Point(88, 51);
            this.mtbPhoneBank.Mask = "(999) 000-0000";
            this.mtbPhoneBank.Name = "mtbPhoneBank";
            this.mtbPhoneBank.Size = new System.Drawing.Size(253, 24);
            this.mtbPhoneBank.TabIndex = 6;
            // 
            // txtCityBank
            // 
            this.txtCityBank.Location = new System.Drawing.Point(88, 81);
            this.txtCityBank.Name = "txtCityBank";
            this.txtCityBank.Size = new System.Drawing.Size(253, 24);
            this.txtCityBank.TabIndex = 7;
            // 
            // txtAddressBank
            // 
            this.txtAddressBank.Location = new System.Drawing.Point(88, 111);
            this.txtAddressBank.Name = "txtAddressBank";
            this.txtAddressBank.Size = new System.Drawing.Size(253, 24);
            this.txtAddressBank.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteBank);
            this.groupBox1.Controls.Add(this.btnCancelChangesBank);
            this.groupBox1.Controls.Add(this.btnNewBank);
            this.groupBox1.Controls.Add(this.btnUpdateBank);
            this.groupBox1.Controls.Add(this.txtBankName);
            this.groupBox1.Controls.Add(this.txtAddressBank);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCityBank);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbPhoneBank);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(79, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 203);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banco";
            // 
            // btnDeleteBank
            // 
            this.btnDeleteBank.Location = new System.Drawing.Point(185, 141);
            this.btnDeleteBank.Name = "btnDeleteBank";
            this.btnDeleteBank.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBank.TabIndex = 16;
            this.btnDeleteBank.Text = "Eliminar";
            this.btnDeleteBank.UseVisualStyleBackColor = true;
            this.btnDeleteBank.Click += new System.EventHandler(this.btnDeleteBank_Click);
            // 
            // btnCancelChangesBank
            // 
            this.btnCancelChangesBank.Location = new System.Drawing.Point(266, 141);
            this.btnCancelChangesBank.Name = "btnCancelChangesBank";
            this.btnCancelChangesBank.Size = new System.Drawing.Size(75, 23);
            this.btnCancelChangesBank.TabIndex = 17;
            this.btnCancelChangesBank.Text = "Cancelar";
            this.btnCancelChangesBank.UseVisualStyleBackColor = true;
            this.btnCancelChangesBank.Click += new System.EventHandler(this.btnCancelChangesBank_Click);
            // 
            // btnNewBank
            // 
            this.btnNewBank.Location = new System.Drawing.Point(23, 141);
            this.btnNewBank.Name = "btnNewBank";
            this.btnNewBank.Size = new System.Drawing.Size(75, 23);
            this.btnNewBank.TabIndex = 14;
            this.btnNewBank.Text = "Nuevo";
            this.btnNewBank.UseVisualStyleBackColor = true;
            this.btnNewBank.Click += new System.EventHandler(this.btnNewBank_Click);
            // 
            // btnUpdateBank
            // 
            this.btnUpdateBank.Location = new System.Drawing.Point(104, 141);
            this.btnUpdateBank.Name = "btnUpdateBank";
            this.btnUpdateBank.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBank.TabIndex = 15;
            this.btnUpdateBank.Text = "Editar";
            this.btnUpdateBank.UseVisualStyleBackColor = true;
            this.btnUpdateBank.Click += new System.EventHandler(this.btnUpdateBank_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteBankAccount);
            this.groupBox2.Controls.Add(this.btnCancelChangeToBankAccount);
            this.groupBox2.Controls.Add(this.btnCreateBankAccount);
            this.groupBox2.Controls.Add(this.btnUpdateBankAccount);
            this.groupBox2.Controls.Add(this.rdbItIsNotLocked);
            this.groupBox2.Controls.Add(this.rdbItIsLocked);
            this.groupBox2.Controls.Add(this.txtAccountType);
            this.groupBox2.Controls.Add(this.txtIncumbent);
            this.groupBox2.Controls.Add(this.txtBalanceAvailable);
            this.groupBox2.Controls.Add(this.txtBalanceInTransit);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtAccountNumber);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbBank);
            this.groupBox2.Location = new System.Drawing.Point(594, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 203);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // btnDeleteBankAccount
            // 
            this.btnDeleteBankAccount.Location = new System.Drawing.Point(390, 174);
            this.btnDeleteBankAccount.Name = "btnDeleteBankAccount";
            this.btnDeleteBankAccount.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBankAccount.TabIndex = 34;
            this.btnDeleteBankAccount.Text = "Eliminar";
            this.btnDeleteBankAccount.UseVisualStyleBackColor = true;
            this.btnDeleteBankAccount.Click += new System.EventHandler(this.btnDeleteBankAccount_Click);
            // 
            // btnCancelChangeToBankAccount
            // 
            this.btnCancelChangeToBankAccount.Location = new System.Drawing.Point(486, 174);
            this.btnCancelChangeToBankAccount.Name = "btnCancelChangeToBankAccount";
            this.btnCancelChangeToBankAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCancelChangeToBankAccount.TabIndex = 35;
            this.btnCancelChangeToBankAccount.Text = "Cancelar";
            this.btnCancelChangeToBankAccount.UseVisualStyleBackColor = true;
            this.btnCancelChangeToBankAccount.Click += new System.EventHandler(this.btnCancelChangeToBankAccount_Click);
            // 
            // btnCreateBankAccount
            // 
            this.btnCreateBankAccount.Location = new System.Drawing.Point(390, 145);
            this.btnCreateBankAccount.Name = "btnCreateBankAccount";
            this.btnCreateBankAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCreateBankAccount.TabIndex = 32;
            this.btnCreateBankAccount.Text = "Nuevo";
            this.btnCreateBankAccount.UseVisualStyleBackColor = true;
            this.btnCreateBankAccount.Click += new System.EventHandler(this.btnCreateBankAccount_Click);
            // 
            // btnUpdateBankAccount
            // 
            this.btnUpdateBankAccount.Location = new System.Drawing.Point(486, 145);
            this.btnUpdateBankAccount.Name = "btnUpdateBankAccount";
            this.btnUpdateBankAccount.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBankAccount.TabIndex = 33;
            this.btnUpdateBankAccount.Text = "Editar";
            this.btnUpdateBankAccount.UseVisualStyleBackColor = true;
            this.btnUpdateBankAccount.Click += new System.EventHandler(this.btnUpdateBankAccount_Click);
            // 
            // rdbItIsNotLocked
            // 
            this.rdbItIsNotLocked.AutoSize = true;
            this.rdbItIsNotLocked.Location = new System.Drawing.Point(203, 87);
            this.rdbItIsNotLocked.Name = "rdbItIsNotLocked";
            this.rdbItIsNotLocked.Size = new System.Drawing.Size(44, 20);
            this.rdbItIsNotLocked.TabIndex = 31;
            this.rdbItIsNotLocked.TabStop = true;
            this.rdbItIsNotLocked.Text = "No";
            this.rdbItIsNotLocked.UseVisualStyleBackColor = true;
            // 
            // rdbItIsLocked
            // 
            this.rdbItIsLocked.AutoSize = true;
            this.rdbItIsLocked.Location = new System.Drawing.Point(148, 87);
            this.rdbItIsLocked.Name = "rdbItIsLocked";
            this.rdbItIsLocked.Size = new System.Drawing.Size(37, 20);
            this.rdbItIsLocked.TabIndex = 30;
            this.rdbItIsLocked.TabStop = true;
            this.rdbItIsLocked.Text = "Si";
            this.rdbItIsLocked.UseVisualStyleBackColor = true;
            // 
            // txtAccountType
            // 
            this.txtAccountType.Location = new System.Drawing.Point(148, 57);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(171, 24);
            this.txtAccountType.TabIndex = 29;
            // 
            // txtIncumbent
            // 
            this.txtIncumbent.Location = new System.Drawing.Point(390, 57);
            this.txtIncumbent.Name = "txtIncumbent";
            this.txtIncumbent.Size = new System.Drawing.Size(171, 24);
            this.txtIncumbent.TabIndex = 28;
            // 
            // txtBalanceAvailable
            // 
            this.txtBalanceAvailable.Location = new System.Drawing.Point(148, 173);
            this.txtBalanceAvailable.Name = "txtBalanceAvailable";
            this.txtBalanceAvailable.Size = new System.Drawing.Size(171, 24);
            this.txtBalanceAvailable.TabIndex = 27;
            // 
            // txtBalanceInTransit
            // 
            this.txtBalanceInTransit.Location = new System.Drawing.Point(148, 143);
            this.txtBalanceInTransit.Name = "txtBalanceInTransit";
            this.txtBalanceInTransit.Size = new System.Drawing.Size(171, 24);
            this.txtBalanceInTransit.TabIndex = 26;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(148, 113);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(171, 24);
            this.txtBalance.TabIndex = 25;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(390, 87);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(171, 24);
            this.txtAccountNumber.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ba&nco :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "&Emisor :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "T&ipo de Cuenta :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Está Bloqueada ?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Bal&ance Disponible :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ba&lance En Transito :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "B&alance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "C&uenta :";
            // 
            // cbbBank
            // 
            this.cbbBank.FormattingEnabled = true;
            this.cbbBank.Location = new System.Drawing.Point(148, 27);
            this.cbbBank.Name = "cbbBank";
            this.cbbBank.Size = new System.Drawing.Size(413, 24);
            this.cbbBank.TabIndex = 14;
            this.cbbBank.SelectedIndexChanged += new System.EventHandler(this.cbbBank_SelectedIndexChanged);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AllowUserToOrderColumns = true;
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(594, 222);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.Size = new System.Drawing.Size(590, 389);
            this.dgvAccount.TabIndex = 11;
            this.dgvAccount.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentDoubleClick);
            // 
            // BankView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BankView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankView";
            this.Load += new System.EventHandler(this.BankView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.MaskedTextBox mtbPhoneBank;
        private System.Windows.Forms.TextBox txtCityBank;
        private System.Windows.Forms.TextBox txtAddressBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteBank;
        private System.Windows.Forms.Button btnCancelChangesBank;
        private System.Windows.Forms.Button btnNewBank;
        private System.Windows.Forms.Button btnUpdateBank;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.ComboBox cbbBank;
        private System.Windows.Forms.RadioButton rdbItIsNotLocked;
        private System.Windows.Forms.RadioButton rdbItIsLocked;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.TextBox txtIncumbent;
        private System.Windows.Forms.TextBox txtBalanceAvailable;
        private System.Windows.Forms.TextBox txtBalanceInTransit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteBankAccount;
        private System.Windows.Forms.Button btnCancelChangeToBankAccount;
        private System.Windows.Forms.Button btnCreateBankAccount;
        private System.Windows.Forms.Button btnUpdateBankAccount;
    }
}