using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Results
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public T Data { get; set; }

        public static Result<T> Success(T data, string message = "")
        {
            return new Result<T> 
            { 
                IsSuccess = true, 
                Message = message,
                Data = data,
            };
        }

        public static Result<T> Failure(string message = "")
        {
            return new Result<T> 
            { 
                IsSuccess = false,
                Message = message,
                Data = default,
            };
        }
    }

    public class Result
    {
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; } = string.Empty;

        public static Result Success(string message = "")
        {
            return new Result
            {
                IsSuccess = true,
                Message = message,
            };
        }

        public static Result Failure(string message = "")
        {
            return new Result
            {
                IsSuccess = false,
                Message = message,
            };
        }
    }
}
