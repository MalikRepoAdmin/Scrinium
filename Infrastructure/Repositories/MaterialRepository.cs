using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public sealed class MaterialRepository : BaseRepository<Material>, IMaterialRepository
{
    public MaterialRepository(AppDbContext appDb)
        : base(appDb) { }

    /*
        Implementation
    */

    public async Task<IReadOnlyList<Material>> GetAllBySubjectAsync(Guid subjectId)
    {
        return await _appDb
            .Materials.Where(m => m.SubjectId == subjectId && m.CollectionId == null)
            .AsNoTracking()
            .OrderBy(m => m.Title)
            .ToListAsync();
    }

    public async Task<IReadOnlyList<Material>> GetAllByCollectionAsync(Guid collectionId)
    {
        return await _appDb
            .Materials.Where(m => m.CollectionId == collectionId)
            .AsNoTracking()
            .OrderBy(m => m.Title)
            .ToListAsync();
    }

    // TODO: Implement SearchAsync method in MaterialRepository
    public async Task<IReadOnlyList<Material>> SearchAsync(string query, Guid? subjectId)
    {
        return null;
    }
}
