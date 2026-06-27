using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICollectionRepository
{
    Task<IReadOnlyList<Collection>> GetAllBySubjectAsync(Guid subjectId);

    Task<Collection?> GetByIdAsync(Guid id);

    Task AddAsync(Collection collection);

    Task UpdateAsync(Collection collection);

    Task DeleteAsync(Collection collection);
}
