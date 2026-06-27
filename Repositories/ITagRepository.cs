using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ITagRepository
{
    Task<IReadOnlyList<Tag>> GetAllAsync();

    Task<Tag?> GetByIdAsync(Guid id);

    Task<Tag?> GetByNameAsync(string name);

    Task AddAsync(Tag tag);

    Task UpdateAsync(Tag tag);

    Task DeleteAsync(Tag tag);
}
