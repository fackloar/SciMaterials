﻿using Microsoft.EntityFrameworkCore;
using NLog;
using SciMaterials.DAL.Models;
using SciMaterials.Data.Repositories;

namespace SciMaterials.DAL.Repositories.CommentsRepositories;

/// <summary> Интерфейс репозитория для <see cref="Comment"/>. </summary>
public interface ICommentRepository : IRepository<Comment> { }

/// <summary> Репозиторий для <see cref="Comment"/>. </summary>
public class CommentRepository : ICommentRepository
{
    private readonly ILogger _logger;
    private readonly DbContext _context;

    /// <summary> ctor. </summary>
    /// <param name="context"></param>
    /// <param name="logger"></param>
    public CommentRepository(
        DbContext context,
        ILogger logger)
    {
        _logger = logger;
        _logger.Debug($"Логгер встроен в {nameof(CommentRepository)}");

        _context = context;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Add"/>
    public void Add(Comment entity)
    {
        _logger.Debug(nameof(Add));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.AddAsync(T)"/>
    public async Task AddAsync(Comment entity)
    {
        _logger.Debug(nameof(AddAsync));
    }

    public async Task DeleteAsync(Comment entity) { throw new NotImplementedException(); }

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
    public List<Comment> GetAll(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAll));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetAllAsync(bool)"/>
    public Task<List<Comment>> GetAllAsync(bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetAllAsync));



        return null!;
    }

    public async Task<Comment?> GetByHashAsync(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public Comment? GetByHash(string hash, bool DisableTracking = true) { throw new NotImplementedException(); }
    public async Task<Comment?> GetByNameAsync(string name, bool DisableTracking = true) { throw new NotImplementedException(); }
    public Comment? GetByName(string name, bool DisableTracking = true) { throw new NotImplementedException(); }

    ///
    /// <inheritdoc cref="IRepository{T}.GetById(Guid, bool)"/>
    public Comment GetById(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetById));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.GetByIdAsync(Guid, bool)"/>
    public Task<Comment> GetByIdAsync(Guid id, bool DisableTracking = true)
    {
        _logger.Debug(nameof(GetByIdAsync));



        return null!;
    }

    ///
    /// <inheritdoc cref="IRepository{T}.Update"/>
    public void Update(Comment entity)
    {
        _logger.Debug(nameof(Update));
    }

    ///
    /// <inheritdoc cref="IRepository{T}.UpdateAsync(T)"/>
    public async Task UpdateAsync(Comment entity)
    {
        _logger.Debug(nameof(UpdateAsync));
    }

    public void Delete(Comment entity) { throw new NotImplementedException(); }
}