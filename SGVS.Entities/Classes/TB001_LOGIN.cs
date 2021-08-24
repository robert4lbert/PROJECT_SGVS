using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGVS.Entities.Classes;

namespace SGVS.Entities.Classes
{
    public class TB001_LOGIN : TB101_STATUS
    {
        public string TB001_S_USUARIO { get; set; }
        public string TB001_S_PASSWORD { get; set; }
        public string TB001_S_PROFILE { get; set; }
        
    }
}
