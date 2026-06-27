using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public sealed class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
{
    public SubjectRepository(AppDbContext appDb)
        : base(appDb) { }

    /*
        Implementation
    */

    public async Task<IReadOnlyList<Subject>> GetAllByLibraryAsync(Guid libraryId)
    {
        return await _appDb
            .Subjects.Where(s => s.LibraryId == libraryId)
            .AsNoTracking()
            .OrderBy(s => s.SubjectName)
            .ToListAsync();
    }
}
