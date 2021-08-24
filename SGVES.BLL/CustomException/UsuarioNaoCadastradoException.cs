
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGVE.BLL.CustomException
{
    public class UsuarioNaoCadastradoException : Exception
    {
        public UsuarioNaoCadastradoException()
        {

        }

        public UsuarioNaoCadastradoException(String message) : base(message)
        {

        }
        
        public UsuarioNaoCadastradoException(String message, Exception inner) : base(message, inner)
        {
            
        }
    }
}
