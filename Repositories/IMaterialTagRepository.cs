using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IMaterialTagRepository
{

    Task<IReadOnlyList<MaterialTag>> GetAllAsync();

    Task<IReadOnlyList<Material>> GetAllMaterialByTagAsync(Guid tagId);

    Task<IReadOnlyList<Tag>> GetAllTagByMaterialAsync(Guid materialId);

    Task AddTagToMaterialAsync(Guid materialId, Guid tagId);

    Task RemoveTagFromMaterialAsync(Guid materialId, Guid tagId);

}