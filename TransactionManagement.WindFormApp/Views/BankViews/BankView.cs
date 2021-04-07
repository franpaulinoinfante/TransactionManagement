using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TransactionManagement.ApplicationService.Adapters.DTOs;
using TransactionManagement.ApplicationService.Application.ManagementServices;

namespace TransactionManagement.WindFormApp.Views.BankViews
{
    public partial class BankView : Form
    {
        private readonly IBankManagementService _bankManagementService;
        private BankDto _bankDto;
        private int _id;
        private int _bankAccountId;

        public BankView(IBankManagementService bankManagementService)
        {
            InitializeComponent();

            _bankManagementService = bankManagementService;
            _bankDto = new BankDto();
        }

        private void BankView_Load(object sender, EventArgs e)
        {
            GetBanks();
            GetBanksToComboBox();
        }

        private void btnNewBank_Click(object sender, EventArgs e)
        {
            try
            {
                SetDataToBankDto();

                if (string.IsNullOrWhiteSpace(_bankDto.BankName) || string.IsNullOrWhiteSpace(_bankDto.Phone) ||
                    string.IsNullOrWhiteSpace(_bankDto.City)     || string.IsNullOrWhiteSpace(_bankDto.Address))
                {
                    MessageBox.Show("Debe de completar todos los campos");
                    return;
                }

                _bankManagementService.CreateBank(_bankDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearFields();
                GetBanks();
            }

        }

        private void btnUpdateBank_Click(object sender, EventArgs e)
        {
            if (_id > 0)
            {
                try
                {
                    SetDataToBankDto();
                    _bankManagementService.UpdateBank(_bankDto);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    GetBanks();
                    ClearFields();
                }
            }
        }

        private void btnDeleteBank_Click(object sender, EventArgs e)
        {
            if (_id>0)
            {
                try
                {
                    _bankManagementService.RemoveBank(_id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    GetBanks();
                    ClearFields();
                }
            }
        }

        private void btnCancelChangesBank_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                _id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                txtBankName.Text = dataGridView1.CurrentRow.Cells["BankName"].Value.ToString();
                mtbPhoneBank.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
                txtCityBank.Text = dataGridView1.CurrentRow.Cells["City"].Value.ToString();
                txtAddressBank.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            }

            txtBankName.Focus();
        }

