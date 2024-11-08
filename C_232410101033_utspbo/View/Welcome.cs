using C_232410101033_utspbo.View;

namespace C_232410101033_utspbo
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }

        private void btnInventaris_Click(object sender, EventArgs e)
        {
            Inventaris inventaris = new Inventaris();
            inventaris.Show();
            this.Hide();
        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            Registrasi registrasi = new Registrasi();
            registrasi.Show();
            this.Hide();
        }
    }

}
