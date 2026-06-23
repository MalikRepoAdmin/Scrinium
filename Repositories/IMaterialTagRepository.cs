using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IMaterialTagRepository
{
    Task<IReadOnlyList<MaterialTag>> GetAllAsync();

    Task<IReadOnlyList<Material>> GetMaterialsByTagAsync(Guid tagId);

    Task<IReadOnlyList<Tag>> GetTagsByMaterialAsync(Guid materialId);

    Task AddTagToMaterialAsync(Guid materialId, Guid tagId);

    Task RemoveTagFromMaterialAsync(Guid materialId, Guid tagId);
}
