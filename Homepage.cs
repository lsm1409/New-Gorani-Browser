using System;
using System.Windows.Forms;

namespace GoraniBrowser
{
    public partial class frmHomepage : Form
    {
        public frmHomepage()
        {
            InitializeComponent();
        }

        // txtUrl의 Text 속성 읽고 쓰는 프로퍼티
        public string txtUrlText
        {
            get
            {
                return txtUrl.Text;
            }
            set
            {
                txtUrl.Text = value;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        private void btnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}
