﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marcketplace.Models
{
    public class mdlVendedor
    {
        public int id { get; set; }
        public string razaosocial { get; set; }
        public string nomefantasia { get; set; }
        public string cnpj { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public int comissao { get; set; }
        public string endereco { get; set; }

    }


}