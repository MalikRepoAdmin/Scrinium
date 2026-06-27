using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IMaterialRepository
{
    Task<IReadOnlyList<Material>> GetAllBySubjectAsync(Guid subjectId);

    Task<IReadOnlyList<Material>> GetAllByCollectionAsync(Guid collectionId);

    Task<Material?> GetByIdAsync(Guid id);

    Task<IReadOnlyList<Material>> SearchAsync(string query, Guid? subjectId);

    Task AddAsync(Material material);

    Task UpdateAsync(Material material);

    Task DeleteAsync(Material material);
}
