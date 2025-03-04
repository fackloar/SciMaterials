﻿using Microsoft.EntityFrameworkCore;
using NLog;
using SciMaterials.Data.Repositories;
using File = SciMaterials.DAL.Models.File;

namespace SciMaterials.DAL.Repositories.FilesRepositories;

/// <summary> Интерфейс репозитория для <see cref="File"/>. </summary>
public interface IFileRepository : IRepository<File> { }

/// <summary> Репозиторий для <see cref="File"/>. </summary>
public class FileRepository : IFileRepository
{
    private readonly ILogger _logger;
    private readonly DbContext _context;

    /// <summary> ctor. </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public FileRepository(
        DbContext context,
        ILogger logger)
    {
        _logger = logger;
        _logger.Debug($"Логгер встроен в {nameof(FileRepository)}");

        _context = context;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Add"/>
    public void Add(File entity)
    {
        _logger.Debug(nameof(Add));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.AddAsync(T)"/>
    public async Task AddAsync(File entity)
    {
        _logger.Debug(nameof(AddAsync));
    }

    public async Task DeleteAsync(File entity) { throw new NotImplementedException(); }

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
    public List<File> GetAll(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAll));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetAllAsync(bool)"/>
    public Task<List<File>> GetAllAsync(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAllAsync));



        return null!;
    }

    public async Task<File?> GetByHashAsync(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public File? GetByHash(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public async Task<File?> GetByNameAsync(string name, bool DisableTracking = true) { throw new NotImplementedException(); }
    public File? GetByName(string name, bool DisableTracking = true) { throw new NotImplementedException(); }

    ///
    /// <inheritdoc cref="IRepository{T}.GetById(Guid, bool)"/>
    public File GetById(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetById));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetByIdAsync(Guid, bool)"/>
    public Task<File> GetByIdAsync(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetByIdAsync));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Update"/>
    public void Update(File entity)
    {
        _logger.Debug(nameof(Update));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.UpdateAsync(T)"/>
    public async Task UpdateAsync(File entity)
    {
        _logger.Debug(nameof(UpdateAsync));
    }

    public void Delete(File entity) { throw new NotImplementedException(); }
}