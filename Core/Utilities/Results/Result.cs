﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        private bool v1;
        private string v2;

        //Constrctor
        public Result(bool success, string message)
        {
            Message = message;
            Success = success;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success {get;}

        public string Message  {get;}
    }
}
