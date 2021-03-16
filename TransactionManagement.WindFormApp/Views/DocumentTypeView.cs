using System;
using System.Windows.Forms;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.WindFormApp.ViewHelpers;
using TransactionManagement.WinFormApp.Controllers;

namespace TransactionManagement.WinFormApp.Views
{
    public partial class DocumentTypeView : Form
    {
        private readonly IDocumentTypeManagementService _documentTypeManagementService;
        private DocumentTypeDto _dto;
        private int _id;

        internal DocumentTypeView(IDocumentTypeManagementService documentTypeManagementService)
        {
            InitializeComponent();

            //Controllers.DocumentTypeController _documentTypeController = new DocumentTypeController(documentTypeManagementService, this);

            _documentTypeManagementService = documentTypeManagementService;

            _dto = new DocumentTypeDto();
        }

        private void DocumentTypeView_Load(object sender, EventArgs e)
        {
            GetDocumentTypes();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ActiveControls();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de document");
                return;
            }

            ActiveControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SetDataToDto();
                if (_id == 0)
                {
                    MessageBox.Show("Debe seleccionar un tipo de document");
                    return;
                }

                _documentTypeManagementService.RemoveDocumentType(_dto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception();
            }

            GetDocumentTypes();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BlockControls();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                SetDataToDto();
                if (_id == 0)
                {
                    _documentTypeManagementService.CreateDocumentType(_dto);
                }
                else
                {
                    _documentTypeManagementService.UpdateDocumentType(_dto);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefreshContronllers();
            GetDocumentTypes();
            BlockControls();
        }

        private void btnFindBy_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentTypeDto documentTypeDto = _documentTypeManagementService.GetDocumentTypeById(_dto);

                MessageBox.Show($"Id - { documentTypeDto.Id }\nTipo de Documento - { documentTypeDto.DocumentType }\nDescripción - { documentTypeDto.Description }");

                txtFindByDocumentType.Clear();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDocumentType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocumentType.Rows.Count > 0)
            {
                _id = Convert.ToInt32(dgvDocumentType.CurrentRow.Cells["Id"].Value);
                txtDocumentType.Text = dgvDocumentType.CurrentRow.Cells["DocumentType"].Value.ToString();
                txtDescription.Text = dgvDocumentType.CurrentRow.Cells["Description"].Value.ToString();
            }
        }

        private void SetDataToDto()
        {
            _dto = new DocumentTypeDto
            {
                Id = _id,
                DocumentType = txtDocumentType.Text,
                Description = txtDescription.Text
            };
        }

        private void GetDocumentTypes()
        {
            try
            {
                dgvDocumentType.DataSource = _documentTypeManagementService.GetDocumentTypeDtos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActiveControls()
        {
            ActionInControls.ActiveControls(panel1);

            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnFindBy.Enabled = false;

            txtFindByDocumentType.ReadOnly = true;
            txtDocumentType.Focus();
        }

        private void BlockControls()
        {
            ActionInControls.BlockControls(panel1);

            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnFindBy.Enabled = true;

            txtFindByDocumentType.ReadOnly = false;
            btnNew.Focus();
        }
        private void RefreshContronllers()
        {
            ActionInControls.RefreshControls(panel1);

            txtFindByDocumentType.Clear();

            _id = 0;
        }
    }
}
