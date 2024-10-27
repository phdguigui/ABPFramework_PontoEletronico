using PontoEletronico.Samples;
using Xunit;

namespace PontoEletronico.EntityFrameworkCore.Applications;

[Collection(PontoEletronicoTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PontoEletronicoEntityFrameworkCoreTestModule>
{

}
