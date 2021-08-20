using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGVES.BLL.Models;


namespace SGVES.BLL.Models
{
    public class TB901_ELEITORES
    {              
        public int NumTitulo { get; set; }
        public int Secao { get; set; }
        public int Zona { get; set; }
        public string Nome { get; set; }        
        public TB101_STATUS Status { get; set; } = new TB101_STATUS();
        public TB102_SEXO Sexo { get; set; } = new TB102_SEXO();

    }
}
