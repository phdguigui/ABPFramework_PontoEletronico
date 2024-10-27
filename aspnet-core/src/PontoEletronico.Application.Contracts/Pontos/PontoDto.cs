using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace PontoEletronico.Pontos
{
    public class PontoDto : EntityDto<int>
    {
        public int FuncionarioId { get; set; }
        public DateTime Data { get; set; }
        public EnumModalidade Modalidade { get; set; }
    }
}
