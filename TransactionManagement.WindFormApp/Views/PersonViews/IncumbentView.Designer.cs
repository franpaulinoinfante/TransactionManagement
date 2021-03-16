
namespace TransactionManagement.WindFormApp.Views.PersonViews
{
    partial class IncumbentView
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtIncumbentType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.TabIndex = 7;
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.Location = new System.Drawing.Point(169, 142);
            this.cmbDocumentType.Size = new System.Drawing.Size(173, 24);
            this.cmbDocumentType.TabIndex = 4;
            // 
            // mtbDocumentCode
            // 
            this.mtbDocumentCode.Location = new System.Drawing.Point(512, 137);
            this.mtbDocumentCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(99, 59);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(100, 89);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(122, 118);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(34, 145);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(357, 140);
            // 
            // txttFirstName
            // 
            this.txttFirstName.Location = new System.Drawing.Point(169, 56);
            this.txttFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(169, 86);
            this.txtLastName.TabIndex = 1;
            // 
            // rbtMan
            // 
            this.rbtMan.Location = new System.Drawing.Point(169, 116);
            this.rbtMan.TabIndex = 2;
            // 
            // rbtWoman
            // 
            this.rbtWoman.Location = new System.Drawing.Point(260, 116);
            this.rbtWoman.TabIndex = 3;
            // 
            // mtbPhone
            // 
            this.mtbPhone.TabIndex = 8;
            // 
            // btnNew
            // 
            this.btnNew.TabIndex = 9;
            // 
            // btnEdit
            // 
            this.btnEdit.TabIndex = 10;
            // 
            // btnRemove
            // 
            this.btnRemove.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.TabIndex = 12;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "T&ipo de Documento :";
            // 
            // txtIncumbentType
            // 
            this.txtIncumbentType.Location = new System.Drawing.Point(169, 26);
            this.txtIncumbentType.Name = "txtIncumbentType";
            this.txtIncumbentType.ReadOnly = true;
            this.txtIncumbentType.Size = new System.Drawing.Size(252, 24);
            this.txtIncumbentType.TabIndex = 16;
            // 
            // IncumbentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 474);
            this.Controls.Add(this.txtIncumbentType);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "IncumbentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncumbentView";
            this.Load += new System.EventHandler(this.IncumbentView_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txttFirstName, 0);
            this.Controls.SetChildIndex(this.txtLastName, 0);
            this.Controls.SetChildIndex(this.rbtMan, 0);
            this.Controls.SetChildIndex(this.rbtWoman, 0);
            this.Controls.SetChildIndex(this.mtbPhone, 0);
            this.Controls.SetChildIndex(this.txtCity, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.cmbDocumentType, 0);
            this.Controls.SetChildIndex(this.mtbDocumentCode, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnEdit, 0);
            this.Controls.SetChildIndex(this.btnRemove, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnSaveChanges, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtIncumbentType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIncumbentType;
    }
}