using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace PontoEletronico.Setores
{
    public class Setor : Entity<int>
    {
        public string Nome { get; set; }
        public string Sala { get; set; }
    }
}
