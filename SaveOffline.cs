using System;
using System.Windows.Forms;

namespace GoraniBrowser
{
    public partial class frmSaveOffline : Form
    {
        public frmSaveOffline()
        {
            InitializeComponent();
        }

        public string txtNameText
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}
