using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SGVES.BLL.Models
{
    
    public class TB903_PARTIDOS
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public TB101_STATUS Status { get; set; } = new TB101_STATUS();
    }
}
