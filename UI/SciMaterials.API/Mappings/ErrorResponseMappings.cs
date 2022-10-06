using Microsoft.AspNetCore.Mvc;
using SciMaterials.API.DTO;
using System.Runtime.CompilerServices;

namespace SciMaterials.API.Mappings
{
    public static class ErrorResponseMappings
    {
        public static ErrorResponse? NotFound(this ErrorResponse? errorResponse)
            => errorResponse is null
                ? null
                : new ErrorResponse()
                {
                    Code = new NotFoundResult().StatusCode,
                    ErrorMessage = "File not found on the server"
                };

        public static ErrorResponse? UnsupportedMedia(this ErrorResponse? errorResponse)
            => errorResponse is null
                ? null
                : new ErrorResponse()
                {
                    Code = new UnsupportedMediaTypeResult().StatusCode,
                    ErrorMessage = "The file was of unsupported media type"
                };

        public static ErrorResponse? BadRequest(this ErrorResponse? errorResponse)
            => errorResponse is null
                ? null
                : new ErrorResponse()
                {
                    Code = new BadRequestResult().StatusCode,
                    ErrorMessage = "Bad Request"
                };
    }
}
