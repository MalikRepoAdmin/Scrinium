using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public sealed class LibraryRepository : BaseRepository<Library>, ILibraryRepository
{
    public LibraryRepository(AppDbContext appDb)
        : base(appDb) { }

    /*
        Implementation
    */

    public async Task<IReadOnlyList<Library>> GetAllAsync()
    {
        return await _appDb.Libraries.AsNoTracking().OrderBy(l => l.LibraryName).ToListAsync();
    }
}
