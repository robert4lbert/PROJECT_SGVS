
using SGVE.BLL.Autenticacao;
using SGVE.BLL.CustomException;
using System;
using System.Web.Security;

namespace Project_SGVS.Autenticacao
{
    public partial class tl_Login : System.Web.UI.Page
    {
        private LoginBLO _loginBLO;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {

            var nomeUsuario = txtUsuario.Text;
            var senha = txtSenha.Text;

            try
            {
                _loginBLO = new LoginBLO();
                var usuario = _loginBLO.ObterUsuarioLogin(nomeUsuario, senha);
                FormsAuthentication.RedirectFromLoginPage(nomeUsuario, false);
            }
            catch (UsuarioNaoCadastradoException)
            {
                lblStatus.Text = "Usuário não Cadastrado";
            }
            catch (Exception)
            {
                lblStatus.Text = "Erro Login, Consulte o Administrador do Sistema";
            }
        }
    }
}