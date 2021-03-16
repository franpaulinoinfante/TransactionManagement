using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransactionManagement.ApplicationService.ManagementServices.DocumentTypeManagementService;
using TransactionManagement.ApplicationService.ManagementServices.PersonManagementService.Icumbent;
using TransactionManagement.WindFormApp.Views.PersonViews;

namespace TransactionManagement.WinFormApp.Views
{
    public partial class DashBoard : Form
    {
        private readonly IIncumbentManagementService _icumbentManagementService;
        private readonly IDocumentTypeManagementService _documentTypeManagementService;

        public DashBoard(IIncumbentManagementService icumbentManagementService, IDocumentTypeManagementService documentTypeManagementService)
        {
            InitializeComponent();

            _icumbentManagementService = icumbentManagementService;
            _documentTypeManagementService = documentTypeManagementService;
        }

        private void iToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncumbentView myForm = new IncumbentView(_icumbentManagementService);
            myForm.MdiParent = this;
            myForm.Show();
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentTypeView myForm = new DocumentTypeView(_documentTypeManagementService);
            myForm.MdiParent = this;
            myForm.Show();

        }
    }
}