        private void btnCreateBankAccount_Click(object sender, EventArgs e)
        {
            BankAccountDto bankAccountDto;
            bool locked = false;

            try
            {
                if (rdbItIsLocked.Checked)
                {
                    locked = true;
                }
                else
                {
                    if (rdbItIsNotLocked.Checked)
                    {
                        locked = false;
                    }
                }

                bankAccountDto = new BankAccountDto
                {
                    AccountNumber = txtAccountNumber.Text.Trim(),
                    Balance = Convert.ToDecimal(txtBalance.Text),
                    BalanceInTransit = Convert.ToDecimal(txtBalanceInTransit.Text),
                    BalanceAvailable = Convert.ToDecimal(txtBalanceAvailable.Text),
                    AccountType = txtAccountType.Text.Trim(),
                    Incumbent = txtIncumbent.Text.Trim(),
                    IsItLocked = locked,
                    BankId = Convert.ToInt32(cbbBank.SelectedValue)
                };

                _bankManagementService.CreateBankAccount(bankAccountDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cbbBank_SelectedIndexChanged(sender, e);
                bankAccountDto = null;
            }
        }

        private void btnUpdateBankAccount_Click(object sender, EventArgs e)
        {
            BankAccountDto bankAccountDto;
            bool locked = false;

            try
            {
                if (rdbItIsLocked.Checked)
                {
                    locked = true;
                }
                else
                {
                    if (rdbItIsNotLocked.Checked)
                    {
                        locked = false;
                    }
                }

                bankAccountDto = new BankAccountDto
                {
                    Id = _bankAccountId,
                    AccountNumber = txtAccountNumber.Text.Trim(),
                    Balance = Convert.ToDecimal(txtBalance.Text),
                    BalanceInTransit = Convert.ToDecimal(txtBalanceInTransit.Text),
                    BalanceAvailable = Convert.ToDecimal(txtBalanceAvailable.Text),
                    AccountType = txtAccountType.Text.Trim(),
                    Incumbent = txtIncumbent.Text.Trim(),
                    IsItLocked = locked,
                    BankId = Convert.ToInt32(cbbBank.SelectedValue)
                };

                _bankManagementService.UpdateBankAccount(bankAccountDto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bankAccountDto = null;
            }
        }

        private void btnDeleteBankAccount_Click(object sender, EventArgs e)
        {
            if (_bankAccountId == 0)
            {
                MessageBox.Show("Debe seleccionar una cuenta");
                return;
            }

            try
            {
                _bankManagementService.RemoveBankAccount(_bankAccountId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                GetBanks();
            }
        }

        private void btnCancelChangeToBankAccount_Click(object sender, EventArgs e)
        {
            ClearBankAccountFields();
        }

        private void cbbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bankId = Convert.ToInt32(cbbBank.SelectedValue);
            try
            {
                BankDto banks = _bankManagementService.GetBankWithAccountsDtosById(bankId);
                if ((banks == null) || (banks.BankAccountDTOs.Count <= 0))
                {
                    MessageBox.Show("El banco no existe o no tiene cuentas registradas en este banco");
                }

                dgvAccount.DataSource = banks.BankAccountDTOs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAccount_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.Rows.Count > 0)
            {
                _bankAccountId = Convert.ToInt32(dgvAccount.CurrentRow.Cells["Id"].Value);
                txtAccountNumber.Text = dgvAccount.CurrentRow.Cells["AccountNumber"].Value.ToString();
                txtBalance.Text = dgvAccount.CurrentRow.Cells["Balance"].Value.ToString();
                txtBalanceInTransit.Text = dgvAccount.CurrentRow.Cells["BalanceInTransit"].Value.ToString();
                txtBalanceAvailable.Text = dgvAccount.CurrentRow.Cells["BalanceAvailable"].Value.ToString();
                txtAccountType.Text = dgvAccount.CurrentRow.Cells["AccountType"].Value.ToString();
                cbbBank.SelectedValue = Convert.ToInt32(dgvAccount.CurrentRow.Cells["BankId"].Value);
                txtIncumbent.Text = dgvAccount.CurrentRow.Cells["Incumbent"].Value.ToString();

                if (Convert.ToBoolean(dgvAccount.CurrentRow.Cells["IsItLocked"].Value) == true)
                {
                    rdbItIsLocked.Checked = true;
                }
                else
                {
                    rdbItIsNotLocked.Checked = true;
                }
            }
        }

        private void GetBanks()
        {
            try
            {
                IEnumerable<BankDto> banks = _bankManagementService.GetBankWithAccountsDtos();
                if (banks.Any())
                {
                    dataGridView1.DataSource = banks;
                }
                else
                {
                    MessageBox.Show("No se han registrados bancos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetBanksToComboBox()
        {
            try
            {
                IEnumerable<BankDto> banks = _bankManagementService.GetBankWithAccountsDtos();
                if (banks.Any())
                {
                    cbbBank.ValueMember = "Id";
                    cbbBank.DisplayMember = "BankName";
                    cbbBank.DataSource = banks;
                }
                else
                {
                    MessageBox.Show("No se han registrados bancos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetDataToBankDto()
        {
            _bankDto.Id = _id;
            _bankDto.BankName = txtBankName.Text.Trim();
            _bankDto.Phone = $"{ mtbPhoneBank.Text.Trim() }";
            _bankDto.City = txtCityBank.Text.Trim();
            _bankDto.Address = txtAddressBank.Text.Trim();
        }

        private void ClearFields()
        {
            _id = 0;
            txtBankName.Clear();
            mtbPhoneBank.Clear();
            txtCityBank.Clear();
            txtAddressBank.Clear();

            txtBankName.Focus();
        }

        private void ClearBankAccountFields()
        {
            _bankAccountId = 0;
            txtAccountNumber.Clear();
            txtAccountType.Clear();
            txtBalance.Clear();
            txtBalanceAvailable.Clear();
            txtBalanceInTransit.Clear();
            txtIncumbent.Clear();
            rdbItIsLocked.Checked = true;
        }
    }
}
