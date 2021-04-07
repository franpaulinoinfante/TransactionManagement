using System;
using System.Windows.Forms;
using TransactionManagement.ApplicationService.Application.ManagementServices;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.ApplicationService.ManagementServices.UserManagementServices;
using TransactionManagement.WindFormApp.Views.BankViews;
using TransactionManagement.WindFormApp.Views.DocumentTypeViews;
using TransactionManagement.WindFormApp.Views.UserViews;

namespace TransactionManagement.WinFormApp.Views
{
    public partial class DashBoard : Form
    {
        private readonly IDocumentTypeManagementService _documentTypeManagementService;
        private readonly IUserManagementService _userManagementService;
        private readonly IBankManagementService _bankManagementService;

        public DashBoard(
            IDocumentTypeManagementService documentTypeManagementService, IUserManagementService userManagementService, IBankManagementService bankManagementService)
        {
            InitializeComponent();

            _documentTypeManagementService = documentTypeManagementService;
            _userManagementService = userManagementService;
            _bankManagementService = bankManagementService;
        }


        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentTypeView myForm = new DocumentTypeView(_documentTypeManagementService)
            {
                MdiParent = this
            };
            myForm.Show();

        }

        private void documentTypePruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentTypeViewHandle myForm = new DocumentTypeViewHandle()
            {
                MdiParent = this
            };
            myForm.Show();
        }

        private void uuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserIndexView myForm = new UserIndexView(_userManagementService)
            {
                MdiParent = this
            };

            myForm.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankView myForm = new BankView(_bankManagementService)
            {
                MdiParent = this
            };

            myForm.Show();
        }
    }
}
