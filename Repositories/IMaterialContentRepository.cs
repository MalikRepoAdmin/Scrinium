using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IMaterialContentRepository
{
    Task<MaterialContent?> GetByMaterialIdAsync(Guid materialId);

    Task AddAsync(MaterialContent materialContent);

    Task UpdateAsync(MaterialContent materialContent);

    Task DeleteAsync(MaterialContent materialContent);
}
