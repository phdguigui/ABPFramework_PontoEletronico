using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace PontoEletronico.Pontos
{
    public class Ponto : Entity<int>
    {
        public int FuncionarioId { get; set; }
        public DateTime Data { get; set; }
        public EnumModalidade Modalidade { get; set; }
    }
}
