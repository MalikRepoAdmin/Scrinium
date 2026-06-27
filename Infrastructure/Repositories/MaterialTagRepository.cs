using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public sealed class MaterialTagRepository : IMaterialTagRepository
{
    private readonly AppDbContext _appDb;

    public MaterialTagRepository(AppDbContext appDb)
    {
        this._appDb = appDb;
    }

    /*
        Implementation
    */

    public async Task<IReadOnlyList<MaterialTag>> GetAllAsync()
    {
        return await _appDb
            .MaterialTags.AsNoTracking()
            .OrderBy(mt => mt.MaterialId)
            .ThenBy(mt => mt.TagId)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Material>> GetMaterialsByTagAsync(Guid tagId)
    {
        return await _appDb
            .MaterialTags.Where(mt => mt.TagId == tagId)
            .AsNoTracking()
            .OrderBy(mt => mt.MaterialId)
            .Select(mt => mt.Material)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Tag>> GetTagsByMaterialAsync(Guid materialId)
    {
        return await _appDb
            .MaterialTags.Where(mt => mt.MaterialId == materialId)
            .AsNoTracking()
            .OrderBy(mt => mt.TagId)
            .Select(mt => mt.Tag)
            .ToListAsync();
    }

    public async Task AddTagToMaterialAsync(Guid materialId, Guid tagId)
    {
        var materialTag = new MaterialTag { MaterialId = materialId, TagId = tagId };

        _appDb.MaterialTags.Add(materialTag);
        await _appDb.SaveChangesAsync();
    }

    public async Task RemoveTagFromMaterialAsync(Guid materialId, Guid tagId)
    {
        var materialTag = new MaterialTag { MaterialId = materialId, TagId = tagId };

        _appDb.MaterialTags.Remove(materialTag);
        await _appDb.SaveChangesAsync();
    }
}
