using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TransactionManagement.ApplicationService.Enums;
using TransactionManagement.ApplicationService.ManagementServices.UserManagementServices;

namespace TransactionManagement.WindFormApp.Views.UserViews
{
    public partial class UserIndexView : Form
    {
        private readonly IUserManagementService _userManagementService;
        private UserDto _userDto;
        private EntityState _state;

        public UserIndexView(IUserManagementService userManagementService)
        {
            InitializeComponent();

            _userManagementService = userManagementService;
            
        }

        private void UserIndexView_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            _state = EntityState.Created;
            _userDto = new UserDto();
            OpenUserSaveChangesView(_state);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (_userDto.Id == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }

            _state = EntityState.Updated;
            OpenUserSaveChangesView(_state);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void dgvUserIndex_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserIndex.Rows.Count > 0)
            {
                _userDto = new UserDto
                {
                    Id = Convert.ToInt32(dgvUserIndex.CurrentRow.Cells["dgcId"].Value),
                    FirstName = dgvUserIndex.CurrentRow.Cells["dgcFirstName"].Value.ToString(),
                    LastName = dgvUserIndex.CurrentRow.Cells["dgcLastName"].Value.ToString(),
                    Gender = dgvUserIndex.CurrentRow.Cells["dgcGender"].Value.ToString(),
                    //DocumentTypeId = Convert.ToInt32(dgvUserIndex.CurrentRow.Cells["dgcDocumentType"].Value.ToString());
                    DocumentType = dgvUserIndex.CurrentRow.Cells["dgcDocumentType"].Value.ToString(),
                    DocumentCode = dgvUserIndex.CurrentRow.Cells["dgcDocumentCode"].Value.ToString(),
                    Phone = dgvUserIndex.CurrentRow.Cells["dgcPhone"].Value.ToString(),
                    City = dgvUserIndex.CurrentRow.Cells["dgcCity"].Value.ToString(),
                    Address = dgvUserIndex.CurrentRow.Cells["dgcAddress"].Value.ToString(),
                    //_userDto.UserName = dgvUserIndex.CurrentRow.Cells["dgcUserName"].Value.ToString();
                    //_userDto.Password = dgvUserIndex.CurrentRow.Cells["dgcPassword"].Value.ToString();
                };
        }
        }

        private void dgvUserIndex_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetUsers()
        {
            dgvUserIndex.Rows.Clear();

            try
            {
                IEnumerable<UserDto> users = _userManagementService.GetUserDtos();
                if (users.Any())
                {
                    foreach (UserDto user in users)
                    {
                        dgvUserIndex.Rows.Add(
                            user.Id,
                            user.FirstName,
                            user.LastName,
                            user.Gender,
                            user.DocumentType,
                            user.DocumentCode,
                            user.Phone,
                            user.City,
                            user.Address);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron usarios registrados");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void OpenUserSaveChangesView(EntityState entity)
        {
            UserSaveChangesView myForm = new UserSaveChangesView(_userManagementService, entity, _userDto);
            myForm.ShowDialog();
        }

        private void dgvUserIndex_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserIndex.Columns[e.ColumnIndex].Name == "DocumentType")
            {
                IEnumerable<ApplicationService.ManagementServices.DocumentTypeManagementService.DocumentTypeDto> documentTypes = _userManagementService.GetDocumentTypeDtos();


            }


        }
    }
}
