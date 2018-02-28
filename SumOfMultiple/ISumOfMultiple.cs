using System;

namespace Runner
{
    public interface ISumOfMultiple : IDisposable
    {
        int Call(int input);
    }
}
