using Xunit;

namespace PontoEletronico.EntityFrameworkCore;

[CollectionDefinition(PontoEletronicoTestConsts.CollectionDefinitionName)]
public class PontoEletronicoEntityFrameworkCoreCollection : ICollectionFixture<PontoEletronicoEntityFrameworkCoreFixture>
{

}
