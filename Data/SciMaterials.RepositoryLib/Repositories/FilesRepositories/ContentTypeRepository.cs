﻿using Microsoft.EntityFrameworkCore;
using NLog;
using SciMaterials.DAL.Models;
using SciMaterials.Data.Repositories;

namespace SciMaterials.DAL.Repositories.ContentTypesRepositories;

/// <summary> Интерфейс репозитория для <see cref="ContentType"/>. </summary>
public interface IContentTypeRepository : IRepository<ContentType> { }

/// <summary> Репозиторий для <see cref="ContentType"/>. </summary>
public class ContentTypeRepository : IContentTypeRepository
{
    private readonly ILogger _logger;
    private readonly DbContext _context;

    /// <summary> ctor. </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public ContentTypeRepository(
        DbContext context,
        ILogger logger)
    {
        _logger = logger;
        _logger.Debug($"Логгер встроен в {nameof(ContentTypeRepository)}");

        _context = context;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Add"/>
    public void Add(ContentType entity)
    {
        _logger.Debug(nameof(Add));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.AddAsync(T)"/>
    public async Task AddAsync(ContentType entity)
    {
        _logger.Debug(nameof(AddAsync));
    }

    public async Task DeleteAsync(ContentType entity) { throw new NotImplementedException(); }

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
    public List<ContentType> GetAll(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAll));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetAllAsync(bool)"/>
    public Task<List<ContentType>> GetAllAsync(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAllAsync));



        return null!;
    }

    public async Task<ContentType?> GetByHashAsync(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public ContentType? GetByHash(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public async Task<ContentType?> GetByNameAsync(string name, bool DisableTracking = true) { throw new NotImplementedException(); }
    public ContentType? GetByName(string name, bool DisableTracking = true) { throw new NotImplementedException(); }

    ///
    /// <inheritdoc cref="IRepository{T}.GetById(Guid, bool)"/>
    public ContentType GetById(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetById));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetByIdAsync(Guid, bool)"/>
    public Task<ContentType> GetByIdAsync(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetByIdAsync));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Update"/>
    public void Update(ContentType entity)
    {
        _logger.Debug(nameof(Update));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.UpdateAsync(T)"/>
    public async Task UpdateAsync(ContentType entity)
    {
        _logger.Debug(nameof(UpdateAsync));
    }

    public void Delete(ContentType entity) { throw new NotImplementedException(); }
}