using System;
using System.Collections.Generic;
using System.Text;

namespace _6laba
{
    abstract class CustomException : Exception
    {
        public string ErrorClass { get; set; }

        public CustomException(string message, string ErrorClass)
            : base(message)
        {
            this.ErrorClass = ErrorClass;
        }
    }

    class ItemException : CustomException
    {
        public int Value { get; }
        public ItemException(string message, int val)
            :base(message,"Item")
        {
            Value = val;
        }
    }
    class GymException : CustomException
    {
        public int CountException { get; set; }
        public int ExpectedCount { get; set; }

        public GymException(string message, int CountException, int ExpectedCount)
            : base(message,"Gym")
        {
            this.CountException = CountException;
            this.ExpectedCount = ExpectedCount;
        }
    }
}
