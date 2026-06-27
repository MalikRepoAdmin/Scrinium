using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ILibraryRepository
{
    Task<IReadOnlyList<Library>> GetAllAsync();

    Task<Library?> GetByIdAsync(Guid id);

    Task AddAsync(Library library);

    Task UpdateAsync(Library library);

    Task DeleteAsync(Library library);
}
