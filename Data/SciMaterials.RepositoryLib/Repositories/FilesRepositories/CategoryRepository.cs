﻿using Microsoft.EntityFrameworkCore;
using NLog;
using SciMaterials.DAL.Models;
using SciMaterials.Data.Repositories;

namespace SciMaterials.DAL.Repositories.CategorysRepositories;


/// <summary> Интерфейс репозитория для <see cref="Category"/>. </summary>
public interface ICategoryRepository : IRepository<Category> { }

/// <summary> Репозиторий для <see cref="Category"/>. </summary>
public class CategoryRepository : ICategoryRepository
{
    private readonly ILogger _logger;
    private readonly DbContext _context;

    /// <summary> ctor. </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public CategoryRepository(
        DbContext context,
        ILogger logger)
    {
        _logger = logger;
        _logger.Debug($"Логгер встроен в {nameof(CategoryRepository)}");

        _context = context;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Add"/>
    public void Add(Category entity)
    {
        _logger.Debug(nameof(Add));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.AddAsync(T)"/>
    public async Task AddAsync(Category entity)
    {
        _logger.Debug(nameof(AddAsync));
    }

    public async Task DeleteAsync(Category entity) { throw new NotImplementedException(); }

    ///
    /// <inheritdoc cref="IRepository{T}.Delete(Guid)"/>
    public void Delete(Guid id)
    {
        _logger.Debug(nameof(Delete));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.DeleteAsync(Guid)"/>
    public async Task DeleteAsync(Guid id)
    {
        _logger.Debug(nameof(DeleteAsync));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetAll"/>
    public List<Category> GetAll(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAll));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetAllAsync(bool)"/>
    public Task<List<Category>> GetAllAsync(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAllAsync));



        return null!;
    }

    public async Task<Category?> GetByHashAsync(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public Category? GetByHash(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public async Task<Category?> GetByNameAsync(string name, bool DisableTracking = true) { throw new NotImplementedException(); }
    public Category? GetByName(string name, bool DisableTracking = true) { throw new NotImplementedException(); }

    ///
    /// <inheritdoc cref="IRepository{T}.GetById(Guid, bool)"/>
    public Category GetById(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetById));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetByIdAsync(Guid, bool)"/>
    public Task<Category> GetByIdAsync(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetByIdAsync));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Update"/>
    public void Update(Category entity)
    {
        _logger.Debug(nameof(Update));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.UpdateAsync(T)"/>
    public async Task UpdateAsync(Category entity)
    {
        _logger.Debug(nameof(UpdateAsync));
    }

    public void Delete(Category entity) { throw new NotImplementedException(); }
}