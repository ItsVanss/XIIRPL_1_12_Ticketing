using XIIRPL_1_12_Ticketing.MasterForm;

namespace XIIRPL_1_12_Ticketing
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }



        private void txtLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}