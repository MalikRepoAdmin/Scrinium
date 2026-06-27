using System;
using System.Threading.Tasks;

public sealed class MaterialContentRepository
    : BaseRepository<MaterialContent>,
        IMaterialContentRepository
{
    public MaterialContentRepository(AppDbContext appDb)
        : base(appDb) { }

    /*
        Implementation
    */

    public Task<MaterialContent?> GetByMaterialIdAsync(Guid materialId)
    {
        return GetByIdAsync(materialId);
    }
}
