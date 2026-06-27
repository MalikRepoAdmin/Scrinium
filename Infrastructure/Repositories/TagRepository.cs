using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public sealed class TagRepository : BaseRepository<Tag>, ITagRepository
{
    public TagRepository(AppDbContext appDb)
        : base(appDb) { }

    /*
        Implementation
    */

    public async Task<IReadOnlyList<Tag>> GetAllAsync()
    {
        return await _appDb.Tags.AsNoTracking().OrderBy(m => m.Name).ToListAsync();
    }

    public async Task<Tag?> GetByNameAsync(string name)
    {
        return await _appDb.Tags.FirstOrDefaultAsync(t => t.Name == name);
    }
}
