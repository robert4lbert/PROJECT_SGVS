

using SGVE.BLL.CustomException;
using SGVE.DAL;
using SGVS.Entities.Classes;


namespace SGVE.BLL.Autenticacao
{
    // B.L.O = Busines Library Owner
    public class LoginBLO
    {
        private LoginDAO _usuarioDAO;
        public TB001_LOGIN ObterUsuarioLogin(string userName, string password)
        {
            _usuarioDAO = new LoginDAO();
            var usuario = _usuarioDAO.ObterUsuario(userName, password);

            if (usuario != null)
            {
                return usuario;
            }
            else
            {
                throw new UsuarioNaoCadastradoException();
            }
        }
    }
}
