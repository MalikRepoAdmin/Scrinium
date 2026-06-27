using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public sealed class CollectionRepository : BaseRepository<Collection>, ICollectionRepository
{
    public CollectionRepository(AppDbContext appDb)
        : base(appDb) { }

    /*
        Implementation
    */

    public async Task<IReadOnlyList<Collection>> GetAllBySubjectAsync(Guid subjectId)
    {
        return await _appDb
            .Collections.Where(c => c.SubjectId == subjectId)
            .AsNoTracking()
            .OrderBy(c => c.Name)
            .ToListAsync();
    }
}
