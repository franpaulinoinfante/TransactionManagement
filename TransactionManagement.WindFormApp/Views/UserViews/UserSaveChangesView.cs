using System.Windows.Forms;
using TransactionManagement.ApplicationService.Enums;
using TransactionManagement.ApplicationService.ManagementServices.UserManagementServices;

namespace TransactionManagement.WindFormApp.Views.UserViews
{
    public partial class UserSaveChangesView : Form
    {
        private readonly IUserManagementService _userManagementService;
        private readonly UserDto _userDto;
        private readonly EntityState _state;

        public UserSaveChangesView(IUserManagementService userManagementService, EntityState state, UserDto userDto)
        {
            InitializeComponent();

            _userManagementService = userManagementService;
            _state = state;
            _userDto = userDto;
        }

        private void UserSaveChangesView_Load(object sender, System.EventArgs e)
        {
            if (_userDto.Id > 0)
            {
                LoadProperties();
            }
        }

        private void SetValueToPropertu()
        {
            if (_userDto != null)
            {
                txtFirstName.Text = _userDto.FirstName.Trim();
                txtLastName.Text = _userDto.LastName.Trim();
                mtbDocumentCode.Text = _userDto.DocumentCode.Trim();
                mtbPhone.Text = _userDto.Phone.Trim();
                txtCity.Text = _userDto.City.Trim();
                txtAddress.Text = _userDto.Address.Trim();
                //txtUserName.Text = _userDto.UserName.Trim();
                //txtPassword.Text = _userDto.Password.Trim();

                cmbDocumentType.Text = _userDto.DocumentType;
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void btnSaveChanges_Click(object sender, System.EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {

        }

        private void btnClearFields_Click(object sender, System.EventArgs e)
        {

        }

        private void LoadProperties()
        {
            cmbDocumentType.ValueMember = "Id";
            cmbDocumentType.DisplayMember = "DocumentType";
            cmbDocumentType.DataSource = _userManagementService.GetDocumentTypeDtos();

            txtFirstName.Text = _userDto.FirstName.Trim();
            txtLastName.Text = _userDto.LastName.Trim();
            mtbDocumentCode.Text = _userDto.DocumentCode.Trim();
            mtbPhone.Text = _userDto.Phone.Trim();
            txtCity.Text = _userDto.City.Trim();
            txtAddress.Text = _userDto.Address.Trim();
            //txtUserName.Text = _userDto.UserName.Trim();
            //txtPassword.Text = _userDto.Password.Trim();

            cmbDocumentType.Text = _userDto.DocumentType;
        }

        private void SaveChanges()
        {
            SetValueToUserDto();

            _userManagementService.CreateUser(_userDto, _state);
        }

        private void SetValueToUserDto()
        {
            _userDto.FirstName = txtFirstName.Text.Trim();
            _userDto.LastName = txtLastName.Text.Trim();
            _userDto.DocumentTypeId = (int)cmbDocumentType.SelectedValue;
            _userDto.DocumentCode = mtbDocumentCode.Text.Trim();
            _userDto.Phone = mtbPhone.Text.Trim();
            _userDto.City = txtCity.Text.Trim();
            _userDto.Address = txtAddress.Text.Trim();

            if (rdbMan.Checked)
            {
                _userDto.Gender = "Masculino";
            }
            else
            {
                _userDto.Gender = "Femenino";
            }
        }
    }
}
