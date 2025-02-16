﻿namespace UltraGroup.Domain.Exceptions;

public sealed class UnderAgeException : CoreBusinessException
{
    public UnderAgeException()
    {
    }

    public UnderAgeException(string msg) : base(msg)
    {
    }

    public UnderAgeException(string message, Exception inner) : base(message, inner)
    {
    }
}
