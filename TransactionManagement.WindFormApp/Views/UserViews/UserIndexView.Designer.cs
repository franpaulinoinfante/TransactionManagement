
namespace TransactionManagement.WindFormApp.Views.UserViews
{
    partial class UserIndexView
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
            this.dgvUserIndex = new System.Windows.Forms.DataGridView();
            this.dgcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDocumentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcDocumentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserIndex
            // 
            this.dgvUserIndex.AllowUserToAddRows = false;
            this.dgvUserIndex.AllowUserToDeleteRows = false;
            this.dgvUserIndex.AllowUserToOrderColumns = true;
            this.dgvUserIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserIndex.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserIndex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcId,
            this.dgcFirstName,
            this.dgcLastName,
            this.dgcGender,
            this.dgcDocumentType,
            this.dgcDocumentCode,
            this.dgcPhone,
            this.dgcCity,
            this.dgcAddress});
            this.dgvUserIndex.Location = new System.Drawing.Point(2, 49);
            this.dgvUserIndex.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserIndex.Name = "dgvUserIndex";
            this.dgvUserIndex.ReadOnly = true;
            this.dgvUserIndex.Size = new System.Drawing.Size(1003, 562);
            this.dgvUserIndex.TabIndex = 0;
            this.dgvUserIndex.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserIndex_CellContentDoubleClick);
            this.dgvUserIndex.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserIndex_CellValueChanged);
            // 
            // dgcId
            // 
            this.dgcId.HeaderText = "Id";
            this.dgcId.Name = "dgcId";
            this.dgcId.ReadOnly = true;
            this.dgcId.Width = 107;
            // 
            // dgcFirstName
            // 
            this.dgcFirstName.HeaderText = "Nombre";
            this.dgcFirstName.Name = "dgcFirstName";
            this.dgcFirstName.ReadOnly = true;
            this.dgcFirstName.Width = 106;
            // 
            // dgcLastName
            // 
            this.dgcLastName.HeaderText = "Apellido";
            this.dgcLastName.Name = "dgcLastName";
            this.dgcLastName.ReadOnly = true;
            this.dgcLastName.Width = 107;
            // 
            // dgcGender
            // 
            this.dgcGender.HeaderText = "Genero";
            this.dgcGender.Name = "dgcGender";
            this.dgcGender.ReadOnly = true;
            this.dgcGender.Width = 107;
            // 
            // dgcDocumentType
            // 
            this.dgcDocumentType.HeaderText = "Tipo de Documento";
            this.dgcDocumentType.Name = "dgcDocumentType";
            this.dgcDocumentType.ReadOnly = true;
            this.dgcDocumentType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcDocumentType.Width = 106;
            // 
            // dgcDocumentCode
            // 
            this.dgcDocumentCode.HeaderText = "Código del Documento";
            this.dgcDocumentCode.Name = "dgcDocumentCode";
            this.dgcDocumentCode.ReadOnly = true;
            this.dgcDocumentCode.Width = 107;
            // 
            // dgcPhone
            // 
            this.dgcPhone.HeaderText = "Teléfono";
            this.dgcPhone.Name = "dgcPhone";
            this.dgcPhone.ReadOnly = true;
            this.dgcPhone.Width = 107;
            // 
            // dgcCity
            // 
            this.dgcCity.HeaderText = "Ciudad";
            this.dgcCity.Name = "dgcCity";
            this.dgcCity.ReadOnly = true;
            this.dgcCity.Width = 106;
            // 
            // dgcAddress
            // 
            this.dgcAddress.HeaderText = "Dirección";
            this.dgcAddress.Name = "dgcAddress";
            this.dgcAddress.ReadOnly = true;
            this.dgcAddress.Width = 107;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(704, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 24);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(892, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(13, 13);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(103, 28);
            this.btnNewUser.TabIndex = 3;
            this.btnNewUser.Text = "Nuevo";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(235, 13);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(103, 28);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(124, 13);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(103, 28);
            this.btnEditUser.TabIndex = 5;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // UserIndexView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvUserIndex);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserIndexView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserView";
            this.Load += new System.EventHandler(this.UserIndexView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserIndex;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocumentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcDocumentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcAddress;
    }
}