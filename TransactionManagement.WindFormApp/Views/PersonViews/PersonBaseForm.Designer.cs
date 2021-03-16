
namespace TransactionManagement.WindFormApp.Views.PersonViews
{
    partial class PersonBaseForm
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
            this.dgvPersonBase = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.rbtMan = new System.Windows.Forms.RadioButton();
            this.rbtWoman = new System.Windows.Forms.RadioButton();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.mtbDocumentCode = new System.Windows.Forms.MaskedTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonBase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonBase
            // 
            this.dgvPersonBase.AllowUserToAddRows = false;
            this.dgvPersonBase.AllowUserToDeleteRows = false;
            this.dgvPersonBase.AllowUserToOrderColumns = true;
            this.dgvPersonBase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPersonBase.Location = new System.Drawing.Point(0, 192);
            this.dgvPersonBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPersonBase.Name = "dgvPersonBase";
            this.dgvPersonBase.ReadOnly = true;
            this.dgvPersonBase.Size = new System.Drawing.Size(969, 282);
            this.dgvPersonBase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Apellido :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Sexo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Teléfono :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "&Ciudad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Dirección :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "T&ipo de Documento :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "C&odigo del Documento :";
            // 
            // txttFirstName
            // 
            this.txttFirstName.Location = new System.Drawing.Point(169, 24);
            this.txttFirstName.Name = "txttFirstName";
            this.txttFirstName.ReadOnly = true;
            this.txttFirstName.Size = new System.Drawing.Size(252, 24);
            this.txttFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(169, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(252, 24);
            this.txtLastName.TabIndex = 10;
            // 
            // rbtMan
            // 
            this.rbtMan.AutoSize = true;
            this.rbtMan.Enabled = false;
            this.rbtMan.Location = new System.Drawing.Point(169, 84);
            this.rbtMan.Name = "rbtMan";
            this.rbtMan.Size = new System.Drawing.Size(85, 20);
            this.rbtMan.TabIndex = 11;
            this.rbtMan.TabStop = true;
            this.rbtMan.Text = "Masculino";
            this.rbtMan.UseVisualStyleBackColor = true;
            // 
            // rbtWoman
            // 
            this.rbtWoman.AutoSize = true;
            this.rbtWoman.Enabled = false;
            this.rbtWoman.Location = new System.Drawing.Point(260, 84);
            this.rbtWoman.Name = "rbtWoman";
            this.rbtWoman.Size = new System.Drawing.Size(82, 20);
            this.rbtWoman.TabIndex = 12;
            this.rbtWoman.TabStop = true;
            this.rbtWoman.Text = "Femenino";
            this.rbtWoman.UseVisualStyleBackColor = true;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(512, 100);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.ReadOnly = true;
            this.mtbPhone.Size = new System.Drawing.Size(252, 24);
            this.mtbPhone.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(512, 26);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(252, 24);
            this.txtCity.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(512, 56);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(252, 38);
            this.txtAddress.TabIndex = 15;
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.Enabled = false;
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(169, 110);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(252, 24);
            this.cmbDocumentType.TabIndex = 16;
            // 
            // mtbDocumentCode
            // 
            this.mtbDocumentCode.Location = new System.Drawing.Point(169, 140);
            this.mtbDocumentCode.Mask = "999-9999999-9";
            this.mtbDocumentCode.Name = "mtbDocumentCode";
            this.mtbDocumentCode.ReadOnly = true;
            this.mtbDocumentCode.Size = new System.Drawing.Size(252, 24);
            this.mtbDocumentCode.TabIndex = 17;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(774, 26);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(83, 54);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "N&uevo";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(865, 26);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 54);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "&Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(774, 86);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 54);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "E&liminar";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(865, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 54);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Ca&ncelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(786, 146);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(154, 39);
            this.btnSaveChanges.TabIndex = 22;
            this.btnSaveChanges.Text = "&Guardar Cambios";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // PersonBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 474);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.mtbDocumentCode);
            this.Controls.Add(this.cmbDocumentType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.rbtWoman);
            this.Controls.Add(this.rbtMan);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txttFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersonBase);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.TextBox txtCity;
        protected internal System.Windows.Forms.TextBox txtAddress;
        protected internal System.Windows.Forms.ComboBox cmbDocumentType;
        protected internal System.Windows.Forms.MaskedTextBox mtbDocumentCode;
        protected internal System.Windows.Forms.DataGridView dgvPersonBase;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.Label label8;
        protected internal System.Windows.Forms.TextBox txttFirstName;
        protected internal System.Windows.Forms.TextBox txtLastName;
        protected internal System.Windows.Forms.RadioButton rbtMan;
        protected internal System.Windows.Forms.RadioButton rbtWoman;
        protected internal System.Windows.Forms.MaskedTextBox mtbPhone;
        protected internal System.Windows.Forms.Button btnNew;
        protected internal System.Windows.Forms.Button btnEdit;
        protected internal System.Windows.Forms.Button btnRemove;
        protected internal System.Windows.Forms.Button btnCancel;
        protected internal System.Windows.Forms.Button btnSaveChanges;
    }
}