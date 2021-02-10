using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result (bool success)
        {
            Sucess = Sucess;
        }

        public bool Sucess { get; }

        public string Message { get; }
    }
}
