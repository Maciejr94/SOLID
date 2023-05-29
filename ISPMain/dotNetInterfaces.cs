using System;
using System.Collections;

public class DotNetInterfaces : IComparable, ICloneable, IEnumerator, IDisposable
{
	public DotNetInterfaces() 
	{
	}

    public object Current => throw new NotImplementedException();

    public object Clone()
    {
        throw new NotImplementedException();
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
