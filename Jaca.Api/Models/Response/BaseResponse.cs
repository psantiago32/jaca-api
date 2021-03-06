﻿using System.Net;

namespace Jaca.Api.Models.Response
{
    public class BaseResponse<T>
    {
        public bool IsSuccess { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public T SuccessBody { get; set; }

        public ErrorResponse ErrorBody { get; set; }
    }
}
