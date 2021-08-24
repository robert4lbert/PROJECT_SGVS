using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGVS.Entities.Classes;

namespace SGVS.Entities.Classes
{
    class TB902_CANDIDATOS
    {
        public string  Nome { get; set; }
        public int NumeroEleitoral { get; set; }
        public TB101_STATUS Status { get; set; } = new TB101_STATUS();
        public TB102_SEXO Sexo { get; set; } = new TB102_SEXO();
        public TB903_PARTIDOS Partigo { get; set; } = new TB903_PARTIDOS();
    }
}
