
namespace TransactionManagement.WinFormApp.Views
{
    partial class DocumentTypeView
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
            this.dgvDocumentType = new System.Windows.Forms.DataGridView();
            this.txtDocumentType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtFindByDocumentType = new System.Windows.Forms.TextBox();
            this.btnFindBy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentType)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocumentType
            // 
            this.dgvDocumentType.AllowUserToAddRows = false;
            this.dgvDocumentType.AllowUserToDeleteRows = false;
            this.dgvDocumentType.AllowUserToOrderColumns = true;
            this.dgvDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocumentType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocumentType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvDocumentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentType.Location = new System.Drawing.Point(12, 45);
            this.dgvDocumentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDocumentType.Name = "dgvDocumentType";
            this.dgvDocumentType.ReadOnly = true;
            this.dgvDocumentType.Size = new System.Drawing.Size(497, 182);
            this.dgvDocumentType.TabIndex = 0;
            this.dgvDocumentType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentType_CellDoubleClick);
            // 
            // txtDocumentType
            // 
            this.txtDocumentType.Location = new System.Drawing.Point(12, 33);
            this.txtDocumentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDocumentType.Name = "txtDocumentType";
            this.txtDocumentType.ReadOnly = true;
            this.txtDocumentType.Size = new System.Drawing.Size(232, 24);
            this.txtDocumentType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Tipo de Documento :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Descripción :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 81);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(232, 51);
            this.txtDescription.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveChanges);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtDocumentType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(515, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 240);
            this.panel1.TabIndex = 5;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(41, 204);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(176, 24);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Guardar Cambios";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(132, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(132, 139);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(41, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 24);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(41, 139);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 24);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtFindByDocumentType
            // 
            this.txtFindByDocumentType.Location = new System.Drawing.Point(12, 13);
            this.txtFindByDocumentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindByDocumentType.Name = "txtFindByDocumentType";
            this.txtFindByDocumentType.Size = new System.Drawing.Size(401, 24);
            this.txtFindByDocumentType.TabIndex = 0;
            // 
            // btnFindBy
            // 
            this.btnFindBy.Location = new System.Drawing.Point(419, 14);
            this.btnFindBy.Name = "btnFindBy";
            this.btnFindBy.Size = new System.Drawing.Size(85, 24);
            this.btnFindBy.TabIndex = 2;
            this.btnFindBy.Text = "Buscar";
            this.btnFindBy.UseVisualStyleBackColor = true;
            this.btnFindBy.Click += new System.EventHandler(this.btnFindBy_Click);
            // 
            // DocumentTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 240);
            this.Controls.Add(this.btnFindBy);
            this.Controls.Add(this.txtFindByDocumentType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDocumentType);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(726, 279);
            this.Name = "DocumentTypeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document Type";
            this.Load += new System.EventHandler(this.DocumentTypeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgvDocumentType;
        internal System.Windows.Forms.TextBox txtDocumentType;
        internal System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnSaveChanges;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.TextBox txtFindByDocumentType;
        internal System.Windows.Forms.Button btnFindBy;
    }
}