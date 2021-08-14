using System;

public class AgeIsNegativeException : Exception
{
    public AgeIsNegativeException(string message) : base(message)
    {
    }
}

