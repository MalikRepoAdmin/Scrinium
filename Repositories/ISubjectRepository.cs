using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ISubjectRepository
{
    
    Task<IReadOnlyList<Subject>> GetAllByLibraryAsync(Guid libraryId);

    Task<Subject> GetByIdAsync(Guid id);

    Task AddAsync(Subject subject);

    Task UpdateAsync(Subject subject);

    Task DeleteWithAllChildAsync(Guid id);

}