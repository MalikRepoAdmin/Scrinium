using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class BaseRepository<T>
    where T : class
{
    protected AppDbContext _appDb { get; }
    protected DbSet<T> _dbSet { get; }

    public BaseRepository(AppDbContext appDb)
    {
        this._appDb = appDb;
        this._dbSet = appDb.Set<T>();
    }

    /*
        Implementation
    */

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        _dbSet.Add(entity);
        await _appDb.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        await _appDb.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _appDb.SaveChangesAsync();
    }
}
