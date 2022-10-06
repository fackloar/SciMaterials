using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;
using SciMaterials.API.Data.Interfaces;
using SciMaterials.API.DTO;
using SciMaterials.API.Mappings;
using SciMaterials.API.Services.Interfaces;

namespace SciMaterials.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FilesController : ControllerBase
{
    private readonly ILogger<FilesController> _logger;
    private readonly IFileService<Guid> _fileService;

    private void LogError(Exception ex, [CallerMemberName] string methodName = null!)
        => _logger.LogError(ex, "ошибка выполнения {error}", methodName);

    public FilesController(ILogger<FilesController> logger, IFileService<Guid> fileService)
    {
        _logger = logger;
        _fileService = fileService;
    }

    [HttpGet("GetByHash/{hash}")]
    public IActionResult GetByHash([FromRoute] string hash)
    {
        try
        {
            var fileInfo = _fileService.GetFileInfoByHash(hash);
            var response = fileInfo.ToFileGotResponse();
            return Ok(response);
        }
        catch (FileNotFoundException ex)
        {
            LogError(ex);
            var errorResponse = new ErrorResponse();
            return Ok(errorResponse.NotFound());
        }
        catch (Exception ex)
        {
            LogError(ex);
            throw;
        }
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById([FromRoute] Guid id)
    {
        try
        {
            var fileInfo = _fileService.GetFileInfoById(id);
            var response = fileInfo.ToFileGotResponse();
            return Ok(response);
        }
        catch (FileNotFoundException ex)
        {
            LogError(ex);
            var errorResponse = new ErrorResponse();
            return Ok(errorResponse.NotFound());
        }
        catch (Exception ex)
        {
            LogError(ex);
            throw;
        }
    }

    [HttpPost("Upload")]
    public async Task<IActionResult> UploadAsync()
    {
        try
        {
            var request = HttpContext.Request;

            if (!request.HasFormContentType ||
               !MediaTypeHeaderValue.TryParse(request.ContentType, out var mediaTypeHeader) ||
               string.IsNullOrEmpty(mediaTypeHeader.Boundary.Value))
            {
                var unsupportedMediaErrorResponse = new ErrorResponse().UnsupportedMedia();
                return Ok(unsupportedMediaErrorResponse);
            }

            var reader = new MultipartReader(mediaTypeHeader.Boundary.Value, request.Body);
            var section = await reader.ReadNextSectionAsync();

            while (section != null)
            {
                var hasContentDispositionHeader = ContentDispositionHeaderValue.TryParse(section.ContentDisposition,
                    out var contentDisposition);

                if (hasContentDispositionHeader && contentDisposition.DispositionType.Equals("form-data") &&
                    !string.IsNullOrEmpty(contentDisposition.FileName.Value))
                {
                    _logger.LogInformation("Section contains file {file}", contentDisposition.FileName.Value);
                    var result = await _fileService.UploadAsync(section.Body, contentDisposition.FileName.Value, section.ContentType ?? "application/octet-stream").ConfigureAwait(false);

                    return Ok(result.ToViewModel());
                }

                section = await reader.ReadNextSectionAsync();
            }
            var badRequestResponse = new ErrorResponse().BadRequest();
            return Ok(badRequestResponse);
        }
        catch (Exception ex)
        {
            LogError(ex);
            throw;
        }
    }

}
