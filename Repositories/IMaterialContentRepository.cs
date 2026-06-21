using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IMaterialContentRepository
{
    
    Task<IReadOnlyList<MaterialContent>> GetAllByMaterialAsync(Guid materialId);

    Task<IReadOnlyList<MaterialContent>> GetAllAsync();

    Task AddAsync(MaterialContent materialContent);

    Task UpdateAsync(MaterialContent materialContent);

    Task DeleteAsync(Guid id);

}