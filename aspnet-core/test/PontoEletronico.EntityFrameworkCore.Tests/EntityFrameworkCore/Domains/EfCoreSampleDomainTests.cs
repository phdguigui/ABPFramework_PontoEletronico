using PontoEletronico.Samples;
using Xunit;

namespace PontoEletronico.EntityFrameworkCore.Domains;

[Collection(PontoEletronicoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PontoEletronicoEntityFrameworkCoreTestModule>
{

}
