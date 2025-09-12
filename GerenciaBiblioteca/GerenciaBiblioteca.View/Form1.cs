using GerenciaBiblioteca.Domain;

namespace GerenciaBiblioteca
{
    public partial class Form1 : Form
    {
        public Usuario user;
        public Form1()
        {
            InitializeComponent();
            user = new Usuario();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(UsernameTxt.Text) || String.IsNullOrEmpty(PasswordTxt.Text))
                MessageBox.Show("Campo(s) de usuário ou senha vazio(s)");
            else
            {
                user.Username = UsernameTxt.Text;
                user.Password = PasswordTxt.Text;

                string mensagem = $"usuário {user.Username} logado com sucesso!";
                MessageBox.Show(mensagem);

                UsernameTxt.Text = string.Empty;
                PasswordTxt.Text = string.Empty;
            }
        }
    }
}
