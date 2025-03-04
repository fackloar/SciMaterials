﻿using Microsoft.EntityFrameworkCore;
using NLog;
using SciMaterials.DAL.Models;
using SciMaterials.Data.Repositories;

namespace SciMaterials.DAL.Repositories.FilesRepositories;

/// <summary> Интерфейс репозитория для <see cref="FileGroup"/>. </summary>
public interface IFileGroupRepository : IRepository<FileGroup> { }

/// <summary> Репозиторий для <see cref="FileGroup"/>. </summary>
public class FileGroupRepository : IFileGroupRepository
{
    private readonly ILogger _logger;
    private readonly DbContext _context;

    /// <summary> ctor. </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public FileGroupRepository(
        DbContext context,
        ILogger logger)
    {
        _logger = logger;
        _logger.Debug($"Логгер встроен в {nameof(FileGroupRepository)}");

        _context = context;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Add"/>
    public void Add(FileGroup entity)
    {
        _logger.Debug(nameof(Add));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.AddAsync(T)"/>
    public async Task AddAsync(FileGroup entity)
    {
        _logger.Debug(nameof(AddAsync));
    }

    public async Task DeleteAsync(FileGroup entity) { throw new NotImplementedException(); }

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
    public List<FileGroup> GetAll(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAll));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetAllAsync(bool)"/>
    public Task<List<FileGroup>> GetAllAsync(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAllAsync));



        return null!;
    }

    public async Task<FileGroup?> GetByHashAsync(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public FileGroup? GetByHash(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public async Task<FileGroup?> GetByNameAsync(string name, bool DisableTracking = true) { throw new NotImplementedException(); }
    public FileGroup? GetByName(string name, bool DisableTracking = true) { throw new NotImplementedException(); }

    ///
    /// <inheritdoc cref="IRepository{T}.GetById(Guid, bool)"/>
    public FileGroup GetById(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetById));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetByIdAsync(Guid, bool)"/>
    public Task<FileGroup> GetByIdAsync(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetByIdAsync));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Update"/>
    public void Update(FileGroup entity)
    {
        _logger.Debug(nameof(Update));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.UpdateAsync(T)"/>
    public async Task UpdateAsync(FileGroup entity)
    {
        _logger.Debug(nameof(UpdateAsync));
    }

    public void Delete(FileGroup entity) { throw new NotImplementedException(); }
}