﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSDistribuidora.Mapeamento
{
   public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public float Valor { get; set; }
    }
}
