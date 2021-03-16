using System;
using System.Collections.Generic;
using TransactionManagement.ApplicationService.ManagementServices.PersonManagementService.Icumbent;
using TransactionManagement.WindFormApp.ViewHelpers;

namespace TransactionManagement.WindFormApp.Views.PersonViews
{
    public partial class IncumbentView : PersonBaseForm
    {
        private readonly IIncumbentManagementService _incumbentManagementServie;
        private readonly IncumbentDto _incumbentDto;
        private int _id;

        public IncumbentView(IIncumbentManagementService incumbentManagementServie)
        {
            InitializeComponent();

            _incumbentManagementServie = incumbentManagementServie;
            _incumbentDto = new IncumbentDto();
        }

        private void IncumbentView_Load(object sender, EventArgs e)
        {
            GetIncumbents();
            GetDocumentTypes();
        }

        private void GetIncumbents()
        {
            IEnumerable<IncumbentDto> incumbentDtos = _incumbentManagementServie.GetIncumbentEntities();

            dgvPersonBase.Rows.Clear();
            AddColumnsToDataGridView();

            foreach (IncumbentDto incumbent in incumbentDtos)
            {
                dgvPersonBase.Rows.Add(incumbent.IncumbentType, incumbent.FirstName, incumbent.LastName, incumbent.Gender, incumbent.DocumentTypeId, incumbent.DocumentCode, incumbent.Phone, incumbent.City, incumbent.Address);
            }
        }

        private void GetDocumentTypes()
        {
            cmbDocumentType.ValueMember = "Id";
            cmbDocumentType.DisplayMember = "DocumentType";
            cmbDocumentType.DataSource = _incumbentManagementServie.GetDocumentTypeDtos();
        }

        private void SetDataToDto()
        {
            _incumbentDto.Id = _id;
            _incumbentDto.IncumbentType = txtIncumbentType.Text.Trim();
            _incumbentDto.FirstName = txttFirstName.Text.Trim();
            _incumbentDto.LastName = txtLastName.Text.Trim();

            if (rbtMan.Checked)
            {
                _incumbentDto.Gender = "Masculino";
            }
            else
            {
                if (rbtWoman.Checked)
                {
                    _incumbentDto.Gender = "Femenino";
                }
            }

            _incumbentDto.DocumentTypeId = (int)cmbDocumentType.SelectedValue;
            _incumbentDto.DocumentCode = mtbDocumentCode.Text.Trim();
            _incumbentDto.Phone = mtbDocumentCode.Text.Trim();
            _incumbentDto.City = txtCity.Text.Trim();
            _incumbentDto.Address = txtAddress.Text.Trim();
        }

        private void AddColumnsToDataGridView()
        {
            dgvPersonBase.Columns.Add("IncumbentTypeColumn", "Emisor");
            dgvPersonBase.Columns.Add("FirstNameCoulumn", "Nombre");
            dgvPersonBase.Columns.Add("LastNameCoulumn", "Apellido");
            dgvPersonBase.Columns.Add("GenderCoulumn", "Genero");
            dgvPersonBase.Columns.Add("DocumentTypeIdCoulumn", "Tipo de Documento");
            dgvPersonBase.Columns.Add("DocumentCodeCoulumn", "Código");
            dgvPersonBase.Columns.Add("PhoneCoulumn", "Teléfono");
            dgvPersonBase.Columns.Add("CityCoulumn", "Ciudad");
            dgvPersonBase.Columns.Add("AddressCoulumn", "Dirección");
        }

        private void ActiveControls()
        {
            ActionInControls.ActiveControls(this);

            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnRemove.Enabled = false;

            btnCancel.Enabled = true;

            txtIncumbentType.Focus();
        }

        private void BlockControls()
        {
            ActionInControls.BlockControls(this);

            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnRemove.Enabled = true;

            btnCancel.Enabled = false;

            btnNew.Focus();
        }
        private void RefreshContronllers()
        {
            ActionInControls.RefreshControls(this);

            _id = 0;
        }
    }
}
